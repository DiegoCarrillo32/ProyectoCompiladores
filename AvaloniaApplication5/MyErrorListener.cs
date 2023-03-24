using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using gen;

namespace AvaloniaApplication5;

public class MyErrorListener: BaseErrorListener
{


    public LinkedList<string> errorMsgs;

    public MyErrorListener ( )
    {
        errorMsgs = new LinkedList<string>();
    }

    public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine,
        string msg, RecognitionException e)
    {
        if (recognizer.GetType() == typeof(MiniCParser))
        {
            errorMsgs.AddFirst(new String("ERROR DE PARSER - Linea "+line+":"+charPositionInLine + " " + msg));
        } 
        else if (recognizer.GetType() == typeof(MiniCScanner))
        {
            
            errorMsgs.AddFirst(new String("ERROR DE SCANNER - Linea "+line+":"+charPositionInLine + " " + msg ));
        }
        else
        {
            errorMsgs.AddFirst(new String("Error excluyente"));
        }
    }
    
    public bool hasErrors ( )
    {
     
        return errorMsgs.Count > 0;
    }

    public override string ToString()
    {
        if ( !hasErrors() ) return "0 errors";
        StringBuilder builder = new StringBuilder();
        foreach (var variable in errorMsgs)
        {
            Console.WriteLine(variable);
            //builder.Append(string.Format("%s\n", variable));
        }
        return builder.ToString();
    }
    

}