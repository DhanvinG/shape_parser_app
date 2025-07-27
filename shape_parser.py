"""
Cylinder: [radius, height, 0]

Box:      [length, width, height]

Sphere:   [radius, 0, 0]

Cone:     [base_radius, 0, height]

Pyramid:  [base_length, base_width, height]

Torus:    [major_radius, minor_radius, 0]
Feature vector: [shape_id, p1, p2, p3]
  shape_id ∈ {0=Cylinder,1=Box,2=Sphere,3=Cone,4=Pyramid,5=Torus}
"""
from __future__ import annotations
import re
from dataclasses import dataclass, asdict
from typing import Dict, List, Optional, Tuple

_NUM = r"([0-9]+(?:\.[0-9]+)?)"  # integer or decimal
_UNIT = r"\s*(?:in|inch|inches)?"
RE = re.compile
FLAGS = re.IGNORECASE | re.MULTILINE

R_DIAM_ANCHOR     = RE(r"\bConstraintType\s*\.\s*DIAMETER\b", FLAGS)
R_RADIUS_ANCHOR   = RE(r"\bConstraintType\s*\.\s*RADIUS\b", FLAGS)
R_DISTANCE_ANCHOR = RE(r"\bConstraintType\s*\.\s*DISTANCE\b", FLAGS)
R_LENGTH1_ANCHOR  = RE(r"ConstraintType\s*\.\s*LENGTH\b[^\n\r]*?\bindex\b[^\n\r]*?1", FLAGS)
R_LENGTH2_ANCHOR  = RE(r"ConstraintType\s*\.\s*LENGTH\b[^\n\r]*?\bindex\b[^\n\r]*?2", FLAGS)
R_EXTRUDE_ANCHOR  = RE(r"\bextrude\b", FLAGS)
R_LOFT            = RE(r"\bloft\s*\(", FLAGS)
R_SKPOINT         = RE(r"\bskPoint\b", FLAGS)
R_CPLANE_CALL     = RE(r"\bcPlane\s*\(", FLAGS)
R_CPLANE_ANCHOR   = RE(r"\bcPlane\s*\.\s*offset\b", FLAGS)
R_CPLANE_ANCHOR2  = RE(r"\bCPlane\s*OFFSET\b", FLAGS)

R_REVOLVE_FULL    = RE(r"\brevolveType\b\s*[:=]\s*(?:RevolveType\s*\.\s*)?FULL\b", FLAGS)
R_REVOLVE_CALL    = RE(r"\brevolve\s*\(", FLAGS)

R_SKCIRCLE       = RE(r"\bskCircle\b", FLAGS)
R_SKARC          = RE(r"\bskArc\b", FLAGS)
R_SKLINE         = RE(r"\bskLineSegment\b", FLAGS)
R_PARALLEL       = RE(r"\bPARALLEL\b", FLAGS)
R_PERP           = RE(r"\bPERPENDICULAR\b", FLAGS)
R_COINCIDENT     = RE(r"\bCOINCIDENT\b", FLAGS)
R_MIDPOINT       = RE(r"\bMIDPOINT\b", FLAGS)

FIELD_TRY_TPL    = lambda f: RE(rf"\b{f}\b[\s\S]{{0,200}}?try\(\s*{_NUM}\s*\*\s*inch", FLAGS)
FIELD_EXPR_TPL   = lambda f: RE(rf"\b{f}\b[\s\S]{{0,200}}?\bexpression\b\s*[:=]\s*\"?\s*{_NUM}\s*in", FLAGS)
FIELD_SIMPLE_TPL = lambda f: RE(rf"\b{f}\b[\s\S]{{0,80}}?[:=]\s*{_NUM}{_UNIT}", FLAGS)

DEG_TRY_TPL      = lambda f: RE(rf"\b{f}\b[\s\S]{{0,200}}?try\(\s*{_NUM}\s*\*\s*degree", FLAGS)
DEG_DEG_TPL      = lambda f: RE(rf"\b{f}\b[\s\S]{{0,200}}?{_NUM}\s*deg", FLAGS)

def _to_float(num: str) -> float:
    try: return float(num)
    except: return float("nan")

def _first_field_after(anchor: re.Pattern, text: str, field: str,
                       start_pos: int = 0, window: int = 1000
) -> Optional[Tuple[float, str]]:
    m = anchor.search(text, pos=start_pos)
    if not m: return None
    seg = text[m.start(): m.start() + window]
    for pat in (FIELD_TRY_TPL(field), FIELD_EXPR_TPL(field), FIELD_SIMPLE_TPL(field)):
        mm = pat.search(seg)
        if mm:
            return _to_float(mm.group(1)), mm.group(0).strip()
    return None

def _all_fields_after(anchor: re.Pattern, text: str, field: str,
                      window: int = 1000
) -> List[Tuple[float, str]]:
    out = []
    start = 0
    while True:
        m = anchor.search(text, pos=start)
        if not m: break
        seg = text[m.start(): m.start() + window]
        for pat in (FIELD_TRY_TPL(field), FIELD_EXPR_TPL(field), FIELD_SIMPLE_TPL(field)):
            mm = pat.search(seg)
            if mm:
                out.append((_to_float(mm.group(1)), mm.group(0).strip()))
                break
        start = m.end()
    return out

