using SunKindergarten.ModelFolder;
using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

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
            string
                SurnamesChildrenstring,
                NamesChildrenstring,
                MiddlenamesChildrenstring,
                NameGroupstring,
                NameEventstring;
            DateTime thisDay = DateTime.Today;

            SurnamesChildrenstring = Convert.ToString(NewSurnamesChildrenTextBox.Text);
            NamesChildrenstring = Convert.ToString(NewNamesChildrenTextBox.Text);
            MiddlenamesChildrenstring = Convert.ToString(NewMiddlenamesChildrenTextBox.Text);
            NameGroupstring = Convert.ToString(NameGroupCombaBox.Text);
            NameEventstring = Convert.ToString(NameEventCombaBox.Text);

            

            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 0;
            doubleAnimation.To = 22;
            doubleAnimation.EasingFunction = new QuadraticEase();

            if (SurnamesChildrenstring.Length == 0)
            {
                NewSurnamesChildrenBorder.BeginAnimation(HeightProperty, doubleAnimation);
                NewSurnamesChildrenTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                NewSurnamesChildrenBorder.Visibility = Visibility.Visible;
                NewSurnamesChildrenTextBlock.Text = "Поле пустое";
            }
            else
            {
                NewSurnamesChildrenBorder.Visibility = Visibility.Collapsed;
                NewSurnamesChildrenBorder.Visibility = Visibility.Collapsed;
            }
            if (NamesChildrenstring.Length == 0)
            {
                NewNamesChildrenBorder.BeginAnimation(HeightProperty, doubleAnimation);
                NewNamesChildrenTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                NewNamesChildrenBorder.Visibility = Visibility.Visible;
                NewNamesChildrenTextBlock.Text = "Поле пустое";
            }
            else
            {
                NewNamesChildrenBorder.Visibility = Visibility.Collapsed;
                NewNamesChildrenBorder.Visibility = Visibility.Collapsed;
            }
            if (MiddlenamesChildrenstring.Length == 0)
            {
                NewMiddlenamesChildrenBorder.BeginAnimation(HeightProperty, doubleAnimation);
                NewMiddlenamesChildrenTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                NewMiddlenamesChildrenBorder.Visibility = Visibility.Visible;
                NewMiddlenamesChildrenTextBlock.Text = "Поле пустое";
            }
            else
            {
                NewMiddlenamesChildrenBorder.Visibility = Visibility.Collapsed;
                NewMiddlenamesChildrenBorder.Visibility = Visibility.Collapsed;
            }
            if (NameGroupstring.Length == 0)
            {
                NewNameGroupBorder.BeginAnimation(HeightProperty, doubleAnimation);
                NewNameGroupTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                NewNameGroupBorder.Visibility = Visibility.Visible;
                NewNameGroupTextBlock.Text = "Поле пустое";
            }
            else
            {
                NewNameGroupBorder.Visibility = Visibility.Collapsed;
                NewNameGroupBorder.Visibility = Visibility.Collapsed;
            }
            if (NameEventstring.Length == 0)
            {
                NewNameEventBorder.BeginAnimation(HeightProperty, doubleAnimation);
                NewNameEventTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                NewNameEventBorder.Visibility = Visibility.Visible;
                NewNameEventTextBlock.Text = "Поле пустое";
            }
            else
            {
                NewNameEventBorder.Visibility = Visibility.Collapsed;
                NewNameEventBorder.Visibility = Visibility.Collapsed;
            }

            if (AppConnectModelClass.DataBase.ChildrenTable.Count
                (PersonalData =>
                 PersonalData.SurnamesChildren == SurnamesChildrenstring &
                 PersonalData.NameChildren == NamesChildrenstring &
                 PersonalData.MiddlenameChildren == MiddlenamesChildrenstring) > 0)
            {
                MessageBox.Show("Данный пользователь уже есть");
                return;
            }
            else
            {
                try
                {
                    ChildrenTable childrenTable = new ChildrenTable()
                    {
                        SurnamesChildren = SurnamesChildrenstring,
                        NameChildren = NamesChildrenstring,
                        MiddlenameChildren = MiddlenamesChildrenstring,
                        GroupChildren = NameGroupstring
                    };

                    ResultTable resultTable = new ResultTable()
                    {
                        PersonalNameEvent = NameEventstring,
                        DataEventResult = thisDay,
                        PersonalNameEvaluation = "NEW",
                        SurnamesChildrenResult = SurnamesChildrenstring,
                        NameChildrenResult = NamesChildrenstring
                    };
                    AppConnectModelClass.DataBase.ChildrenTable.Add(childrenTable);
                    AppConnectModelClass.DataBase.ResultTable.Add(resultTable);
                    AppConnectModelClass.DataBase.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
