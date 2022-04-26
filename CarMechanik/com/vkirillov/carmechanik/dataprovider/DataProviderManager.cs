using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMechanik.com.vkirillov.carmechanik.dataprovider
{
    public class DataProviderManager
    {
        private static IDataProvider DataProvider;

        public static IDataProvider GetDataProvider() {
            if (DataProvider != null) return DataProvider;
            return DataProvider = new MySQLDataProvider();
        }

    }
}
