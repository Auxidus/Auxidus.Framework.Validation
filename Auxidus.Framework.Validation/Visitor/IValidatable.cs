using System;
using System.Collections.Generic;
using System.Text;

namespace Auxidus.Framework.Validation.Visitor
{
    public interface IValidatable<T>
    {
        bool Validate(IValidator<T> validator, out IEnumerable<string> brokenRules);
    }
}
