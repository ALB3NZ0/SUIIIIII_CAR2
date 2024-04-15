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

namespace CAR_BD2
{
    /// <summary>
    /// Логика взаимодействия для FULLINFO.xaml
    /// </summary>
    public partial class FULLINFO : Page
    {


        private SELLS_CAREntities fullInfo = new SELLS_CAREntities();


        public FULLINFO()
        {
            InitializeComponent();

            avto.ItemsSource = fullInfo.GLOBAL_INFO.ToList();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }




        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            avto.Columns[9].Visibility = Visibility.Collapsed;
            avto.Columns[10].Visibility = Visibility.Collapsed;
            avto.Columns[11].Visibility = Visibility.Collapsed;
            avto.Columns[12].Visibility = Visibility.Collapsed;
            avto.Columns[13].Visibility = Visibility.Collapsed;
            avto.Columns[14].Visibility = Visibility.Collapsed;
            avto.Columns[8].Visibility = Visibility.Collapsed;        
        }
    }
}
