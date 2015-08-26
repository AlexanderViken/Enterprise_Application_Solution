using $ext_safeprojectname$.$safeprojectname$.Entities;

namespace $ext_safeprojectname$.$safeprojectname$.Contracts.Factories
{
    public interface IProductFactory
    {
        Product Create(string name);
    }
}
