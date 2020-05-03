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
using System.Windows.Shapes;

namespace PasswordManager
{
    /// <summary>
    /// Interaction logic for InfoScreen.xaml
    /// </summary>
    public partial class InfoScreen : Window
    {
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Type { get; set; }

        public InfoScreen()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            if (textboxConfirm.Password == "" || textboxEmail.Text == "" || textboxPass.Password == "")
            {
                MessageBox.Show("Please check again and fill all information", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                if (textboxPass.Password.ToString() != textboxConfirm.Password.ToString())
            {
                MessageBox.Show("Password does not match, please check again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Email = textboxEmail.Text.ToString();
                Pass = textboxPass.Password.ToString();
                Type = textboxType.Text.ToString();

                this.DialogResult = true;
                this.Close();
            }

        }
    }
}

