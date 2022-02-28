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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //PSControl?.INIT();

            int.TryParse(tbSectorsCount.Text, out int countSectors);
            if (countSectors < 0)
                countSectors = 0;
            PSControl?.SetCountSectors(countSectors);

            int.TryParse(tbAerialsCount.Text, out int countAerial);
            if (countAerial < 0)
                countAerial = 0;
            PSControl?.SetCountAerial(countAerial);
        }

        private void tbSectorsCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(tbSectorsCount.Text, out int countSectors);
            if (countSectors < 0)
                countSectors = 0;
            PSControl?.SetCountSectors(countSectors);
           
        }
        private void sliderRotatingCar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PSControl?.SetCarAngle(e.NewValue);
        }
       
        private void tbAerialsCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(tbAerialsCount.Text, out int countAerial);
            if (countAerial < 0)
                countAerial = 0;
            PSControl?.SetCountAerial(countAerial);
        }
    }
}
