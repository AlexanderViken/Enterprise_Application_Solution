using $ext_safeprojectname$.$safeprojectname$.Entities;
namespace $ext_safeprojectname$.$safeprojectname$.Contracts.Validators
{
    public interface IProductValidator : IValidator<Product>
    {
        bool IsValidName(string name);
    }
}
