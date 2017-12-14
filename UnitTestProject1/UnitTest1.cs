using DomainBusiness;
using Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async System.Threading.Tasks.Task TestMethod1Async()
        {
            Estrutura estrutura = new Estrutura { };
            Propiedades propiedades = new Propiedades { };

            await PropiedadesBO.SaveAsync(propiedades, "aaaaaa");

        }
    }
}
