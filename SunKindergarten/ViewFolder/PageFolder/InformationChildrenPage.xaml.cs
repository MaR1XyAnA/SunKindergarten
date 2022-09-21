using SunKindergarten.ModelFolder;
using System;
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
                GroupChildren;

            PersonalNumberChildren = Convert.ToString(PersonalNumberChildrenTextBlock.Text);
            SurnamesChildren = Convert.ToString(SurnamesChildrenTextBlock.Text);
            NameChildren = Convert.ToString(NameChildrenTextBlock.Text);
            MiddlenameChildren = Convert.ToString(MiddlenameChildrenTextBlock.Text);
            GroupChildren = Convert.ToString(GroupChildrenTextBlock.Text);

            PersonalNumberChildrenTextBox.Text = PersonalNumberChildren;
            SurnamesChildrenTextBox.Text = SurnamesChildren;
            NameChildrenTextBox.Text = NameChildren;
            MiddlenameChildrenTextBox.Text = MiddlenameChildren;
            GroupChildrenTextBox.Text = GroupChildren;

            NextButtonStackPanel.Visibility = Visibility.Visible;
            EditInformationsButton.Visibility = Visibility.Collapsed;
            
            PersonalNumberChildrenTextBox.Visibility = Visibility.Visible;
            SurnamesChildrenTextBox.Visibility = Visibility.Visible;
            NameChildrenTextBox.Visibility = Visibility.Visible;
            MiddlenameChildrenTextBox.Visibility = Visibility.Visible;
            GroupChildrenTextBox.Visibility = Visibility.Visible;

            PersonalNumberChildrenTextBlock.Visibility = Visibility.Collapsed;
            SurnamesChildrenTextBlock.Visibility = Visibility.Collapsed;
            NameChildrenTextBlock.Visibility = Visibility.Collapsed;
            MiddlenameChildrenTextBlock.Visibility = Visibility.Collapsed;
            GroupChildrenTextBlock.Visibility = Visibility.Collapsed;
        }

        private void CancelEditInformationsButton_Click(object sender, RoutedEventArgs e)
        {
            NextButtonStackPanel.Visibility = Visibility.Collapsed;
            EditInformationsButton.Visibility = Visibility.Visible;

            PersonalNumberChildrenTextBox.Visibility = Visibility.Collapsed;
            SurnamesChildrenTextBox.Visibility = Visibility.Collapsed;
            NameChildrenTextBox.Visibility = Visibility.Collapsed;
            MiddlenameChildrenTextBox.Visibility = Visibility.Collapsed;
            GroupChildrenTextBox.Visibility = Visibility.Collapsed;

            PersonalNumberChildrenTextBlock.Visibility = Visibility.Visible;
            SurnamesChildrenTextBlock.Visibility = Visibility.Visible;
            NameChildrenTextBlock.Visibility = Visibility.Visible;
            MiddlenameChildrenTextBlock.Visibility = Visibility.Visible;
            GroupChildrenTextBlock.Visibility = Visibility.Visible;
        }
    }
}
