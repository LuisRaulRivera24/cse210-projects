using System.Text.Json;

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
            // ################################### Previous method used (before JSON formatting) ###################################
            // foreach (Entry e in _entries)
            // {
            //     // This is to add text to the file with the WriteLine method
            //     outputFile.WriteLine($"{e._date}++{e._promptText}++{e._entryText}");
            // }

            // ################################### New method used (JSON formatting- exceeding requirements) ####################################
            // Since I have a public field, to serialize I needed to set "JsonSerializerOptions.IncludeFields" to true.
            // Also, I needed to set "WriteIndented" to true in order for there to be line breaks.
            var options = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
            string json = JsonSerializer.Serialize(_entries, options);
            outputFile.WriteLine(json);
        }
    }
    public void LoadFromFile(string file)
    {
        // ################################### Previous method used (before JSON formatting) ###################################
        // _entries = new List<Entry>();

        // string[] lines = System.IO.File.ReadAllLines(file);
        // foreach (string line in lines)
        // {
        //     Entry newEntry2 = new Entry();
        //     string[] parts = line.Split("++");
        //     newEntry2._date = parts[0];
        //     newEntry2._promptText = parts[1];
        //     newEntry2._entryText = parts[2];
            
        //     _entries.Add(newEntry2);

        //     // Console.WriteLine(lines);

        // }

        // ################################### New method used (JSON formatting- exceeding requirements) ####################################
        using (StreamReader inputFile = new StreamReader(file))
        {
            _entries = new List<Entry>();
            var incomingJsonList = new List<Entry>();
            string json = inputFile.ReadToEnd();
            incomingJsonList = JsonSerializer.Deserialize<List<Entry>>(json);
            if (incomingJsonList != null && incomingJsonList.Count > 0)
            {
                foreach (var individualEntry in incomingJsonList)
                {
                    Entry newEntry2 = new Entry();
                    newEntry2._date = individualEntry._date;
                    newEntry2._promptText = individualEntry._promptText;
                    newEntry2._entryText = individualEntry._entryText;
                    _entries.Add(newEntry2);
                    // Console.WriteLine(individualEntry._entryText);
                }
            }
        }
    }
}