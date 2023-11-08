public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine();
            Console.WriteLine($"Date: {e._date} - Prompt: {e._promptText}");
            Console.WriteLine($"{e._entryText}");
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                // This is to add text to the file with the WriteLine method
                outputFile.WriteLine($"{e._date}++{e._promptText}++{e._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry newEntry2 = new Entry();
            string[] parts = line.Split("++");
            newEntry2._date = parts[0];
            newEntry2._promptText = parts[1];
            newEntry2._entryText = parts[2];
            
            _entries.Add(newEntry2);

            // Console.WriteLine(parts);
            
        }
    }
}