def _first_degree_after(anchor: re.Pattern, text: str, field: str,
                        window: int = 1000
) -> Optional[float]:
    m = anchor.search(text)
    if not m: return None
    seg = text[m.start(): m.start() + window]
    mm = DEG_TRY_TPL(field).search(seg)
    if mm: return _to_float(mm.group(1))
    mm = DEG_DEG_TPL(field).search(seg)
    if mm: return _to_float(mm.group(1))
    return None

@dataclass
class ParseResult:
    shape: Optional[str]
    parameters: Dict[str, float]
    evidence: List[str]
    feature_vector: Optional[List[float]]
    def as_dict(self) -> Dict: return asdict(self)

def _maybe_feature_vector(shape: Optional[str], params: Dict[str, float]
) -> Optional[List[float]]:
    if shape is None: return None

    # map shape
    shape_map = {
        "Cylinder":        0,
        "Cube":            1,
        "rectangular_prism":1,
        "square":          1,
        "rectangle":       1,
        "Sphere":          2,
        "Cone":            3,
        "Pyramid":         4,
        "Torus":           5,
    }
    shape_id = float(shape_map.get(shape, -1))

    # default params
    p1 = p2 = p3 = -1.0
    if shape == "Cylinder":
        p1 = params.get("radius", 0.0)
        p2 = params.get("height", 0.0)
    elif shape in ("Cube","rectangular_prism","square","rectangle"):
        p1 = params.get("length", 0.0)
        p2 = params.get("width",  0.0)
        p3 = params.get("height", 0.0)
    elif shape == "Sphere":
        p1 = params.get("radius", 0.0)
    elif shape == "Cone":
        p1 = params.get("base_radius", 0.0)
        p2 = params.get("height",       0.0)
    elif shape == "Pyramid":
        p1 = params.get("base_length", 0.0)
        p2 = params.get("base_width",  0.0)
        p3 = params.get("height",      0.0)
    elif shape == "Torus":
        p1 = params.get("major_radius", 0.0)
        p2 = params.get("minor_radius", 0.0)

    return [shape_id, float(p1), float(p2), float(p3)]

