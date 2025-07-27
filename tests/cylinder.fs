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
        features.FMt4KjVMh5OPw6D_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFMt4KjVMh5OPw6D_0 = { "rLbgwnvHUEr5" : [-0.031248332932591442, 0.032296933233737946, 1.0, 0.0, 0.050800000000000005, -1.0] };
                    {
                    }
                    var bOazMYbWvtAFNk_query;
                    bOazMYbWvtAFNk_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S3.7$TopplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 1" }
                    var sketch = newSketch(context, id + "FMt4KjVMh5OPw6D_0", { "sketchPlane" : qUnion([bOazMYbWvtAFNk_query]), "disableImprinting" : false });
                    skCircle(sketch, "rLbgwnvHUEr5", { "construction" : false, "index" : "1" });
                    {
                        skConstraint(sketch, "D8si3uaeZyL1", { "constraintType" : ConstraintType.DIAMETER, "index" : "1", "name" : "", "localFirst" : "rLbgwnvHUEr5", "length" : { 'value' : try(4 * inch), 'expression' : "4 in" }.value, "labelRatio" : 1.2845778499492682, "labelAngle" : 0.3054476769765361 * radian });
                    }
                    skSetInitialGuess(sketch, initialGuessFMt4KjVMh5OPw6D_0);
                    skSolve(sketch);
                }
            };
        try(features.FMt4KjVMh5OPw6D_0(id));
        features.FeC8K9Muec2cLgR_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var OILPiTFbqPvpph_query;
                    OILPiTFbqPvpph_query = qSketchRegion(id + "FMt4KjVMh5OPw6D_0", true);
                    annotation { "Feature Name" : "Extrude 1" }
                    extrude(context, id + "FeC8K9Muec2cLgR_0", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([OILPiTFbqPvpph_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * inch), 'expression' : "0 in" }.value, "thickness" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(3 * inch), 'expression' : "3 in" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(1 * inch), 'expression' : "1 in" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(1 * inch), 'expression' : "1 in" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(1 * inch), 'expression' : "1 in" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(1 * inch), 'expression' : "1 in" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]) });
                }
            };
        try(features.FeC8K9Muec2cLgR_0(id));
        return context;
    }, inch, {});
