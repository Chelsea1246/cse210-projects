using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._responseText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._responseText = parts[2];

            _entries.Add(entry);
        }
    }
}