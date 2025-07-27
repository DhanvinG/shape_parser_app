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
        features.FvCsQlXpMEbOGIR_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFvCsQlXpMEbOGIR_0 = { "0upCGxbbC89f.bottom" : [-0.0042197167217731535, 0.025400000000000006, -1.0, 0.0, -0.029619716721773156, 0.02118028327822685], "0upCGxbbC89f.top" : [0.0, -0.0254, -1.0, 0.0, -0.0254, 0.025400000000000006], "0upCGxbbC89f.left" : [0.0254, -0.012637523309886458, -6.123233995736766E-17, -1.0, -0.03803752330988647, 0.012762476690113541], "0upCGxbbC89f.right" : [-0.025400000000000006, -0.012637523309886455, -6.123233995736766E-17, -1.0, -0.03803752330988646, 0.012762476690113544], "0upCGxbbC89f.middle" : [0.0, 0.0] };
                    {
                    }
                    var yLiDcZLykDzoMS_query;
                    yLiDcZLykDzoMS_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S3.7$TopplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 1" }
                    var sketch = newSketch(context, id + "FvCsQlXpMEbOGIR_0", { "sketchPlane" : qUnion([yLiDcZLykDzoMS_query]), "disableImprinting" : false });
                    skLineSegment(sketch, "0upCGxbbC89f.bottom", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "0upCGxbbC89f.top", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "0upCGxbbC89f.left", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "0upCGxbbC89f.right", { "construction" : false, "index" : "4" });
                    skPoint(sketch, "0upCGxbbC89f.middle", { "construction" : true, "index" : "1" });
                    {
                        skConstraint(sketch, "0upCGxbbC89f.mid1", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localMidpoint" : "0upCGxbbC89f.middle", "localEntity1" : "0upCGxbbC89f.top.start", "localEntity2" : "0upCGxbbC89f.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "0upCGxbbC89f.mid2", { "constraintType" : ConstraintType.MIDPOINT, "index" : "2", "name" : "", "localMidpoint" : "0upCGxbbC89f.middle", "localEntity1" : "0upCGxbbC89f.top.end", "localEntity2" : "0upCGxbbC89f.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "0upCGxbbC89f.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "0upCGxbbC89f.top", "localSecond" : "0upCGxbbC89f.left" });
                    }
                    {
                        skConstraint(sketch, "0upCGxbbC89f.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "0upCGxbbC89f.bottom", "localSecond" : "0upCGxbbC89f.top" });
                    }
                    {
                        skConstraint(sketch, "0upCGxbbC89f.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "0upCGxbbC89f.left", "localSecond" : "0upCGxbbC89f.right" });
                    }
                    {
                        skConstraint(sketch, "0upCGxbbC89f.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "0upCGxbbC89f.top" });
                    }
                    {
                        skConstraint(sketch, "0upCGxbbC89f.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "0upCGxbbC89f.bottom.start", "localSecond" : "0upCGxbbC89f.left.start" });
                    }
                    {
                        skConstraint(sketch, "0upCGxbbC89f.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "0upCGxbbC89f.bottom.end", "localSecond" : "0upCGxbbC89f.right.start" });
                    }
                    {
                        skConstraint(sketch, "0upCGxbbC89f.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "0upCGxbbC89f.top.start", "localSecond" : "0upCGxbbC89f.left.end" });
                    }
                    {
                        skConstraint(sketch, "0upCGxbbC89f.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "0upCGxbbC89f.top.end", "localSecond" : "0upCGxbbC89f.right.end" });
                    }
                    {
                        var oxLgtloZcCmAaI_query;
                        oxLgtloZcCmAaI_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "0upCGxbbC89f.middle.positionSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "name" : "", "localFirst" : "0upCGxbbC89f.middle", "externalSecond" : qUnion([oxLgtloZcCmAaI_query]) });
                    }
                    {
                        skConstraint(sketch, "4wH7lQLCGZw9", { "constraintType" : ConstraintType.DISTANCE, "index" : "1", "name" : "", "localFirst" : "0upCGxbbC89f.left", "localSecond" : "0upCGxbbC89f.right", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(2 * inch), 'expression' : "2 in" }.value, "halfSpace0" : DimensionHalfSpace.RIGHT, "halfSpace1" : DimensionHalfSpace.LEFT, "labelRatio" : 0.5, "labelDistance" : -0.019822571230832753 * meter });
                    }
                    {
                        skConstraint(sketch, "Fu7Ic2VxSBU0", { "constraintType" : ConstraintType.DISTANCE, "index" : "2", "name" : "", "localFirst" : "0upCGxbbC89f.top", "localSecond" : "0upCGxbbC89f.bottom", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(2 * inch), 'expression' : "2 in" }.value, "halfSpace0" : DimensionHalfSpace.RIGHT, "halfSpace1" : DimensionHalfSpace.LEFT, "labelRatio" : 0.5000000000000001, "labelDistance" : -0.035311286566778885 * meter });
                    }
                    skSetInitialGuess(sketch, initialGuessFvCsQlXpMEbOGIR_0);
                    skSolve(sketch);
                }
            };
        try(features.FvCsQlXpMEbOGIR_0(id));
        features.Fbq4i2gljd6bq2W_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var nGWrOouKQUSlBP_query;
                    nGWrOouKQUSlBP_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S3.7$TopplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Plane 1" }
                    cPlane(context, id + "Fbq4i2gljd6bq2W_0", { "entities" : qUnion([nGWrOouKQUSlBP_query]), "cplaneType" : CPlaneType.OFFSET, "offset" : { 'value' : try(2 * inch), 'expression' : "2 in" }.value, "angle" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "oppositeDirection" : false, "flipAlignment" : false, "flipNormal" : false, "width" : { 'value' : try(6 * inch), 'expression' : "6 in" }.value, "height" : { 'value' : try(6 * inch), 'expression' : "6 in" }.value });
                }
            };
        try(features.Fbq4i2gljd6bq2W_0(id));
        features.FEQgs2DlgA8tN0Z_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFEQgs2DlgA8tN0Z_0 = { "7i8xg5tMwgrm" : [0.0, 0.0] };
                    {
                    }
                    var IZYRKjkdoOHTpp_query;
                    IZYRKjkdoOHTpp_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.7$Fbq4i2gljd6bq2W_0planeOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 2" }
                    var sketch = newSketch(context, id + "FEQgs2DlgA8tN0Z_0", { "sketchPlane" : qUnion([IZYRKjkdoOHTpp_query]), "disableImprinting" : false });
                    skPoint(sketch, "7i8xg5tMwgrm", { "construction" : false, "index" : "1" });
                    {
                        var orPxpTkPznPHpT_query;
                        orPxpTkPznPHpT_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "7i8xg5tMwgrm.positionSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "7i8xg5tMwgrm", "externalSecond" : qUnion([orPxpTkPznPHpT_query]) });
                    }
                    skSetInitialGuess(sketch, initialGuessFEQgs2DlgA8tN0Z_0);
                    skSolve(sketch);
                }
            };
        try(features.FEQgs2DlgA8tN0Z_0(id));
        features.FlTMDItrWDCjEep_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var ZWeYUQSiIqnfWy_query;
                    ZWeYUQSiIqnfWy_query=qCompressed(1.0,"&217$eJyNkMFygjAQhl9me9QxCKJHDJFmWkQTDvXkAImaqQgN0Za3b4SO0449eMkk++X7N5unuQfrs9Rt7HHkgFBNVuZqf86Mqk5hZrIAxc49Sdta8imkySp5TaKN3cqTUUbJJnADB49sWg5CanWRYqGrsqtk/aX2Ks8zILcDd4GEEbHKQTWm0u1PPGYkSGmytKCqpe46UzF3gIoAcYSGE1hccLM+vtUxyZOIsu3oU2mZ1HwGH9epuiAB/IWk+HlLlilNN1xC8y5NcegfQAUvbNDoXOPoK8/xdLbLK2Oqknlswnw2ZTNc2HYDMfRBlbVWJ8MK7gONV4wu0xD1AzO3W28Sy1nBBJN8gMbDMZiq/sWQYyEah4NHZBeOcmfubYayB2wPtNof/tWtgn37+YsAk7/sG1WGpmE=",id);
                    var CMBgWvlrUfqmMM_query;
                    CMBgWvlrUfqmMM_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FEQgs2DlgA8tN0Z_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$7i8xg5tMwgrm",id);
                    annotation { "Feature Name" : "Loft 1" }
                    loft(context, id + "FlTMDItrWDCjEep_0", { "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([ZWeYUQSiIqnfWy_query]) }, { "sheetProfileEntities" : qUnion([CMBgWvlrUfqmMM_query]) }], "wireProfilesArray" : [], "midplane" : false, "thickness1" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * inch), 'expression' : "0 in" }.value, "thickness" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "startCondition" : LoftEndDerivativeType.DEFAULT, "adjacentFacesStart" : qUnion([]), "startMagnitude" : { 'value' : try(1), 'expression' : "1" }.value, "startDirection" : qUnion([]), "endCondition" : LoftEndDerivativeType.DEFAULT, "adjacentFacesEnd" : qUnion([]), "endMagnitude" : { 'value' : try(1), 'expression' : "1" }.value, "endDirection" : qUnion([]), "trimProfiles" : false, "addGuides" : false, "guidesArray" : [], "trimGuidesByProfiles" : true, "addSections" : false, "spine" : qUnion([]), "sectionCount" : { 'value' : try(roundWithinTolerance(5)), 'expression' : "5" }.value, "matchConnections" : false, "connections" : [], "makePeriodic" : false, "showIsocurves" : false, "curveCount" : { 'value' : try(roundWithinTolerance(10)), 'expression' : "10" }.value, "trimEnds" : true, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]) });
                }
            };
        try(features.FlTMDItrWDCjEep_0(id));
        return context;
    }, inch, {});
