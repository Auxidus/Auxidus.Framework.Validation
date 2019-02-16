using System;
using System.Collections.Generic;
using System.Text;

namespace Auxidus.Framework.Validation.Visitor
{
    public interface IValidator<T>
    {
        bool IsValid(T entity);
        IEnumerable<string> BrokenRules(T entity);
    }    
}
