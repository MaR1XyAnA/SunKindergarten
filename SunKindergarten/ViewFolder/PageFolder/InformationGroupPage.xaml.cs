using SunKindergarten.ModelFolder;
using System.Windows;
using System.Windows.Controls;

namespace SunKindergarten.ViewFolder.PageFolder
{
    public partial class InformationGroupPage : Page
    {
        GroupTables groupTables = new GroupTables();
        public InformationGroupPage(GroupTables groupTables)
        {
            InitializeComponent();
            if (groupTables != null)
            {
                groupTables = groupTables;
                DataContext = groupTables;
            }
        }

        private void EditInformationsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelEditInformationsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
