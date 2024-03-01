using System;
using System.Collections.Generic;
using System.DirectoryServices;
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

// Author: Kviatkovskyi Andrii

namespace KviatkovskyiLab1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ZodiacWestern.Text = "";
            ZodiacChinese.Text = "";
            Age.Text = "";
            Congrats.Text = "";
            BirthdayViewModel bvm = new BirthdayViewModel();
            if (!PickedBirthday.SelectedDate.HasValue) MessageBox.Show("Choose a date, please", "NO DATE CHOSEN");
            else
            {
                bvm.Birthdate = PickedBirthday.SelectedDate.Value;
                int age = bvm.Age;
                if(age < 0 || age > 135) 
                {
                    MessageBox.Show("Your age must be between 0 and 135", "INVALID AGE");
                }
                else
                {
                    ZodiacWestern.Text = bvm.ZodiacWestern;
                    ZodiacChinese.Text = bvm.ZodiacChinese;
                    Age.Text =  ""+age;
                    if (bvm.IsBirthday) Congrats.Text = "HAPPY BIRTHDAY!!!";
                } 
            }
        }
    }
}
