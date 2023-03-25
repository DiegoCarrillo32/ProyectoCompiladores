using System;
using Antlr4.Runtime;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaApplication5;
using AvaloniaApplication5.Views;


namespace AvaloniaApplication5.Views
{
    public partial class ConsoleWindow : Window
    {
        public ConsoleWindow()
        {
            // Generated with Avalonia.NameGenerator
            InitializeComponent();

        }

        public String showText(MyErrorListener errorListener)
        {
            TextBlock myTextBlock = this.FindControl<TextBlock>("code_editor");
            //String text = myTextBlock.Text(errorListener.ToString());
            myTextBlock.Text = "Algo";
            return errorListener.ToString();
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            // Change button text when button is clicked.
            var button = (Button)sender;
            button.Content = "Hello, Avalonia!";
        }
    }
}