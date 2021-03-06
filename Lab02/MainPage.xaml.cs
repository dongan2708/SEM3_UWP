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
using Lab02.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab02
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = inputEmail.Text;
            string subject = inputSubject.Text;
            string content = inputContent.Text;

            TxtBlockEmail.Text = "Đã gửi đến: " + email;
            TxtBlockSubject.Text = "Chủ đề thư: " + subject;
            TxtBlockContent.Text = "Nội dung thư:\n" + content;

            User u1 = new User(email, content);
            ListUsers.Items.Add(u1);
        }

        private void AppbarButton_Click(object sender, RoutedEventArgs e)
        {
            SV.IsPaneOpen = !SV.IsPaneOpen;
        }

        private void ListUsers_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
