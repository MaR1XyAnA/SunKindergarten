using SunKindergarten.ModelFolder;
using System.Linq;
using System.Windows.Controls;
using System.Windows;
using System;

namespace SunKindergarten.ViewFolder.PageFolder
{
    public partial class GrouPage : Page
    {
        public GrouPage()
        {
            InitializeComponent();
            AppConnectModelClass.DataBase = new SunDataBaseEntities();
            ListGroupListBox.ItemsSource = AppConnectModelClass.DataBase.GroupTables.ToList();
        }

        private void ListGroupListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GroupTables groupTables = (GroupTables)ListGroupListBox.SelectedItem;
            InformationsFrame.Navigate(new InformationGroupPage(groupTables));
            RRRInfoTextTextBlock.Visibility = Visibility.Collapsed;
            InformationsFrame.Visibility = Visibility.Visible;
        }

        private void NewGroup_Click(object sender, RoutedEventArgs e)
        {
            InformationsFrame.Navigate(new NewGroupPage());
            InformationsFrame.Visibility = Visibility.Visible;
            RRRInfoTextTextBlock.Visibility = Visibility.Collapsed;
        }
    }
}
