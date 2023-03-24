using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Input;
using Antlr4.Runtime;
using Avalonia.Controls;
using Avalonia.Interactivity;
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
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
        


    }
    
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        TextBox myTextBox = this.FindControl<TextBox>("code_editor");
        string text = myTextBox.Text;
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
                //java.util.concurrent.Future<JFrame> treeGUI = org.antlr.v4.gui.Trees.inspect(tree, parser);
                //treeGUI.get().setVisible(true);
            } else {
                Console.WriteLine("Compilacion fallida");
                Console.WriteLine(errorListener.ToString());

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

}