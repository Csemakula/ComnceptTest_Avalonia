using Avalonia.Controls;
using System;

namespace ComnceptTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int x = 0;
            while (x < 10)
            {
                x++;
                worldBtn.Content = "Wait " + x;
                Delay(2000);
                worldBtn.Content = "Howdy!";
            }
            worldBtn.Content = "Hello World!";
        }

        public static void Delay(int milliseconds)
        {
            var start = DateTime.Now;
            while (DateTime.Now - start < TimeSpan.FromMilliseconds(milliseconds))
            {
                // Do nothing
            }
        }
    }
}