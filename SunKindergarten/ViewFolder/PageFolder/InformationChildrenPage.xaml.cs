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
    /// <summary>
    /// Логика взаимодействия для InformationChildrenPage.xaml
    /// </summary>
    public partial class InformationChildrenPage : Page
    {
        ChildrenTable childrenTable = new ChildrenTable();
        public InformationChildrenPage(ChildrenTable childrenTable)
        {
            InitializeComponent();
            if (childrenTable != null)
            {
                childrenTable = childrenTable;
                DataContext = childrenTable;
            }
        }
    }
}
