using System.Runtime.CompilerServices;

public class Entry {
    public string response;
    public string prompt;
    public string date;

    public string StringSave (){
        return response + "|" +  prompt + "|" + date;
    }

   
    public Entry(string x, string n, string v)
    {
        response = x;
        prompt = n;
        date = v;
    }
    public static List<string> Prompts = new()
    {
        // create entry from dtring
        // get entry from string
        // get user input
        
    };

        public string Getprompt()
        {
            return "";
        }
        // print entries in a string
}

// public string Response