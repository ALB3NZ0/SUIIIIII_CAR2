using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для GlobaLInfo.xaml
    /// </summary>
    public partial class GlobaLInfo : Page
    {

        private int suiCARNAMEId;
        private int suiWHERE_THE_CAR_COMES_FROMId;
        private int suiSUPPLIERId;

        private SELLS_CAREntities globalInfo = new SELLS_CAREntities();

        public GlobaLInfo()
        {
            InitializeComponent();
            avto.ItemsSource = globalInfo.GLOBAL_INFO.ToList();
            CAR_IDComboBox.ItemsSource = globalInfo.CAR.ToList();
            CAR_IDComboBox.DisplayMemberPath = "ID_CARNAME";
            WHERE_IDComboBox.ItemsSource = globalInfo.WHERE_THE_CAR_COMES_FROM.ToList();
            WHERE_IDComboBox.DisplayMemberPath = "ID_WHERE_THE_CAR_COMES_FROM";
            SUPPLIER_IDComboBox.ItemsSource = globalInfo.SUPPLIER.ToList();
            SUPPLIER_IDComboBox.DisplayMemberPath = "ID_SUPPLIER";


        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            avto.Columns[4].Visibility = Visibility.Collapsed;
            avto.Columns[5].Visibility = Visibility.Collapsed;
            avto.Columns[6].Visibility = Visibility.Collapsed;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void AddID_Click(object sender, RoutedEventArgs e)
        {
            GLOBAL_INFO gl = new GLOBAL_INFO();
            gl.CARNAME_ID = int.Parse(CAR_IDComboBox.Text);
            gl.SUPPLIER_ID = int.Parse(SUPPLIER_IDComboBox.Text);
            gl.WHERE_THE_CAR_COMES_FROM_ID = int.Parse(WHERE_IDComboBox.Text);
            globalInfo.GLOBAL_INFO.Add(gl);
            globalInfo.SaveChanges();
            avto.ItemsSource = globalInfo.GLOBAL_INFO.ToList();
        }

        private void DeleteIDr_Click(object sender, RoutedEventArgs e)
        {
            if (avto.SelectedItem != null)
            {
                globalInfo.GLOBAL_INFO.Remove(avto.SelectedItem as GLOBAL_INFO);
            }
            globalInfo.SaveChanges();
            avto.ItemsSource = globalInfo.GLOBAL_INFO.ToList();
        }

        private void UpdateID_Click(object sender, RoutedEventArgs e)
        {
            GLOBAL_INFO gl = avto.SelectedItem as GLOBAL_INFO;
            CAR cAR = CAR_IDComboBox.SelectedItem as CAR;
            SUPPLIER suP = SUPPLIER_IDComboBox.SelectedItem as SUPPLIER;
            WHERE_THE_CAR_COMES_FROM whereTccf = WHERE_IDComboBox.SelectedItem as WHERE_THE_CAR_COMES_FROM;

            if (gl != null && cAR != null && suP != null && whereTccf != null)
            {
                gl.CARNAME_ID = cAR.ID_CARNAME;
                gl.SUPPLIER_ID = suP.ID_SUPPLIER;
                gl.WHERE_THE_CAR_COMES_FROM_ID = whereTccf.ID_WHERE_THE_CAR_COMES_FROM;

                globalInfo.SaveChanges();
                avto.ItemsSource = globalInfo.GLOBAL_INFO.ToList();
            }
        }

        private void CAR_IDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CAR_IDComboBox.SelectedItem != null)
            {
                var select = CAR_IDComboBox.SelectedItem as CAR;
            }
        }

        private void WHERE_IDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WHERE_IDComboBox.SelectedItem != null)
            {
                var select = WHERE_IDComboBox.SelectedItem as WHERE_THE_CAR_COMES_FROM;
            }
        }

        private void SUPPLIER_IDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SUPPLIER_IDComboBox.SelectedItem != null)
            {
                var select = SUPPLIER_IDComboBox.SelectedItem as SUPPLIER;

            }
        }

        private void avto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (avto.SelectedItem != null)
            {
                var select = avto.SelectedItem as GLOBAL_INFO;

                suiCARNAMEId = select.CARNAME_ID;
                suiSUPPLIERId = select.SUPPLIER_ID;
                suiWHERE_THE_CAR_COMES_FROMId = select.WHERE_THE_CAR_COMES_FROM_ID;

                CAR_IDComboBox.SelectedItem = globalInfo.CAR.FirstOrDefault(n => n.ID_CARNAME == suiCARNAMEId);
                SUPPLIER_IDComboBox.SelectedItem = globalInfo.SUPPLIER.FirstOrDefault(c => c.ID_SUPPLIER == suiSUPPLIERId);
                WHERE_IDComboBox.SelectedItem = globalInfo.WHERE_THE_CAR_COMES_FROM.FirstOrDefault(o => o.ID_WHERE_THE_CAR_COMES_FROM == suiWHERE_THE_CAR_COMES_FROMId);
            }
        }
    }
}
