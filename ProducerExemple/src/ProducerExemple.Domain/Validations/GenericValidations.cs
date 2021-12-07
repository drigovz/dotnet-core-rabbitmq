using FluentValidation;

namespace ProducerExemple.Domain.Validations
{
    public static class GenericValidations
    {
        public static IRuleBuilderOptions<T, string> Title<T>(this IRuleBuilder<T, string> ruleBuilder) =>
            ruleBuilder.NotNull().NotEmpty().WithMessage("Title is required!");

        public static IRuleBuilderOptions<T, string> Subtitle<T>(this IRuleBuilder<T, string> ruleBuilder) =>
            ruleBuilder.NotNull().NotEmpty().WithMessage("Subtitle is required!");

        public static IRuleBuilderOptions<T, string> Year<T>(this IRuleBuilder<T, string> ruleBuilder) =>
            ruleBuilder.NotNull().NotEmpty().WithMessage("Year is required!");
    }
}
