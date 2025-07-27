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
        features.F0WqS6EUsqpNaHi_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessF0WqS6EUsqpNaHi_0 = { "N9iR8CQ3Zyuj" : [0.03879815340042114, 0.05049918219447136, 1.0, 0.0, 0.012700000000000001, -1.0], "KpM6Z85duqAv" : [0.0, -3.815069794654846E-5, 0.0, -1.0, -0.07627388462424278, 0.07627388462424278] };
                    {
                    }
                    var ImXdzeQrckLEHs_query;
                    ImXdzeQrckLEHs_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S3.7$TopplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 1" }
                    var sketch = newSketch(context, id + "F0WqS6EUsqpNaHi_0", { "sketchPlane" : qUnion([ImXdzeQrckLEHs_query]), "disableImprinting" : false });
                    skCircle(sketch, "N9iR8CQ3Zyuj", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "KpM6Z85duqAv", { "construction" : false, "index" : "1" });
                    {
                        skConstraint(sketch, "0qO1S5B8PxH7", { "constraintType" : ConstraintType.DIAMETER, "index" : "1", "name" : "", "localFirst" : "N9iR8CQ3Zyuj", "length" : { 'value' : try(1 * inch), 'expression' : "1 in" }.value, "labelRatio" : 1.6122718481417173, "labelAngle" : -1.5707963267948966 * radian });
                    }
                    {
                        var IhsZWWPqFozDKo_query;
                        IhsZWWPqFozDKo_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S6.7$OriginpointOpS9$queryTypeS5$DUMMY",id);
                        skConstraint(sketch, "KpM6Z85duqAv.startSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "1", "name" : "", "localFirst" : "KpM6Z85duqAv.start", "externalSecond" : qUnion([IhsZWWPqFozDKo_query]) });
                    }
                    {
                        skConstraint(sketch, "KpM6Z85duqAv.endSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "2", "name" : "", "localFirst" : "KpM6Z85duqAv" });
                    }
                    skSetInitialGuess(sketch, initialGuessF0WqS6EUsqpNaHi_0);
                    skSolve(sketch);
                }
            };
        try(features.F0WqS6EUsqpNaHi_0(id));
        features.FsCEcf4KFdgqi3z_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var slgQCcYolaejpS_query;
                    slgQCcYolaejpS_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F0WqS6EUsqpNaHi_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$N9iR8CQ3ZyujR5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    var uOrpoJGznKBgnK_query;
                    uOrpoJGznKBgnK_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F0WqS6EUsqpNaHi_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$KpM6Z85duqAv",id);
                    annotation { "Feature Name" : "Revolve 1" }
                    revolve(context, id + "FsCEcf4KFdgqi3z_0", { "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "entities" : qUnion([slgQCcYolaejpS_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * inch), 'expression' : "0 in" }.value, "thickness" : { 'value' : try(0.25 * inch), 'expression' : "0.25 in" }.value, "axis" : qUnion([uOrpoJGznKBgnK_query]), "revolveType" : RevolveType.FULL, "oppositeDirection" : false, "angle" : { 'value' : try(30 * degree), 'expression' : "30 deg" }.value, "angleBack" : { 'value' : try(330 * degree), 'expression' : "330 deg" }.value, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]) });
                }
            };
        try(features.FsCEcf4KFdgqi3z_0(id));
        return context;
    }, inch, {});
