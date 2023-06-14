using AutoZolto.Classes;
using AutoZolto.Models;
using AutoZolto.Pages.Client;
using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
using System.Windows.Threading;

namespace AutoZolto.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private int failedAttempts = 0; // Переменная для отслеживания неудачных попыток
        private bool inputBlocked = false; // Переменная для проверки состояния блокировки
        private DispatcherTimer timer; 
        private async void BtnAuto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (inputBlocked)
                {
                    MessageBox.Show("Ввод заблокирован на 30 секунд.");
                    return;
                }

                if (failedAttempts >= 3)
                {
                    TxbLog.IsEnabled = false;
                    TxbPass.IsEnabled = false;
                    MessageBox.Show("Превышено количество неудачных попыток. Ввод заблокирован на 30 секунд.");
                    inputBlocked = true;
                    timer = new DispatcherTimer();
                    timer.Interval = TimeSpan.FromSeconds(30);
                    timer.Tick += Timer_Tick;
                    timer.Start();
                    return;
                }

                string url = $"https://localhost:7008/api/User?UserLogin={TxbLog.Text}&UserPassword={TxbPass.Text}";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!string.IsNullOrEmpty(TxbLog.Text) && !string.IsNullOrEmpty(TxbPass.Text))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine(responseContent);
                        var _signIn = JsonConvert.DeserializeObject<List<User>>(responseContent);
                        #region
                        //switch (_signIn.Count > 0 )
                        //{
                        //    case 1:
                        //        switch (_signIn.RoleId)
                        //        {
                        //            case 1:
                        //                NavigationClass.navigate.Navigate(new MainPage());
                        //                MessageBox.Show("Все хорошо1");
                        //                break;
                        //            case 2:
                        //                NavigationClass.navigate.Navigate(new UserPage());
                        //                MessageBox.Show("Все хорошо2");
                        //                break;
                        //        }
                        //        break;
                        //    case 2:
                        //        MessageBox.Show("Ваш аккаунт заблокирован");
                        //        break;
                        //    case 3:
                        //        MessageBox.Show("Вам необходимо потвердить пароль для своего аккаунта");
                        //        TxbPass.Clear();
                        //        TxbBlcCopyPass.Visibility = Visibility.Visible;
                        //        TxbCopyPass.Visibility = Visibility.Visible;
                        //        break;
                        //}
                        #endregion

                            if(_signIn.Count >0)
                            {
                                string role = _signIn[0].Role.NameRole;
                                string status = _signIn[0].Status.NameStatus;
                                switch (status)
                                {
                                    case "Активен":
                                    if(role == "Админ")
                                    {
                                        NavigationClass.navigate.Navigate(new MainPage());
                                        MessageBox.Show("Все хорошо");
                                    }
                                    else if(role == "Клиент")
                                    {
                                        NavigationClass.navigate.Navigate(new UserPage());
                                        MessageBox.Show("Все хорошо2");
                                    }
                                    #region
                                    //switch (role)
                                    //{
                                    //    case "Админ":
                                    //        NavigationClass.navigate.Navigate(new MainPage());
                                    //        MessageBox.Show("Все хорошо1");
                                    //        break;
                                    //    case "Клиент":
                                    //        NavigationClass.navigate.Navigate(new UserPage());
                                    //        MessageBox.Show("Все хорошо2");
                                    //        break;
                                    //}
                                    #endregion
                                    break;
                                    case "Неактивен":
                                        MessageBox.Show("Ваш аккаунт заблокирован");
                                        break;
                                    case "Ждет активации":
                                        MessageBox.Show("Вам необходимо потвердить пароль для своего аккаунта");
                                        TxbPass.Clear();
                                        TxbBlcCopyPass.Visibility = Visibility.Visible;
                                        TxbCopyPass.Visibility = Visibility.Visible;
                                    if (_signIn.Count > 0)
                                    {
                                        int userId = _signIn[0].Id; // Предположим, что у вас есть поле Id для идентификации пользователя
                                        User userToUpdate = ConnectDB.connect.Users.Find(userId);
                                        if (userToUpdate != null)
                                        {
                                            userToUpdate.StatusId = 1; // Установка нового статуса "Активен"
                                            ConnectDB.connect.SaveChanges(); // Сохранение изменений в базе данных
                                        }
                                    }
                                    break;
                                }
                            }
                    }
                    else
                    {
                        MessageBox.Show("Авторизация не пройдена");
                        failedAttempts++;
                    }
                }
                else
                {
                    MessageBox.Show("Данные не введены!");;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Ошибка: " + er.Message);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TxbLog.IsEnabled = true; // Разблокируем поле ввода логина
            TxbPass.IsEnabled = true; // Разблокируем поле ввода пароля
            inputBlocked = false; // Устанавливаем состояние блокировки в false
            timer.Stop(); // Останавливаем таймер
            timer.Tick -= Timer_Tick;
        }
    }
}
