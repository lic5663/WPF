using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Report2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Employee> employees;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdGetEmployees_Click(object sender, RoutedEventArgs e)
        {
            employees = HrDAC.Instance.GetEmployees();
            lstEmployees.ItemsSource = employees;

        }


        private static void Sort(string PropertyName, ListSortDirection Direction, object ItemsSource)
        {
            // ItemsSource의 Default 뷰 가져오기
            ICollectionView CollectionView = CollectionViewSource.GetDefaultView(ItemsSource);

            // 기존에 등록되어 있던 SortDescriptions제거
            CollectionView.SortDescriptions.Clear();

            // SortDescription 추가
            SortDescription SortDescription = new SortDescription(PropertyName, Direction);
            CollectionView.SortDescriptions.Add(SortDescription);

            // 뷰 갱신
            CollectionView.Refresh();
        }

        private void cmdSortEmployees_Click(object sender, RoutedEventArgs e)
        {
            Sort("Employee_id", 0, employees);
        }
    }
}
