using System.Windows.Input;
using AvaloniaApplication5.Views;
using ReactiveUI;

namespace AvaloniaApplication5.ViewModels;

public class ConsoleWindowViewModel : ViewModelBase
{
    public string Greeting => "AQUI DEBERIA APARECER LA CUESTION";
    
    private string _text = "";
    public string Text
    {
        get => _text;
        set => this.RaiseAndSetIfChanged(ref _text, value);

        //
    }
    

    public ICommand OpenFile { get; }
}