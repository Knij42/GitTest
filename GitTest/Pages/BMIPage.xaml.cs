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

namespace GitTest.Pages
{
    /// <summary>
    /// Логика взаимодействия для BMIPage.xaml
    /// </summary>
    public partial class BMIPage : Page
    {
        public BMIPage()
        {
            InitializeComponent();
        }

        private void Btn_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        int g;
        private void male(object sender, RoutedEventArgs e)
        {
            g = 1;
            nfemale.Opacity = 0.7;
            nmale.Opacity = 1;
        }

        private void female(object sender, RoutedEventArgs e)
        {
            g = 1;
            nmale.Opacity = 0.7;
            nfemale.Opacity = 1;
        }
        private void count(object sender, RoutedEventArgs e)
        {
            try
            {
                float ves = float.Parse(t_v.Text);
                float height = float.Parse(t_height.Text);
                height = height / 100;
                float bmi = ves / height * height;
                if (ves < 0 && height < 0)
                {
                    MessageBox.Show("Указанны отрицательные значения");
                }
                else if (ves < 0 || height < 0)
                {
                    MessageBox.Show("Указанно отрицательное значение");
                }
                else if (g == 0)
                {
                    MessageBox.Show("Выбирите пол");

                    bmr_tb.Text = "";
                }
                else
                {
                    bmr_tb.Text = bmi.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
