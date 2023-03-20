using System;
using System.Diagnostics;
using Antlr4.Runtime;
using Avalonia.Controls;
using Avalonia.Interactivity;
using gen;

namespace AvaloniaApplication5.Views;

public partial class MainWindow : Window
{
    private MiniCParser _miniCParserParser = null;
    private MiniCScanner _miniCScanner = null;
    private CommonTokenStream tokens = null;
    ICharStream _input=null;
    
    
    public MainWindow()
    {
        InitializeComponent();
    
    }
    
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        TextBox myTextBox = this.FindControl<TextBox>("code_editor");
        string text = myTextBox.Text;
        try
        {
            _input = CharStreams.fromString(text);
            _miniCScanner = new MiniCScanner(_input);
            Console.WriteLine(_input);
            tokens = new CommonTokenStream(_miniCScanner);
            _miniCParserParser = new MiniCParser(tokens);
            var tree = _miniCParserParser.program();
            Console.WriteLine("Compilación finalizada");
            Console.WriteLine(tree.ToStringTree(_miniCParserParser));
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
            throw;
        }
    }
}