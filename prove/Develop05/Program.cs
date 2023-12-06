using System;

// To exceed requirements, I was able to save my files in the JSON format by serializing. This was really cool and I even learned how to
// sort the member variables in the order I want in the JSON formatted file.
// However, I learned that to deserialize a JSON file, unless you create your own custom JSON converter,
// there is no way to deserialize polymorphic types. Saving files to the JSON format is commented out in my code.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}