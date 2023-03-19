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
         
        //Console.WriteLine(text);
        try
        {

            _input = CharStreams.fromString(text);
            _miniCScanner = new MiniCScanner(_input); // porque con el miniclexer si y con el minic no?
            Console.WriteLine(_input);
            tokens = new CommonTokenStream(_miniCScanner);
            _miniCParserParser = new MiniCParser(tokens);
            var tree = _miniCParserParser.program();
            Console.WriteLine("Compilacion finalizada");
            Console.WriteLine(tree.ToStringTree(_miniCParserParser));
            //string source = "using MiniC; class Main { varDecl int x, y; methodDecl void foo(int a, int b) { if (a < b) { x = a; } else { x = b; } write(x); } }";
            
            //var inputStream = new AntlrInputStream(source);
            //var lexer = new MiniCLexer(inputStream);
            //var tokenStream = new CommonTokenStream(lexer);
            //var parser = new MiniCParserParser(tokenStream);
            
            //var tree = parser.program();
            
            //Console.WriteLine(tree.ToStringTree(parser));


        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
            throw;
        }
    }
}