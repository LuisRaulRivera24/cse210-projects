using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    // Here are my attributes
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<int> randomNumbersUsedList = new List<int>();

    // Here are my constructors
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        string[] newScriptureList = text.Split(" ");

        foreach (string word in newScriptureList)
        {
            Word oneWord = new Word(word);

            _words.Add(oneWord);
            // Console.WriteLine(word);
        }

            // This is to keep track of random words already chosen
            int lengthOfList = _words.Count;
            randomNumbersUsedList.AddRange(Enumerable.Range(0,lengthOfList));
    }

    // Here are my methods
    public void HideRandomWords(int numberToHide)
    {
        if (randomNumbersUsedList.Count >= 1)
        {
            for (int i = 0; i < numberToHide; i++)
            {
                Random r = new Random();
                int randomIndex = r.Next(0, randomNumbersUsedList.Count);
                int number = randomNumbersUsedList[randomIndex];
                _words[number].Hide();
                randomNumbersUsedList.Remove(number);
            }
        }
    }
    public int GetListCount()
    {
        return randomNumbersUsedList.Count;
    }
    public string GetDisplayText()
    {
        List<string> joinedList = new List<string>();
        foreach (Word word in _words)
        {
            string theWord = word.GetDisplayText();
            joinedList.Add(theWord);
        }
        string newJoinedList = string.Join(" ", joinedList);
        return $"{_reference.GetDisplayText()} {newJoinedList}";
    }
    public bool IsCompletelyHidden()
    {
        List<bool> hiddenList = new List<bool>();
        foreach (Word word in _words)
        {
            hiddenList.Add(word.IsHidden());
        }

        if (hiddenList.Contains(false))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}