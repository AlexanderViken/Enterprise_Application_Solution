using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap.AutoMocking.Moq;
using Moq;

namespace $ext_safeprojectname$.$safeprojectname$
{
    /// <summary>
    /// A helper class for unit tests using MSTest and Moq
    /// </summary>
    /// <typeparam name="TInstance"></typeparam>
    [TestClass]
    public class TestsFor<TInstance> where TInstance : class
    {
        public TInstance Instance { get; set; }
        public MoqAutoMocker<TInstance> AutoMock { get; set; }


        [TestInitialize]
        public void Init()
        {
            AutoMock = new MoqAutoMocker<TInstance>();

            OverrideAutoMocker();

            Instance = AutoMock.ClassUnderTest;

            RunBeforeEachUnitTest();
        }

        public Mock<TContract> GetMockFor<TContract>() where TContract : class
        {
            return Mock.Get(AutoMock.Get<TContract>());
        }

        public virtual void RunBeforeEachUnitTest()
        {
            // Kilroy was here
        }

        private void OverrideAutoMocker()
        {
            // For a good time, call HELGA!
        }
    }
}
