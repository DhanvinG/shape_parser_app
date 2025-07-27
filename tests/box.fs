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
        features.FkuMQK96PcWIamj_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFkuMQK96PcWIamj_0 = { "6qS41xOew38A.bottom" : [0.007442081981897344, 0.04896584275960923, 1.0, 0.0, -0.050052102655172355, 0.051547897344827655], "6qS41xOew38A.top" : [0.007442081981897344, -0.05263415724039078, 1.0, 0.0, -0.05005210265517235, 0.05154789734482766], "6qS41xOew38A.left" : [-0.042610020673275004, -0.012314408086240292, 6.123233995736766E-17, -1.0, -0.061280250845849524, 0.040319749154150486], "6qS41xOew38A.right" : [0.058989979326725006, -0.012314408086240292, 0.0, -1.0, -0.061280250845849524, 0.040319749154150486] };
                    {
                    }
                    var TksSXXIiQbACmr_query;
                    TksSXXIiQbACmr_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S3.7$TopplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 1" }
                    var sketch = newSketch(context, id + "FkuMQK96PcWIamj_0", { "sketchPlane" : qUnion([TksSXXIiQbACmr_query]), "disableImprinting" : false });
                    skLineSegment(sketch, "6qS41xOew38A.bottom", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "6qS41xOew38A.top", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "6qS41xOew38A.left", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "6qS41xOew38A.right", { "construction" : false, "index" : "4" });
                    {
                        skConstraint(sketch, "6qS41xOew38A.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "6qS41xOew38A.top", "localSecond" : "6qS41xOew38A.left" });
                    }
                    {
                        skConstraint(sketch, "6qS41xOew38A.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "6qS41xOew38A.bottom", "localSecond" : "6qS41xOew38A.top" });
                    }
                    {
                        skConstraint(sketch, "6qS41xOew38A.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "6qS41xOew38A.left", "localSecond" : "6qS41xOew38A.right" });
                    }
                    {
                        skConstraint(sketch, "6qS41xOew38A.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "6qS41xOew38A.top" });
                    }
                    {
                        skConstraint(sketch, "6qS41xOew38A.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "6qS41xOew38A.bottom.start", "localSecond" : "6qS41xOew38A.left.start" });
                    }
                    {
                        skConstraint(sketch, "6qS41xOew38A.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "6qS41xOew38A.bottom.end", "localSecond" : "6qS41xOew38A.right.start" });
                    }
                    {
                        skConstraint(sketch, "6qS41xOew38A.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "6qS41xOew38A.top.start", "localSecond" : "6qS41xOew38A.left.end" });
                    }
                    {
                        skConstraint(sketch, "6qS41xOew38A.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "6qS41xOew38A.top.end", "localSecond" : "6qS41xOew38A.right.end" });
                    }
                    {
                        skConstraint(sketch, "TaHoIIYHejNK", { "constraintType" : ConstraintType.DISTANCE, "index" : "1", "name" : "", "localFirst" : "6qS41xOew38A.left", "localSecond" : "6qS41xOew38A.right", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(4 * inch), 'expression' : "4 in" }.value, "halfSpace0" : DimensionHalfSpace.LEFT, "halfSpace1" : DimensionHalfSpace.RIGHT, "labelRatio" : 0.5, "labelDistance" : 0.050647960695939964 * meter });
                    }
                    {
                        skConstraint(sketch, "AMZGF3Lqxkk4", { "constraintType" : ConstraintType.DISTANCE, "index" : "2", "name" : "", "localFirst" : "6qS41xOew38A.top", "localSecond" : "6qS41xOew38A.bottom", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(4 * inch), 'expression' : "4 in" }.value, "halfSpace0" : DimensionHalfSpace.LEFT, "halfSpace1" : DimensionHalfSpace.RIGHT, "labelRatio" : 0.5, "labelDistance" : -0.036499399403676115 * meter });
                    }
                    skSetInitialGuess(sketch, initialGuessFkuMQK96PcWIamj_0);
                    skSolve(sketch);
                }
            };
        try(features.FkuMQK96PcWIamj_0(id));
        features.F2pi0a891waaniO_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var MaPBKrHIiaxlGs_query;
                    MaPBKrHIiaxlGs_query = qSketchRegion(id + "FkuMQK96PcWIamj_0", true);
                    annotation { "Feature Name" : "Extrude 1" }
                    extrude(context, id + "F2pi0a891waaniO_0", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([MaPBKrHIiaxlGs_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * inch), 'expression' : "0 in" }.value, "thickness" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(4 * inch), 'expression' : "4 in" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(1 * inch), 'expression' : "1 in" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(1 * inch), 'expression' : "1 in" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(1 * inch), 'expression' : "1 in" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(1 * inch), 'expression' : "1 in" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]) });
                }
            };
        try(features.F2pi0a891waaniO_0(id));
        return context;
    }, inch, {});
