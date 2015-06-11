using $safeprojectname$.Entities;

namespace $safeprojectname$.Contracts.Factories
{
    public interface IProductFactory
    {
        Product Create(string name);
    }
}
