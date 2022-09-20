using SunKindergarten.ModelFolder;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows;

namespace SunKindergarten.ViewFolder.PageFolder
{
    public partial class ChildrenPage : Page
    {
        public ChildrenPage()
        {
            InitializeComponent();
            AppConnectModelClass.DataBase = new SunDataBaseEntities();
            ListChildrenListBox.ItemsSource = AppConnectModelClass.DataBase.ChildrenTable.ToList();
            ListChildrenListBox.Items.SortDescriptions.Add(new SortDescription("SurnamesChildren", ListSortDirection.Ascending));
        }

        private void ListChildrenListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChildrenTable childrenTable = (ChildrenTable)ListChildrenListBox.SelectedItem;
            InformationsFrame.Navigate(new InformationChildrenPage(childrenTable));
            RRRInfoTextTextBlock.Visibility = Visibility.Collapsed;
            InformationsFrame.Visibility = Visibility.Visible;
        }
    }
}