def parse_shape(text: str) -> ParseResult:
    t = text
    ev: List[str] = []
    params: Dict[str, float] = {}

    # --- structural counts ---
    n_circle = len(R_SKCIRCLE.findall(t))
    has_arc = bool(R_SKARC.search(t))
    # <<< ADD THIS LINE >>>
    has_circle_or_arc = (n_circle >= 1) or has_arc

    n_line = len(R_SKLINE.findall(t))
    n_parallel = len(R_PARALLEL.findall(t))
    n_perp = len(R_PERP.findall(t))
    n_coincident = len(R_COINCIDENT.findall(t))
    n_midpoint = len(R_MIDPOINT.findall(t))
    n_point = len(R_SKPOINT.findall(t))
    ev.append(
        f"counts: circle={n_circle}, arc={int(has_arc)}, "
        f"line={n_line}, parallel={n_parallel}, perp={n_perp}, "
        f"coincident={n_coincident}, midpoint={n_midpoint}, point={n_point}"
    )

    # numeric extraction (robust)
    diam = _first_field_after(R_DIAM_ANCHOR, t, "length")
    if diam:
        params["diameter"], s = diam; ev.append(s)
    rad = _first_field_after(R_RADIUS_ANCHOR, t, "length")
    if rad and "radius" not in params:
        params["radius"], s = rad; ev.append(s)
    L1 = _first_field_after(R_LENGTH1_ANCHOR, t, "length")
    L2 = _first_field_after(R_LENGTH2_ANCHOR, t, "length")
    if L1:
        params["length"], s = L1; ev.append(s)
    if L2:
        params["width"],  s = L2; ev.append(s)
    distances = _all_fields_after(R_DISTANCE_ANCHOR, t, "length")
    if distances:
        if "length" not in params:
            params["length"], s = distances[0]; ev.append(s)
        if "width" not in params and len(distances) > 1:
            params["width"],  s = distances[1]; ev.append(s)
    depth = _first_field_after(R_EXTRUDE_ANCHOR, t, "depth")
    if depth:
        params["height"], s = depth; ev.append(s)
    cpo = (
        _first_field_after(R_CPLANE_ANCHOR,  t, "offset")
        or _first_field_after(R_CPLANE_ANCHOR2, t, "offset")
        or _first_field_after(R_CPLANE_CALL,   t, "offset")
    )
    if cpo:
        params["height"], s = cpo; ev.append(s)

    angle_deg = _first_degree_after(R_REVOLVE_CALL, t, "angle")
    angle_back = _first_degree_after(R_REVOLVE_CALL, t, "angleBack")
    full_rev = bool(R_REVOLVE_FULL.search(t))
    rev_call = bool(R_REVOLVE_CALL.search(t))
    def _is_full(a,b):
        tol=1e-2
        return (a and abs(a-360.)<tol) or (b and abs(b-360.)<tol) or (a and b and abs(a+b-360.)<tol)

    # Torus
    if n_circle>=1 and rev_call and (full_rev or _is_full(angle_deg,angle_back)):
        if "radius" not in params and "diameter" in params:
            params["radius"] = params["diameter"]/2.; ev.append("Derived Torus minor radius = diameter/2")
        major=0.0
        if "radius" in params and distances:
            minor=params["radius"]
            larger=[v for v,_ in distances if v>minor]
            if larger:
                major=max(larger)
                for v,s in distances:
                    if v==major: ev.append(f"Guessed Torus major radius from distance: {s}"); break
        params.setdefault("minor_radius",params["radius"])
        params.setdefault("major_radius",major)
        return ParseResult("Torus",
            {"major_radius":params["major_radius"],"minor_radius":params["minor_radius"]},
            ev+["revolve FULL detected for Torus."],
            _maybe_feature_vector("Torus",params)
        )

    # Sphere
    if full_rev or (rev_call and _is_full(angle_deg,angle_back)) or (has_circle_or_arc and n_midpoint>0 and n_coincident>0 and not depth):
        if "radius" not in params:
            if "diameter" in params:
                params["radius"]=params["diameter"]/2.; ev.append("Derived Sphere radius = diameter/2")
            elif "length" in params:
                params["radius"]=params["length"]/2.; ev.append("Derived Sphere radius = LENGTH/2")
        return ParseResult("Sphere",
            {"radius":params["radius"]},
            ev+["revolveType FULL matched" if full_rev else ""]+["revolve() with ~360° detected" if (rev_call and _is_full(angle_deg,angle_back)) else ""],
            _maybe_feature_vector("Sphere",params)
        )

    # Pyramid
    if n_line>=4 and n_parallel>=2 and n_perp>=1 and (len(distances)>=2 or ("length" in params and "width" in params)) and cpo and n_point>=1 and R_LOFT.search(t):
        bl = params.get("length", distances[0][0] if distances else 0.0)
        bw = params.get("width",  distances[1][0] if len(distances)>1 else 0.0)
        params["base_length"]=bl; params["base_width"]=bw
        return ParseResult("Pyramid",
            {"base_length":bl,"base_width":bw,"height":params["height"]},
            ev+["Detected loft from base to point; interpreted as Pyramid."],
            _maybe_feature_vector("Pyramid",params)
        )

    # Cylinder
    if n_circle>=1 and _first_field_after(R_DIAM_ANCHOR,t,"length") and depth:
        if "radius" not in params and "diameter" in params:
            params["radius"]=params["diameter"]/2.; ev.append("Derived radius = diameter/2")
        return ParseResult("Cylinder",
            {"radius":params["radius"],"height":params["height"]},
            ev+[f"circles={n_circle}","extrude depth present"],
            _maybe_feature_vector("Cylinder",params)
        )

    # Box
    if n_line>=4 and n_parallel>=2 and n_perp>=1 and (len(distances)>=2 or ("length" in params and "width" in params)) and depth:
        l=params.get("length"); w=params.get("width"); h=params.get("height")
        if l is not None and w is not None:
            if abs(l-w)<1e-6 and h is not None and abs(h-l)<1e-6: shape="Cube"
            elif abs(l-w)<1e-6: shape="square" if h is None else "rectangular_prism"
            else: shape="rectangle" if h is None else "rectangular_prism"
        else:
            shape="rectangular_prism" if h is not None else "rectangle"
        return ParseResult(shape,
            {"length":params["length"],"width":params["width"],"height":params["height"]},
            ev+[f"lines={n_line}, parallel={n_parallel}, perp={n_perp}"],
            _maybe_feature_vector("rectangular_prism",params)
        )

    # Cone
    if _first_field_after(R_DIAM_ANCHOR,t,"length") and cpo and not full_rev:
        params.setdefault("base_radius",params["diameter"]/2.0)
        return ParseResult("Cone",
            {"base_radius":params["base_radius"],"height":params["height"]},
            ev+["assumed right circular Cone: top_radius=0"],
            _maybe_feature_vector("Cone",params)
        )

    return ParseResult(None, {}, ev, None)

if __name__ == "__main__":
    import streamlit as st

    st.title("Onshape ShapeParser 🛠️")

    # Show the shape
    st.markdown("**Shape → ID mapping:**")
    st.write({
        "Cylinder":          0,
        "Box (Cube/Rectangular Prism)": 1,
        "Sphere":            2,
        "Cone":              3,
        "Pyramid":           4,
        "Torus":             5,
    })

    code = st.text_area(
        "Paste your FeatureScript/TypeScript here:",
        height=300,
        placeholder="// e.g. your Pyramid.fs or Torus.fs code…"
    )

    if st.button("Parse"):
        result = parse_shape(code)
        st.subheader("Detected Shape")
        st.write(result.shape or "None")
        st.subheader("Parameters")
        st.json(result.parameters)
        st.subheader("Feature Vector")
        st.json(result.feature_vector)
