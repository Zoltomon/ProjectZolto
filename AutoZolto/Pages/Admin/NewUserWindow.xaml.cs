using AutoZolto.Classes;
using AutoZolto.Models;
using Microsoft.EntityFrameworkCore;
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

namespace AutoZolto.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для NewUserWindow.xaml
    /// </summary>
    public partial class NewUserWindow : Window
    {
        public NewUserWindow()
        {
            InitializeComponent();
            CmbRole.ItemsSource = ConnectDB.connect.Roles.Select(x=>x.NameRole).ToList();
        }

        private void TxbPass_TextChanged(object sender, TextChangedEventArgs e)
        {
            string password = TxbPass.Text;
            int passwordStrength = CalculatePasswordStrength(password);

            PassStrength.Value = passwordStrength;

            if (string.IsNullOrEmpty(password))
            {
                HidePasswordStrength();
            }
            else
            {
                ShowPasswordStrength();
                UpdatePasswordStrengthUI(passwordStrength);
            }
        }
        private int CalculatePasswordStrength(string password)
        {

            int passwordLength = password.Length;
            int passwordStrength = 0;

            if (passwordLength >= 8)
            {
                passwordStrength += 30;
            }
            else if (passwordLength >= 6)
            {
                passwordStrength += 15;
            }

            if (password.Any(char.IsDigit))
            {
                passwordStrength += 20;
            }
            if (password.Any(char.IsLower) && password.Any(char.IsUpper))
            {
                passwordStrength += 20;
            }

            if (password.Any(IsSpecialCharacter))
            {
                passwordStrength += 15;
            }

            return passwordStrength;
        }
        private bool IsSpecialCharacter(char c)
        {
            char[] specialCharacters = { '!', '@', '#', '$', '%' };

            return specialCharacters.Contains(c);
        }

        private void HidePasswordStrength()
        {
            PassStrength.Visibility = Visibility.Collapsed;
            TxbBlcPassStrength.Visibility = Visibility.Collapsed;
        }

        private void ShowPasswordStrength()
        {
            PassStrength.Visibility = Visibility.Visible;
            TxbBlcPassStrength.Visibility = Visibility.Visible;
        }

        private void UpdatePasswordStrengthUI(int passwordStrength)
        {
            if (passwordStrength >= 70)
            {
                PassStrength.Background = new SolidColorBrush(Colors.Red);
                TxbBlcPassStrength.Text = "Сложный пароль";
            }
            else if (passwordStrength >= 30)
            {
                PassStrength.Background = new SolidColorBrush(Colors.Orange);
                TxbBlcPassStrength.Text = "Средний пароль";
            }
            else
            {
                PassStrength.Background = new SolidColorBrush(Colors.Green);
                TxbBlcPassStrength.Text = "Легкий пароль";
            }
        }
    

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string log = TxbLog.Text;
                string pass = TxbPass.Text;
                string copyPass = TxbCopyPass.Text;
                if (pass != "" || log != "")
                {
                    if (pass == copyPass)
                    {
                        if (pass.Length >= 5)
                        {
                            string hashPass = BCrypt.Net.BCrypt.HashPassword(pass);
                            User newUser = new User()
                            {
                                Login = log,
                                Password = hashPass,
                                StatusId = 3,
                                RoleId = CmbRole.SelectedIndex
                            };
                            ConnectDB.connect.Users.Add(newUser);
                            ConnectDB.connect.SaveChanges();
                            MessageBox.Show("Вы успешно зарегестрировались");
                        }
                        else
                        {
                            MessageBox.Show("Ваш пароль слишком короткий");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают");
                    }
                }
                else
                {
                    MessageBox.Show("Введите данные");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сервера" + ex);
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
    }
}
