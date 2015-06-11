using Microsoft.VisualStudio.TestTools.UnitTesting;
using $ext_safeprojectname$.Business.Core.Managers;
using $ext_safeprojectname$.CrossCutting.TestHelpers;
using $ext_safeprojectname$.Domain.Contracts.Validators;
using Should;

namespace $safeprojectname$.Managers
{
    [TestClass]
    public class ProductManagerTests : TestsFor<ProductManager>
    {
        [TestMethod, TestCategory(ProductTestCategories.Validators)]
        public void Add_ProductNameIsInvalid_ResultIsNull()
        {
            // Arrange
            GetMockFor<IProductValidator>()
                .Setup(o => o.IsValidName(AnyKindOf.String)).Returns(false);

            // Act            
            var result = Instance.Add("coca-cola");
            
            // Assert   
            result.ShouldBeNull();
        }
    }
}
