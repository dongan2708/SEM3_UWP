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
using Lab03.Pages;
using Lab03.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Lab03.Pages.Menus
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Contact : Page
    {
        public static ListView ContactList;
        public Contact()
        {
            this.InitializeComponent();
            ContactList = ContactsLV;
        }

        private void GotoAddContact_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Layout.MainNavigationFrame.Navigate(typeof(Pages.Menus.AddContact));
        }

        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    if (e.Parameter is List<ContactUser>)
        //    {
        //        List<ContactUser> a = e.Parameter as List<ContactUser>;
        //        ContactsLV.Items.Add(a);
        //    }
        //}
    }
}
