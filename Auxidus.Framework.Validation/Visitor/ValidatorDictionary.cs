using System;
using System.Collections.Generic;
using System.Text;

namespace Auxidus.Framework.Validation.Visitor
{
    public static class ValidatorDictionary
    {
        private static Dictionary<Type, object> _validators = new Dictionary<Type, object>();

        public static void RegisterValidatorFor<T>(IValidator<T> validator)
            where T : IValidatable<T>
        {
            _validators.Add(typeof(T), validator);
        }

        public static IValidator<T> GetValidatorFor<T>(T entity)
            where T : IValidatable<T>
        {
            return _validators[entity.GetType()] as IValidator<T>;
        }

        public static bool Validate<T>(this T entity, out IEnumerable<string> brokenRules)
            where T : IValidatable<T>
        {
            IValidator<T> validator = GetValidatorFor(entity);

            return entity.Validate(validator, out brokenRules);
        }
    }
}
