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
        features.F5vzybluUuH1gDO_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessF5vzybluUuH1gDO_0 = { "h3JTDtVXuAJQ" : [0.0, 0.025253737345337868, 0.0, -1.0, -1.462626546621347E-4, 0.025253737345337868], "SeU6I3mrEHj6" : [3.0357660829594124E-18, 0.012700000000000003, 1.0, 0.0, 0.0127, -1.0, -4.71238898038469, -1.5707963267948968] };
                    {
                    }
                    var xSNGIlITbwwLci_query;
                    xSNGIlITbwwLci_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S3.7$TopplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 1" }
                    var sketch = newSketch(context, id + "F5vzybluUuH1gDO_0", { "sketchPlane" : qUnion([xSNGIlITbwwLci_query]), "disableImprinting" : false });
                    skLineSegment(sketch, "h3JTDtVXuAJQ", { "construction" : false, "index" : "1" });
                    skArc(sketch, "SeU6I3mrEHj6", { "construction" : false, "index" : "1" });
                    {
                        var shypHRCwKvYSfO_query;
                        shypHRCwKvYSfO_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "h3JTDtVXuAJQ.startSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "1", "name" : "", "localFirst" : "h3JTDtVXuAJQ.start", "externalSecond" : qUnion([shypHRCwKvYSfO_query]) });
                    }
                    {
                        var kNrHSgqDrmIeKz_query;
                        kNrHSgqDrmIeKz_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "h3JTDtVXuAJQ.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "h3JTDtVXuAJQ.end", "externalSecond" : qUnion([kNrHSgqDrmIeKz_query]) });
                    }
                    {
                        skConstraint(sketch, "pSj3DcCBi7I0", { "constraintType" : ConstraintType.LENGTH, "index" : "1", "name" : "", "localFirst" : "h3JTDtVXuAJQ", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(1 * inch), 'expression' : "1 in" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 0.5, "labelDistance" : -0.015075667441710624 * meter });
                    }
                    {
                        skConstraint(sketch, "SeU6I3mrEHj6.mid1", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localMidpoint" : "SeU6I3mrEHj6.center", "localEntity1" : "SeU6I3mrEHj6.start", "localEntity2" : "SeU6I3mrEHj6.end" });
                    }
                    {
                        skConstraint(sketch, "SeU6I3mrEHj6.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "SeU6I3mrEHj6.start", "localSecond" : "h3JTDtVXuAJQ.start" });
                    }
                    {
                        skConstraint(sketch, "SeU6I3mrEHj6.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "SeU6I3mrEHj6.end", "localSecond" : "h3JTDtVXuAJQ.end" });
                    }
                    skSetInitialGuess(sketch, initialGuessF5vzybluUuH1gDO_0);
                    skSolve(sketch);
                }
            };
        try(features.F5vzybluUuH1gDO_0(id));
        features.Fs9HrR9eIPW6cMl_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var RlnoVnFkqtWuUM_query;
                    RlnoVnFkqtWuUM_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA2A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F5vzybluUuH1gDO_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$h3JTDtVXuAJQR5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD-1A2C0M5R4C0M5R5R6R7R8R9RbRcRdReSc$SeU6I3mrEHj6R5R6R7R8R9R12RcR13D1R5C7S4$FACER7R8R9R12RcR13",id);
                    var HMnBeahcWQaMkO_query;
                    HMnBeahcWQaMkO_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F5vzybluUuH1gDO_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$h3JTDtVXuAJQ",id);
                    var wqHwDOairtEkCm_query;
                    wqHwDOairtEkCm_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F5vzybluUuH1gDO_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$h3JTDtVXuAJQ",id);
                    annotation { "Feature Name" : "Revolve 1" }
                    revolve(context, id + "Fs9HrR9eIPW6cMl_0", { "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "entities" : qUnion([RlnoVnFkqtWuUM_query]), "surfaceEntities" : qUnion([HMnBeahcWQaMkO_query]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * inch), 'expression' : "0 in" }.value, "thickness" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "axis" : qUnion([wqHwDOairtEkCm_query]), "revolveType" : RevolveType.FULL, "oppositeDirection" : false, "angle" : { 'value' : try(30 * degree), 'expression' : "30 deg" }.value, "angleBack" : { 'value' : try(330 * degree), 'expression' : "330 deg" }.value, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]) });
                }
            };
        try(features.Fs9HrR9eIPW6cMl_0(id));
        return context;
    }, inch, {});
