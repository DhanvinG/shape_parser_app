import streamlit as st
from shape_parser import parse_shape

st.title("🔍 FeatureScript Shape Parser")

st.markdown(
    """
    Paste your Onshape FeatureScript (TypeScript-like) code below and click **Parse** to extract shape information.
    """
)

code_input = st.text_area("FeatureScript Code", height=300)

if st.button("Parse"):
    if not code_input.strip():
        st.warning("Please paste some FeatureScript code first.")
    else:
        result = parse_shape(code_input)
        st.subheader("Detected Shape")
        st.write(result.shape or "None")
        
        st.subheader("Parameters")
        if result.parameters:
            st.json(result.parameters)
        else:
            st.write("No parameters detected.")
        
        st.subheader("Feature Vector")
        if result.feature_vector is not None:
            st.write(result.feature_vector)
        else:
            st.write("No feature vector generated.")
        
        st.subheader("Evidence & Notes")
        for ev in result.evidence:
            st.write(f"- {ev}")

