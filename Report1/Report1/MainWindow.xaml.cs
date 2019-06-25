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

namespace Report1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdConfirm_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cmdGetEmployee_Click(object sender, RoutedEventArgs e)
        {
            long id;
            if(Int64.TryParse(txtID.Text, out id))
            {
                try
                {
                    gridEmployeeDetails.DataContext = HrDAC.Instance.GetEmployee(id);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error contacting database");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }
    }
}
