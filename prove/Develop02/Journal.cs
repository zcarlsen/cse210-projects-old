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
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._entryText}|{entry._promptText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] entries = System.IO.File.ReadAllLines(file);

        foreach (string entry in entries)
        {
            Entry newEntry = new Entry();
            string[] parts = entry.Split("|");

            newEntry._date = parts[0];
            newEntry._entryText = parts[1];
            newEntry._promptText = parts[2];

            _entries.Add(newEntry);
        }
    }
}