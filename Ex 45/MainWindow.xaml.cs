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

namespace Ex_45
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_InsertPet_Click(object sender, RoutedEventArgs e)
        {
            Tb_First.IsEnabled = true;
            Tb_Second.IsEnabled = true;
            Tb_Third.IsEnabled = true;
            Tb_Fourth.IsEnabled = true;
            Tb_Fifth.IsEnabled = true;
            Tb_Sixth.IsEnabled = true;
            Lb_First.Content = "Insert Pet Name";
            Lb_Second.Content = "Insert Pet Type";
            Lb_Third.Content = "Insert Pet Breed";
            Lb_Fourth.Content = "Insert Pet DOB";
            Lb_Fifth.Content = "Insert Pet Weight";
            Lb_Fifth.Content = "Insert Owner ID ";

        }

        private void Btn_InsertOwner_Click(object sender, RoutedEventArgs e)
        {
            Tb_First.IsEnabled = true;
            Tb_Second.IsEnabled = true;
            Tb_Third.IsEnabled = true;
            Tb_Fourth.IsEnabled = true;
            Tb_Fifth.IsEnabled = true;
            Lb_First.Content = "Insert Owner ID";
            Lb_Second.Content = "Insert Owner First Name";
            Lb_Third.Content = "Insert Owner Last Name";
            Lb_Fourth.Content = "Insert Owner Phone";
            Lb_Fifth.Content = "Insert Owner E-mail";
        }

        private void Btn_ShowAllPets_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_FindOwnerByLastName_Click(object sender, RoutedEventArgs e)
        {
            Tb_First.IsEnabled = true;
            Lb_Third.Content = "Insert Owner Last Name";
        }

        private void Tb_First_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tb_Second_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tb_Third_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tb_Fourth_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tb_Fifth_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tb_Sixth_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
