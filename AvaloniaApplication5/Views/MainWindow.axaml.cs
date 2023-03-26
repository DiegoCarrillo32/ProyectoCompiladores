using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Input;
using Antlr4.Runtime;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using AvaloniaApplication5.Views;
using AvaloniaApplication5.ViewModels;
using gen;


namespace AvaloniaApplication5.Views;

public partial class MainWindow : Window
{
    private MiniCParser _miniCParserParser = null;
    private MiniCScanner _miniCScanner = null;
    private CommonTokenStream tokens = null;
    ICharStream _input=null;
    MyErrorListener errorListener = null;
    private ConsoleWindow cw = new ConsoleWindow();
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
        //Text_line.Text = "1\n";
    }
    
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        //INICIALIZO LA CONSOLA
        cw.Show();
        
        TextBox myTextBox = this.FindControl<TextBox>("Text_box");
        String text = myTextBox.Text;
        try
        {
            errorListener = new MyErrorListener();
            _input = CharStreams.fromString(text);
            _miniCScanner = new MiniCScanner(_input);
            Console.WriteLine(_input);
            tokens = new CommonTokenStream(_miniCScanner);
            _miniCParserParser = new MiniCParser(tokens);
            
            
            //ERRORES
            //_miniCScanner.RemoveErrorListeners();

            _miniCParserParser.RemoveErrorListeners();
            _miniCParserParser.AddErrorListener(errorListener);
            
            
            var tree = _miniCParserParser.program();
            if(errorListener.hasErrors() == false){
                Console.WriteLine("Compilación exitosa");
                Console.WriteLine(tree.ToStringTree(_miniCParserParser));
                cw.text_block.Text += "Compilacion exitosa \n";
                cw.text_block.Text += tree.ToStringTree(_miniCParserParser) + "\n";
                
                //java.util.concurrent.Future<JFrame> treeGUI = org.antlr.v4.gui.Trees.inspect(tree, parser);
                //treeGUI.get().setVisible(true);
            } else {
                Console.WriteLine("Compilacion fallida");
                Console.WriteLine(errorListener.ToString());
                cw.text_block.Text += "Compilacion fallida \n";
                cw.text_block.Text += errorListener;
                
            }
            
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
            throw;
        }
    }
    
    private async void OpenFile_Click(object sender, RoutedEventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.AllowMultiple = false;
        openFileDialog.Title = "Select a file";
        openFileDialog.Filters.Add(new FileDialogFilter { Name = "Text Files", Extensions = { "txt" } });
        var selectedFile = await openFileDialog.ShowAsync(this);
        if (selectedFile != null)
        {
             Console.WriteLine(selectedFile[0]);
             var fileContents = File.ReadAllText(selectedFile[0]);
             Console.WriteLine(fileContents);
             var viewModel = (MainWindowViewModel)DataContext;
             viewModel.FilePath = fileContents;
             //_viewModel.FilePath = fileContents;
             // FilePopup.IsOpen = true;
        }
    }

    private void Text_box_OnKeyUp(object? sender, KeyEventArgs e)
    {
        int counterTextLine = 0;
        Text_line.Text = "";
        //Text_line.Content = "";
        //Cuenta los \n que hay en TextBox
        for (int i = 0; Text_box.Text.Length > i; i++)
        {
            if ((Text_box.Text[i]).ToString() == "\n")
            {
                counterTextLine++;
                Text_line.Text += counterTextLine + "\n";
                //Text_line.Content += counterTextLine + "\n";
            }
        }
    }
}