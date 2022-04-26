using CarMechanik.com.vkirillov.carmechanik.dataprovider;
using CarMechanik.com.vkirillov.carmechanik.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarMechanik.com.vkirillov.carmechanik.wpf
{
    public partial class ServiseWindow : Window
    {

        private IDataProvider provider = DataProviderManager.GetDataProvider();
        public IEnumerable<Servise> ServisesList { get
            {
                return provider.GetAllServises().Result;
            } }

        public ServiseWindow()
        {
            DataContext = this;
            InitializeComponent();
          

        }

    }
}
