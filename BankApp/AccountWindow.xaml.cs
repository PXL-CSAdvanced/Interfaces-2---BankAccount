using BankApp.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        public AccountWindow()
        {
            InitializeComponent();
        }

        private IBankAccount _account = null;

        private void OnCreateAccount(object sender, RoutedEventArgs e)
        {
            CreateAccountWindow window = new CreateAccountWindow();

            if(window.ShowDialog() == true)
            {
                MenuItem item = sender as MenuItem;
                switch(item.Header)
                {
                    case "KBC":
                        _account = new KbcAccount(window.Name, window.Iban);
                        break;
                    case "Argenta":
                        _account = new ArgentaAccount(window.Name, window.Iban);
                        break;
                }

                UpdateWindow();
            }
        }

        private void UpdateWindow()
        {
            bankLabel.Content = _account.Bank;
            nameLabel.Content = _account.Name;
            ibanLabel.Content = _account.Iban;
            saldoLabel.Content = _account.Saldo.ToString("C");
            amountTextBox.Focus();
        }

        private void OnAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if(decimal.TryParse(amountTextBox.Text, out decimal amount))
                {
                    if (amount > 0)
                    {
                        _account.Deposit(Math.Abs(amount));
                    }
                    else
                    {
                        _account.Withdrawal(Math.Abs(amount));
                    }

                    UpdateWindow();

                    amountTextBox.Clear();
                    amountTextBox.Focus();
                }
            }
        }
    }
}