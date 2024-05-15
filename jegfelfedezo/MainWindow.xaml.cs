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

namespace jegfelfedezo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            creategrid();
        }

        int magassag = 20;
        int szelesseg = 20;
        private void creategrid()
        {
            
            for (int magass = 0; magass < magassag; magass++)
            {
                grdJeg.RowDefinitions.Add(new RowDefinition());
            }

            for (int szeles = 0; szeles < szelesseg; szeles++)
            {
                grdJeg.ColumnDefinitions.Add(new ColumnDefinition());
            }

            grdJeg.ShowGridLines = true;
            //gridetFeltolt();
        }
        private void babugeneralas()
        {
            int babuindex = 0;
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int y = rand.Next(1, magassag+1);
                int x = rand.Next(1, szelesseg + 1);
            } 
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
