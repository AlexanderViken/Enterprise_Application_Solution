using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $ext_safeprojectname$.$safeprojectname$.Contracts.Validators
{
    public interface IValidator<T>
    {
        bool IsValid(T entity);
    }
}
