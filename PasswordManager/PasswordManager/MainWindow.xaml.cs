using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
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

namespace PasswordManager
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

        /// <summary>
        /// Entity class
        /// </summary>
        class Account
        {
            public int ID { get; set; }
            public string Email { get; set; }
            public string Pass { get; set; }
            public string Type { get; set; }
        }

        BindingList<Account> listAccount;

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {

            //create connection string to database localhost
            var connectionString = "Server=localhost\\SqlExpress;Database=PasswordManager; Trusted_connection=yes";
            var connection = new SqlConnection(connectionString); //connect to database

            listAccount = new BindingList<Account>();

            try
            {
                connection.Open(); //open connect

                var query = "select * from MyAccount";

                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                int index = 1;
                while (reader.Read())
                {
                    var newAcc = new Account();

                    newAcc.ID = index++;
                    newAcc.Email = (string)reader[1];
                    newAcc.Pass = (string)reader[2];
                    newAcc.Type = (string)reader[3];

                    listAccount.Add(newAcc);
                }

                connection.Close(); //close connect
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            listViewAccount.ItemsSource = listAccount;
            textblockConnect.Text = "Reload";
            imageConnect.Source = new BitmapImage(new Uri("Images/buttonReload.png", UriKind.Relative));

        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            //create connection string to database localhost
            var connectionString = "Server=localhost\\SqlExpress;Database=PasswordManager; Trusted_connection=yes";
            var connection = new SqlConnection(connectionString); //connect to database

            try
            {
                connection.Open(); //open connect

                var screen = new InfoScreen();
                if (screen.ShowDialog() == true)
                {
                    //copy information
                    var newAcc = new Account();
                    newAcc.Email = screen.Email;
                    newAcc.Pass = screen.Pass;
                    newAcc.Type = screen.Type;

                    //execute insert transaction
                    var query = $"insert into MyAccount values('{newAcc.Email}','{newAcc.Pass}','{newAcc.Type}')";
                    var command = new SqlCommand(query, connection);
                    var res = command.ExecuteNonQuery();

                    MessageBox.Show("Insert Successfully!!!", "Success", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }

                connection.Close(); //close connect

            }
            catch (Exception ex)
            {
                MessageBox.Show("Duplicate field, please try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedMail = listAccount[listViewAccount.SelectedIndex].Email;

            //create connection string to database localhost
            var connectionString = "Server=localhost\\SqlExpress;Database=PasswordManager; Trusted_connection=yes";
            var connection = new SqlConnection(connectionString); //connect to database

            try
            {
                connection.Open(); //open connect

                //execute insert transaction
                var query = $"delete from MyAccount where Email = '{selectedMail}'";
                var command = new SqlCommand(query, connection);
                var res = command.ExecuteNonQuery();

                MessageBox.Show("Delete Successfully!!!", "Success", MessageBoxButton.OK, MessageBoxImage.Asterisk);

                connection.Close(); //close connect
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void FileExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void HelpAbout_Click(object sender, RoutedEventArgs e)
        {
            var screen = new About();
            screen.ShowDialog();
        }
    }
}
