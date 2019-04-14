using System;
using System.Collections.Generic;
using System.Text;

namespace Auxidus.Framework.Validation.Visitor
{
    public interface IValidatable<T>
    {
        bool Validate(IValidator<T> validator, out IEnumerable<string> brokenRules);
    }

    public interface IValidatable
    {
        bool Validate<T>(IValidator<T> validator, out IEnumerable<string> brokenRules);
    }
}
