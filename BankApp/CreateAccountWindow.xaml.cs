using BankApp.Models;
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

namespace BankApp
{
    /// <summary>
    /// Interaction logic for CreateAccountWindow.xaml
    /// </summary>
    public partial class CreateAccountWindow : Window
    {
        public CreateAccountWindow()
        {
            InitializeComponent();
        }

        public string Name => nameTextBox.Text;
        public string Iban => ibanTextBox.Text;

        private void OnCreateAccount(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.Name) && !string.IsNullOrWhiteSpace(this.Iban))
            {
                this.DialogResult = true;
                this.Close();
            }
        }
    }
}
