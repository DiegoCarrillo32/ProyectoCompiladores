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
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();;

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

    private async void OpenFile_Click(object sender, RoutedEventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.AllowMultiple = false;
        openFileDialog.Title = "Select a file";
        openFileDialog.Filters.Add(new FileDialogFilter { Name = "Text Files", Extensions = { "txt" } });
        var selectedFile = await openFileDialog.ShowAsync(this);
        Console.WriteLine("ESTOY EN ESTA FUNCION");
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