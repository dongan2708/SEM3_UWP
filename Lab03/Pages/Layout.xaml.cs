
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Lab03.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Lab03.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public static Frame MainNavigationFrame;
        public Layout()
        {
            this.InitializeComponent();
            MainNavigationFrame = MainFrame;
        }

        private void HambergerButton_Click(object sender, RoutedEventArgs e)
        {
            //HB_Menu.IsPaneOpen = !HB_Menu.IsPaneOpen;
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            MN.Items.Add(new MenuItem { MenuName = "Home", MenuPage = "home", MenuFont = "&#xE700;" });
            MN.Items.Add(new MenuItem { MenuName = "Contact", MenuPage = "contact", MenuFont = "&#xE8D4;" });
            MN.Items.Add(new MenuItem { MenuName = "Customer", MenuPage = "customer", MenuFont = "&#xE716;" });
            MN.Items.Add(new MenuItem { MenuName = "Mail", MenuPage = "mail", MenuFont = "&#xEDB3;" });
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem item = MN.SelectedItem as MenuItem;
            switch (item.MenuPage)
            {
                case "home":
                    {
                        MainFrame.Navigate(typeof(Pages.Menus.Home), "Day la trang chu :D");
                        break;
                    }
                case "contact":
                    {
                        MainFrame.Navigate(typeof(Pages.Menus.Contact), "Day la trang lien he :D");
                        break;
                    }
                case "customer":
                    {
                        MainFrame.Navigate(typeof(Pages.Menus.Customer), "Day la trang cua customer :D");
                        break;
                    }
                case "mail":
                    {
                        MainFrame.Navigate(typeof(Pages.Menus.Mail), "Day la mail cua customer :D");
                        break;
                    }
            }
        }


    }
}
