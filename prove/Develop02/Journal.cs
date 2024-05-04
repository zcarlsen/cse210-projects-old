using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_entries);
        }
    }

    public void LoadFromFile(string file)
    {
        string[] entries = System.IO.File.ReadAllLines(file);

        foreach (string entry in entries)
        {
            string[] parts = entry.Split("|");

            
        }
    }
}