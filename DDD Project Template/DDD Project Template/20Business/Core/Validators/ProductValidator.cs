using $ext_safeprojectname$.Domain.Contracts.Validators;
using $ext_safeprojectname$.Domain.Entities;

namespace $ext_safeprojectname$.$safeprojectname$.Validators
{
    public class ProductValidator :IProductValidator
    {
        public bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name)) return false;

            return true;
        }

        public bool IsValid(Product entity)
        {
            if (entity == null) return false;
            if (entity.Price != null && !IsValidName(entity.Name)) return false;

            return true;
        }
    }
}
