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
    /// Логика взаимодействия для BMRPage.xaml
    /// </summary>
    public partial class BMRPage : Page
    {
        public BMRPage()
        {
            InitializeComponent();
        }
        float g;
        float v;
        float r;
        float a;
        private void male(object sender, RoutedEventArgs e)
        {
            g = 66;
            v = 13.7f;
            r = 5;
            a = 6.8f;
            nfemale.Opacity = 0.7;
            nmale.Opacity = 1;
        }

        private void female(object sender, RoutedEventArgs e)
        {
            g = 655;
            v = 9.6f;
            r = 1.8f;
            a = 4.7f;
            nmale.Opacity = 0.7;
            nfemale.Opacity = 1;
        }

        private void Btn_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void count(object sender, RoutedEventArgs e)
        {
            try
            {
                float ves = float.Parse(t_v.Text);
                float height = float.Parse(t_height.Text);
                float age = float.Parse(t_age.Text);
                float bmr = g + (ves * v) + (r * height) - (a * age);
                if ((ves < 0 && height < 0 && age < 0) || (ves < 0 && height < 0) || (ves < 0 && age < 0) || (height > 0 && age < 0))
                {
                    MessageBox.Show("Указанны отрицательные значения");
                }
                else if (ves < 0 || age < 0 || height < 0)
                {
                    MessageBox.Show("Указанно отрицательное значение");
                }
                else if (g == 0)
                {
                    MessageBox.Show("Выбирите пол");
                }
                else
                {
                    bmr_tb.Text = bmr.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
