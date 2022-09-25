using SunKindergarten.ModelFolder;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
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
                SurnamesChildren,
                NamesChildren,
                MiddlenamesChildren,
                NameGroup,
                NameEvent,
                DataEvent;
            int Error = 0;

            SurnamesChildren = Convert.ToString(NewSurnamesChildrenTextBox.Text);
            NamesChildren = Convert.ToString(NewNamesChildrenTextBox.Text);
            MiddlenamesChildren = Convert.ToString(NewMiddlenamesChildrenTextBox.Text);
            NameGroup = Convert.ToString(NameGroupCombaBox.Text);
            NameEvent = Convert.ToString(NameEventCombaBox.Text);
            DataEvent = Convert.ToString(NewDataEventChildrenTextBox.Text);

            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 0;
            doubleAnimation.To = 22;
            doubleAnimation.EasingFunction = new QuadraticEase();

            if (SurnamesChildren.Length == 0)
            {
                NewSurnamesChildrenBorder.BeginAnimation(HeightProperty, doubleAnimation);
                NewSurnamesChildrenTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                NewSurnamesChildrenBorder.Visibility = Visibility.Visible;
                NewSurnamesChildrenTextBlock.Text = "Поле пустое";
                Error = Error++;;
            }
            else
            {
                NewSurnamesChildrenBorder.Visibility = Visibility.Collapsed;
                NewSurnamesChildrenBorder.Visibility = Visibility.Collapsed;
                Error = Error--;;
            }
            if (NamesChildren.Length == 0)
            {
                NewNamesChildrenBorder.BeginAnimation(HeightProperty, doubleAnimation);
                NewNamesChildrenTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                NewNamesChildrenBorder.Visibility = Visibility.Visible;
                NewNamesChildrenTextBlock.Text = "Поле пустое";
                Error = Error++;;
            }
            else
            {
                NewNamesChildrenBorder.Visibility = Visibility.Collapsed;
                NewNamesChildrenBorder.Visibility = Visibility.Collapsed;
                Error = Error--;;
            }
            if (MiddlenamesChildren.Length == 0)
            {
                NewMiddlenamesChildrenBorder.BeginAnimation(HeightProperty, doubleAnimation);
                NewMiddlenamesChildrenTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                NewMiddlenamesChildrenBorder.Visibility = Visibility.Visible;
                NewMiddlenamesChildrenTextBlock.Text = "Поле пустое";
                Error = Error++;;
            }
            else
            {
                NewMiddlenamesChildrenBorder.Visibility = Visibility.Collapsed;
                NewMiddlenamesChildrenBorder.Visibility = Visibility.Collapsed;
                Error = Error--;;
            }
            if (NameGroup.Length == 0)
            {
                NewNameGroupBorder.BeginAnimation(HeightProperty, doubleAnimation);
                NewNameGroupTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                NewNameGroupBorder.Visibility = Visibility.Visible;
                NewNameGroupTextBlock.Text = "Поле пустое";
                Error = Error++;;
            }
            else
            {
                NewNameGroupBorder.Visibility = Visibility.Collapsed;
                NewNameGroupBorder.Visibility = Visibility.Collapsed;
                Error = Error--;;
            }
            if (NameEvent.Length == 0)
            {
                NewNameEventBorder.BeginAnimation(HeightProperty, doubleAnimation);
                NewNameEventTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                NewNameEventBorder.Visibility = Visibility.Visible;
                NewNameEventTextBlock.Text = "Поле пустое";
                Error = Error++;;
            }
            else
            {
                NewNameEventBorder.Visibility = Visibility.Collapsed;
                NewNameEventBorder.Visibility = Visibility.Collapsed;
                Error = Error--;;
            }
            if (DataEvent.Length == 0)
            {
                NewDataEventBorder.BeginAnimation(HeightProperty, doubleAnimation);
                NewDataEventTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                NewDataEventBorder.Visibility = Visibility.Visible;
                NewDataEventTextBlock.Text = "Поле пустое";
                Error = Error++;
            }
            else
            {
                NewDataEventBorder.Visibility = Visibility.Collapsed;
                NewDataEventBorder.Visibility = Visibility.Collapsed;
                Error = Error--;;
            }

            if (Error > 0)
            { MessageBox.Show("" + Error); }
            else
            {
                if (AppConnectModelClass.DataBase.ChildrenTable.Count
                                      (PersonalData =>
                                       PersonalData.SurnamesChildren == SurnamesChildren &
                                       PersonalData.NameChildren == NamesChildren &
                                       PersonalData.MiddlenameChildren == MiddlenamesChildren) > 0)
                {
                    MessageBox.Show("Данный пользователь уже есть\n" + Error);
                }
            }
        }
    }
}
