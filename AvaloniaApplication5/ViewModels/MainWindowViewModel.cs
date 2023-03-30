using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Interactivity;
using ReactiveUI;

namespace AvaloniaApplication5.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _filePath1 = " ";
    private string _filePath2 = " ";
    private string _filePath3 = " ";

    public string FilePath
    {
        get => _filePath1;
        set => this.RaiseAndSetIfChanged(ref _filePath1, value);
    }
    public string FilePath2
    {
        get => _filePath2;
        set => this.RaiseAndSetIfChanged(ref _filePath2, value);
    }
    public string FilePath3
    {
        get => _filePath3;
        set => this.RaiseAndSetIfChanged(ref _filePath3, value);
    }
    
    public ICommand OpenFile { get; }
}