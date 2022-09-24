using SunKindergarten.ModelFolder;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SunKindergarten.ViewFolder.PageFolder
{
    public partial class EventPage : Page
    {
        public EventPage()
        {
            InitializeComponent();
            AppConnectModelClass.DataBase = new SunDataBaseEntities();
            ListEventListBox.ItemsSource = AppConnectModelClass.DataBase.EventTables.ToList();
        }

        private void NewEvent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListEventListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
