using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarMechanik.com.vkirillov.carmechanik.dataprovider;
using CarMechanik.com.vkirillov.carmechanik.obj;

namespace CarMechanikTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DataProvider_Login_Test()
        {
            IDataProvider dataProvider = DataProviderManager.GetDataProvider();

            Staff staff = dataProvider.Login("Qwerty", "142536").Result;
            Assert.IsNotNull(staff);
            

        }
    }
}
