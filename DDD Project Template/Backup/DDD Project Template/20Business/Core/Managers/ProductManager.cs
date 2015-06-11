using $ext_safeprojectname$.Domain.Contracts.Factories;
using $ext_safeprojectname$.Domain.Contracts.Handlers;
using $ext_safeprojectname$.Domain.Contracts.Managers;
using $ext_safeprojectname$.Domain.Contracts.Repositories;
using $ext_safeprojectname$.Domain.Contracts.Validators;
using $ext_safeprojectname$.Domain.Entities;

namespace $safeprojectname$.Managers
{
    public class ProductManager : IProductManager
    {
        private readonly IExceptionHandler _exceptionHandler;
        private readonly IProductValidator _productValidator;
        private readonly IProductRepository _productRepository;
        private readonly IProductFactory _productFactory;


        public ProductManager(
            IExceptionHandler exceptionHandler, 
            IProductValidator productValidator, 
            IProductRepository productRepository,
            IProductFactory productFactory)
        {
            _exceptionHandler = exceptionHandler;
            _productValidator = productValidator;
            _productRepository = productRepository;
            _productFactory = productFactory;
        }

        public Product Add(string name)
        {
            if (_productValidator.IsValidName(name) == false)
                return null;

            var product = _productFactory.Create(name);

            return _exceptionHandler.FromUnsafeFunction(() => 
                _productRepository.Create(product));
        }
    }
}
