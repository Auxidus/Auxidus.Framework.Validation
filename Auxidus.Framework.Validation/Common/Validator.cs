using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Auxidus.Framework.Validation.Common
{
    public static class Validator
    {
        public static void ThrowBrokenRules(IEnumerable<string> brokenRules, string message = null)
        {
            if (string.IsNullOrEmpty(message))
            {
                message = "Failed Validation";
            }
            List<Exception> validationExceptions = new List<Exception>();
            brokenRules.ToList().ForEach(e => validationExceptions.Add(new Exception(e)));

            if (validationExceptions.Any())
            {
                throw new AggregateException(message, validationExceptions);
            }
        }

    }
}
