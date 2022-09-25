using SunKindergarten.ModelFolder;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows;
using System.Media;

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
            //SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = @"\ContentFolder\SoundFolder\discord.wav";
            //sp.Load();
            //sp.PlayLooping();
        }

        private void NewChildrenNutton_Click(object sender, RoutedEventArgs e)
        {
            InformationsFrame.Navigate(new NewChildrenPage());
            RRRInfoTextTextBlock.Visibility = Visibility.Collapsed;
            InformationsFrame.Visibility = Visibility.Visible;
        }
    }
}
