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
            ListChildrenListBox.ItemsSource = AppConnectModelClass.DataBase.ResultTable.ToList();
            ListChildrenListBox.Items.SortDescriptions.Add
                (new SortDescription("ChildrenTable.SurnamesChildren", ListSortDirection.Ascending));
        }

        private void ListChildrenListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResultTable resultTable = (ResultTable)ListChildrenListBox.SelectedItem;
            InformationsFrame.Navigate(new InformationChildrenPage(resultTable));
            RRRInfoTextTextBlock.Visibility = Visibility.Collapsed;
            InformationsFrame.Visibility = Visibility.Visible;
        }
    }
}
