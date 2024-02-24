using System.ComponentModel.Design;
using System.IO;

public class Journal 
{
    //Entry
    public string menu;
    public List<Entry> entry_list;
   // public Entry entry;

    public Journal()
    {
        entry_list = new List <Entry>();
    }

    //public Journal(string import)
    //{

    //}

    public void AddEntry(Entry entry)
    {
        entry_list.Add(entry);
    }
    public void Display()
    {
        foreach(Entry e in entry_list)
        {
            Console.WriteLine(e.StringSave());
        };

    }

    

    // public string Export(Journal journal)
    // {

    //     string fileName = "myFile.txt";

    // using (StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //     for 
    // // You can add text to the file with the WriteLine method
    //     outputFile.WriteLine("{}");
    
    // // You can use the $ and include variables just like with Console.WriteLine
    //     string filename = "Blue";
    //     outputFile.WriteLine($"My favorite color is {color}");
    //     }

    // }

    public void StringSave()
    {
        //string 
        string HoldString = "";
        foreach (Entry e in entry_list){
            HoldString += e.StringSave() + "\n";      
        }
        File.WriteAllText(HoldString, "output.txt");
//        return HoldString;
        // Turn a string into a file and save it
    }

    public void StringLoad()
    {
        System.IO.StreamReader file = new System.IO.StreamReader("c:\\output.txt");
        string line;
        string[] enter = new string[3];
        while((line = file.ReadLine()) != null)
        {
            enter = line.Split('|');

            AddEntry(new Entry(enter[0], enter[1], enter[2]));

        }
    }
}