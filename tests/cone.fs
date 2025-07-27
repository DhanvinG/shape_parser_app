FeatureScript 2716;
import(path : "onshape/std/geometry.fs", version : "2716.0");

annotation { "Default Units" : ["cubicInch", "degree", "degreePerSecond", "footPoundForce", "inch", "inchPerSecondSquared", "inchPound", "pound", "poundForce", "poundPerSquareInch", "second", "squareInch"] }
export function main()
{
    return build({});
}

export function build()
{
    return buildPrivate({});
}

export function build(configuration is map)
{
    return buildPrivate(configuration);
}

const buildPrivate = definePartStudio(function(context is Context, configuration is map, lookup is function)
    precondition
    {
    }
    {
        const id is Id = newId();
        annotation { 'unused' : true }
        var features = {};
        features.F5mSq1V8toYGN21_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessF5mSq1V8toYGN21_0 = { "YlKtUZGzHDeZ" : [0.0, 0.0, 1.0, 0.0, 0.025400000000000002, -1.0] };
                    {
                    }
                    var kGQeFAMDlDubsD_query;
                    kGQeFAMDlDubsD_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S3.7$TopplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 1" }
                    var sketch = newSketch(context, id + "F5mSq1V8toYGN21_0", { "sketchPlane" : qUnion([kGQeFAMDlDubsD_query]), "disableImprinting" : false });
                    skCircle(sketch, "YlKtUZGzHDeZ", { "construction" : false, "index" : "1" });
                    {
                        var NRTfFnOYZBuJlE_query;
                        NRTfFnOYZBuJlE_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "YlKtUZGzHDeZ.centerSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "YlKtUZGzHDeZ.center", "externalSecond" : qUnion([NRTfFnOYZBuJlE_query]) });
                    }
                    {
                        skConstraint(sketch, "KChbJrzAXctj", { "constraintType" : ConstraintType.DIAMETER, "index" : "1", "name" : "", "localFirst" : "YlKtUZGzHDeZ", "length" : { 'value' : try(2 * inch), 'expression' : "2 in" }.value, "labelRatio" : 0.5187769381938567, "labelAngle" : 1.568002818947636 * radian });
                    }
                    skSetInitialGuess(sketch, initialGuessF5mSq1V8toYGN21_0);
                    skSolve(sketch);
                }
            };
        try(features.F5mSq1V8toYGN21_0(id));
        features.FOmykByIIJkK5ls_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var YeJuNtKRDgnDJJ_query;
                    YeJuNtKRDgnDJJ_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S3.7$TopplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Plane 1" }
                    cPlane(context, id + "FOmykByIIJkK5ls_0", { "entities" : qUnion([YeJuNtKRDgnDJJ_query]), "cplaneType" : CPlaneType.OFFSET, "offset" : { 'value' : try(2 * inch), 'expression' : "2 in" }.value, "angle" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "oppositeDirection" : false, "flipAlignment" : false, "flipNormal" : false, "width" : { 'value' : try(6 * inch), 'expression' : "6 in" }.value, "height" : { 'value' : try(6 * inch), 'expression' : "6 in" }.value });
                }
            };
        try(features.FOmykByIIJkK5ls_0(id));
        features.FwLK0SPxixcQLSx_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFwLK0SPxixcQLSx_0 = { "xjg1GfqQwwCN" : [0.0, 0.0] };
                    {
                    }
                    var bHIMOwWDoDIKIe_query;
                    bHIMOwWDoDIKIe_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.7$FOmykByIIJkK5ls_0planeOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 2" }
                    var sketch = newSketch(context, id + "FwLK0SPxixcQLSx_0", { "sketchPlane" : qUnion([bHIMOwWDoDIKIe_query]), "disableImprinting" : false });
                    skPoint(sketch, "xjg1GfqQwwCN", { "construction" : false, "index" : "1" });
                    {
                        var lQTakpIEkRvCgm_query;
                        lQTakpIEkRvCgm_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "xjg1GfqQwwCN.positionSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "xjg1GfqQwwCN", "externalSecond" : qUnion([lQTakpIEkRvCgm_query]) });
                    }
                    skSetInitialGuess(sketch, initialGuessFwLK0SPxixcQLSx_0);
                    skSolve(sketch);
                }
            };
        try(features.FwLK0SPxixcQLSx_0(id));
        features.Firrx1J8JwRNh1g_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var CLVpzIOHzRxtUd_query;
                    CLVpzIOHzRxtUd_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F5mSq1V8toYGN21_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$YlKtUZGzHDeZR5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    var fqPlMrhouZPYxv_query;
                    fqPlMrhouZPYxv_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FwLK0SPxixcQLSx_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$xjg1GfqQwwCN",id);
                    annotation { "Feature Name" : "Loft 1" }
                    loft(context, id + "Firrx1J8JwRNh1g_0", { "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([CLVpzIOHzRxtUd_query]) }, { "sheetProfileEntities" : qUnion([fqPlMrhouZPYxv_query]) }], "wireProfilesArray" : [], "midplane" : false, "thickness1" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * inch), 'expression' : "0 in" }.value, "thickness" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "startCondition" : LoftEndDerivativeType.DEFAULT, "adjacentFacesStart" : qUnion([]), "startMagnitude" : { 'value' : try(1), 'expression' : "1" }.value, "startDirection" : qUnion([]), "endCondition" : LoftEndDerivativeType.DEFAULT, "adjacentFacesEnd" : qUnion([]), "endMagnitude" : { 'value' : try(1), 'expression' : "1" }.value, "endDirection" : qUnion([]), "trimProfiles" : false, "addGuides" : false, "guidesArray" : [], "trimGuidesByProfiles" : true, "addSections" : false, "spine" : qUnion([]), "sectionCount" : { 'value' : try(roundWithinTolerance(5)), 'expression' : "5" }.value, "matchConnections" : false, "connections" : [], "makePeriodic" : false, "showIsocurves" : false, "curveCount" : { 'value' : try(roundWithinTolerance(10)), 'expression' : "10" }.value, "trimEnds" : true, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]) });
                }
            };
        try(features.Firrx1J8JwRNh1g_0(id));
        return context;
    }, inch, {});
