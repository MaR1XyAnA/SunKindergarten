using SunKindergarten.ModelFolder;
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

namespace SunKindergarten.ViewFolder.PageFolder
{
    public partial class NewChildrenPage : Page
    {
        public NewChildrenPage()
        {
            InitializeComponent();
            NameGroupCombaBox.ItemsSource = AppConnectModelClass.DataBase.GroupTables.ToList();
            NameEventCombaBox.ItemsSource = AppConnectModelClass.DataBase.EventTables.ToList();
            
        }

        private void NewChildrenButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
