using System;
using System.IO;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Interactivity;
using ReactiveUI;

namespace AvaloniaApplication5.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    private string _filePath = " ";

    public string FilePath
    {
        get => _filePath;
        set => this.RaiseAndSetIfChanged(ref _filePath, value);
    }

    public ICommand OpenFile { get; }
}