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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Security.Principal;
using SA;
using DiscordRPC;
using DiscordButton = DiscordRPC.Button;

namespace KillByfron
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DiscordRpcClient client;
        public MainWindow()
        {
            InitializeComponent();
            InitializeDiscordRPC();
        }


        private void InitializeDiscordRPC()
        {
            client = new DiscordRpcClient("1344468008386691153");
            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = "Using KillByfron",
                State = "Keyless Executor!",
                Assets = new Assets()
                {
                    LargeImageKey = "logo.ico",
                    LargeImageText = "KillByfron",
                    SmallImageKey = "your_small_image"
                },

                Buttons = new DiscordRPC.Button[]
{
    new DiscordRPC.Button() { Label = "Website", Url = "https://kill-byfron.vercel.app" },
    new DiscordRPC.Button() { Label = "Discord", Url = "https://discord.gg/3t7EfcW5NB" }
}

            });
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            monkey.Attach();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            monkey.Execute(textbox.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox.Text = "KillByfron On Top!";
        }
        
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textbox.Text = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source\"))()";
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textbox.AcceptsReturn = true;
            textbox.TextWrapping = TextWrapping.Wrap;
        }
    }
}
