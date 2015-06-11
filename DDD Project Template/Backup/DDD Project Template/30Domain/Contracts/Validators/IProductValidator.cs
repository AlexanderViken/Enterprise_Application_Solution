using $safeprojectname$.Entities;
namespace $safeprojectname$.Contracts.Validators
{
    public interface IProductValidator : IValidator<Product>
    {
        bool IsValidName(string name);
    }
}
