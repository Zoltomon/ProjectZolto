using AutoZolto.Classes;
using AutoZolto.Models;
using AutoZolto.Pages.Admin;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace AutoZolto.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            try
            {
                DataGridUser.ItemsSource = ConnectDB.connect.PersonalData.Include(x => x.User).Include(x => x.User.Role).Include(x => x.User.Status).ToList();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Ошибка сервера");
            }
        }

        private void BtnStatusActivate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PersonalDatum selectedUser = ((FrameworkElement)sender).DataContext as PersonalDatum;
                if (selectedUser != null)
                {
                    selectedUser.User.StatusId = 1;
                    ConnectDB.connect.Entry(selectedUser).State = EntityState.Modified;
                    ConnectDB.connect.SaveChanges();
                    DataGridUser.ItemsSource = ConnectDB.connect.PersonalData.Include(x => x.User).Include(x => x.User.Role).Include(x => x.User.Status).ToList();
                    MessageBox.Show("Пользователь заблокирован");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Все плохо");
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NavigationClass.navigate.GoBack();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnStatusBad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PersonalDatum selectedUser = ((FrameworkElement)sender).DataContext as PersonalDatum;
                if (selectedUser != null)
                {
                    selectedUser.User.StatusId = 2;
                    ConnectDB.connect.Entry(selectedUser).State = EntityState.Modified;
                    ConnectDB.connect.SaveChanges();
                    DataGridUser.ItemsSource = ConnectDB.connect.PersonalData.Include(x => x.User).Include(x => x.User.Role).Include(x => x.User.Status).ToList();
                    MessageBox.Show("Пользователь заблокирован");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnActivUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataGridUser.Columns[7].Visibility = Visibility.Collapsed;
                DataGridUser.Columns[6].Visibility = Visibility.Visible;
                DataGridUser.ItemsSource = ConnectDB.connect.PersonalData.Include(x => x.User).Include(x => x.User.Role).Include(x => x.User.Status).Where(x => x.User.Status.NameStatus == "Активен").ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnNotActivUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataGridUser.Columns[7].Visibility = Visibility.Visible;
                DataGridUser.Columns[6].Visibility = Visibility.Collapsed;
                DataGridUser.ItemsSource = ConnectDB.connect.PersonalData.Include(x => x.User).Include(x => x.User.Role).Include(x => x.User.Status).Where(x => x.User.Status.NameStatus == "Неактивен").ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPostUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NewUserWindow newUser = new NewUserWindow();
                newUser.ShowDialog();
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdmin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataGridUser.ItemsSource = ConnectDB.connect.PersonalData.Include(x => x.User).Include(x => x.User.Role).Include(x => x.User.Status).Where(x => x.User.Role.NameRole == "Админ").ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void BtnUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataGridUser.ItemsSource = ConnectDB.connect.PersonalData.Include(x => x.User).Include(x => x.User.Role).Include(x => x.User.Status).Where(x => x.User.Role.NameRole == "Клиент").ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }
    }
}
