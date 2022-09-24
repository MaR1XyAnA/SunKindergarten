using SunKindergarten.ModelFolder;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SunKindergarten.ViewFolder.PageFolder
{
    public partial class InformationChildrenPage : Page
    {
        ResultTable resultTable = new ResultTable();
        public InformationChildrenPage(ResultTable resultTable)
        {
            InitializeComponent();
            AppConnectModelClass.DataBase = new SunDataBaseEntities();
            GroupChildrenCombaBox.ItemsSource = AppConnectModelClass.DataBase.GroupTables.ToList();
            EventChildrenCombaBox.ItemsSource = AppConnectModelClass.DataBase.EventTables.ToList();
            FocusEventChildrenCombaBox.ItemsSource = AppConnectModelClass.DataBase.EventTables.ToList();
            EvaluationChildrenCombaBox.ItemsSource = AppConnectModelClass.DataBase.EvaluationTables.ToList();
            if (resultTable != null)
            {
                resultTable = resultTable;
                DataContext = resultTable;
            }
        }

        private void EditInformationsButton_Click(object sender, RoutedEventArgs e)
        {
            string
                PersonalNumberChildren,
                SurnamesChildren,
                NameChildren,
                MiddlenameChildren,
                GroupChildren,
                EventChildren,
                FocusEventChildren,
                EvaluationChildren,
                DataEventChildren;

            PersonalNumberChildren = Convert.ToString(PersonalNumberChildrenTextBlock.Text);
            SurnamesChildren = Convert.ToString(SurnamesChildrenTextBlock.Text);
            NameChildren = Convert.ToString(NameChildrenTextBlock.Text);
            MiddlenameChildren = Convert.ToString(MiddlenameChildrenTextBlock.Text);
            GroupChildren = Convert.ToString(GroupChildrenTextBlock.Text);
            EventChildren = Convert.ToString(EventChildrenTextBlock.Text);
            FocusEventChildren = Convert.ToString(FocusEventChildrenTextBlock.Text);
            EvaluationChildren = Convert.ToString(EvaluationChildrenTextBlock.Text);
            DataEventChildren = Convert.ToString(DataEventChildrenTextBlock.Text);

            PersonalNumberChildrenTextBox.Text = PersonalNumberChildren;
            SurnamesChildrenTextBox.Text = SurnamesChildren;
            NameChildrenTextBox.Text = NameChildren;
            MiddlenameChildrenTextBox.Text = MiddlenameChildren;
            GroupChildrenCombaBox.Text = GroupChildren;
            EventChildrenCombaBox.Text = EventChildren;
            FocusEventChildrenCombaBox.Text = FocusEventChildren;
            EvaluationChildrenCombaBox.Text = EvaluationChildren;
            DataEventChildrenDatePickerTextBox.Text = DataEventChildren;

            NextButtonStackPanel.Visibility = Visibility.Visible;
            EditInformationsButton.Visibility = Visibility.Collapsed;
            
            PersonalNumberChildrenTextBox.Visibility = Visibility.Visible;
            SurnamesChildrenTextBox.Visibility = Visibility.Visible;
            NameChildrenTextBox.Visibility = Visibility.Visible;
            MiddlenameChildrenTextBox.Visibility = Visibility.Visible;
            GroupChildrenCombaBox.Visibility = Visibility.Visible;
            EventChildrenCombaBox.Visibility = Visibility.Visible;
            FocusEventChildrenCombaBox.Visibility = Visibility.Visible;
            EvaluationChildrenCombaBox.Visibility = Visibility.Visible;
            DataEventChildrenDatePickerTextBox.Visibility = Visibility.Visible;

            PersonalNumberChildrenTextBlock.Visibility = Visibility.Collapsed;
            SurnamesChildrenTextBlock.Visibility = Visibility.Collapsed;
            NameChildrenTextBlock.Visibility = Visibility.Collapsed;
            MiddlenameChildrenTextBlock.Visibility = Visibility.Collapsed;
            GroupChildrenTextBlock.Visibility = Visibility.Collapsed;
            EventChildrenTextBlock.Visibility = Visibility.Collapsed;
            FocusEventChildrenTextBlock.Visibility = Visibility.Collapsed;
            EvaluationChildrenTextBlock.Visibility = Visibility.Collapsed;
            DataEventChildrenTextBlock.Visibility = Visibility.Collapsed;
        }

        private void CancelEditInformationsButton_Click(object sender, RoutedEventArgs e)
        {
            NextButtonStackPanel.Visibility = Visibility.Collapsed;
            EditInformationsButton.Visibility = Visibility.Visible;

            PersonalNumberChildrenTextBox.Visibility = Visibility.Collapsed;
            SurnamesChildrenTextBox.Visibility = Visibility.Collapsed;
            NameChildrenTextBox.Visibility = Visibility.Collapsed;
            MiddlenameChildrenTextBox.Visibility = Visibility.Collapsed;
            GroupChildrenCombaBox.Visibility = Visibility.Collapsed;
            EventChildrenCombaBox.Visibility = Visibility.Collapsed;
            FocusEventChildrenCombaBox.Visibility = Visibility.Collapsed;
            EvaluationChildrenCombaBox.Visibility = Visibility.Collapsed;
            DataEventChildrenDatePickerTextBox.Visibility = Visibility.Collapsed;

            PersonalNumberChildrenTextBlock.Visibility = Visibility.Visible;
            SurnamesChildrenTextBlock.Visibility = Visibility.Visible;
            NameChildrenTextBlock.Visibility = Visibility.Visible;
            MiddlenameChildrenTextBlock.Visibility = Visibility.Visible;
            GroupChildrenTextBlock.Visibility = Visibility.Visible;
            EventChildrenTextBlock.Visibility = Visibility.Visible;
            FocusEventChildrenTextBlock.Visibility = Visibility.Visible;
            EvaluationChildrenTextBlock.Visibility = Visibility.Visible;
            DataEventChildrenTextBlock.Visibility = Visibility.Visible;
        }
    }
}
