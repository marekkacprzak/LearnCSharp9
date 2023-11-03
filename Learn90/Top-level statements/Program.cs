using Learn90.FitAndFinishFeatures;
using Learn90.InitOnlySetters;
using Learn90.PatternMatchingEnhancements;
using Learn90.PerformanceAndInterop;
using Learn90.Records;
using Learn90.SupportForCodeGenerators;
using Learn90.WarningWave5;

//1.TopLevelStatements:

//2.RecordExample
RercordExamlpe.Test();

//3.Init_only_setters
Init_only_setters.Test();

//4.PatternMatchingEnhancements
Typetest_patterns.M(1,"test");
Parenthesized_patterns.M(1,"test");
Relational_patterns.LifeStageAtAge(2);
// Conjunctive and patterns require both patterns to match
// Disjunctive or patterns require either pattern to match
// Negated not patterns require that a pattern doesn't match
Pattern_combinators.Test();

//5.PerformanceAndInterop
Native_sized_integers.Test();
SkipLocalsInit_attribute.Test();

//6.FitAndFinishFeatures
Target_typed_new_expressions.Test();
Static_anonymous_method.Test();
Covariant_return_types.Test();
Extension_GetEnumerator_support_for_foreach_loops.Test();
Lambda_discard_parameters.Test();
Attributes_on_local_functions.Test();

//7.SupportForCodeGenerators
NewFeaturesForPartialMethods.Test();
ModuleInitializers.Test();

//8.WarningWave5
WarningWave5.Test(3);