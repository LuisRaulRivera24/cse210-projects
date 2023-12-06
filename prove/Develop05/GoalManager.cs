using System.Text.Json;
using System.IO; 
public class GoalManager
{
    private List<Goal> _goals {get; set;}
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        Console.Clear();
    }

    public void Start()
    {
        string quit = "not quit";
        while (quit != "quit")
        {
            Console.WriteLine();
            DisplayPlayerInfo();

            Console.Write("""
            Menu Options:
                1. Create New Goal
                2. List Goals
                3. Save Goals
                4. Load Goals
                5. Record Event
                6. Quit
            Select a choice from the menu: 
            """);

            int menuOption = int.Parse(Console.ReadLine());

            if (menuOption == 1)
            {
                CreateGoal();
            }
            else if (menuOption == 2)
            {
                Console.WriteLine("The goals are:");
                
                if (!_goals.Any())
                {
                    Console.WriteLine();
                }
                else
                {
                    GetStringRepresentation();
                }
            }
            else if (menuOption == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string goalFile = Console.ReadLine();
                SaveGoals(goalFile);
            }
            else if (menuOption == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string goalFile = Console.ReadLine();
                LoadGoals(goalFile);
            }
            else if (menuOption == 5)
            {
                ListGoals();
                Console.Write("Which goal did you accomplish? ");
                int indexPlusOne = int.Parse(Console.ReadLine());
                int actualIndex = _goals.IndexOf(_goals[indexPlusOne - 1]);
                int pointsEarned = RecordEvent(actualIndex);
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {pointsEarned} points.");
            }
            else if (menuOption == 6)
            {
                quit = "quit";
            }
        }
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }
    private void ListGoals()
    {
        foreach (Goal goal in _goals)
        {
            int index = _goals.IndexOf(goal);
            Console.WriteLine($"{index + 1}. {goal._shortName}");
        }
    }
    private void CreateGoal()
    {
        Console.Write("""
        The types of Goals are:
            1. Simple Goal
            2. Eternal Goal
            3. Checklist Goal
        Which type of goal would you like to create? 
        """);

        int goalType = int.Parse(Console.ReadLine());

        if (goalType == 1 || goalType == 2 || goalType == 3)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            bool isCompleted = false;

            if (goalType == 1)
            {
                SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points, isCompleted);

                _goals.Add(simpleGoal);
            }
            else if (goalType == 2)
            {
                EternalGoal eternalGoal = new EternalGoal(goalName, description, points);

                _goals.Add(eternalGoal);
            }
            else if (goalType == 3)
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                int amountCompleted = 0;

                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, points, target, bonus, amountCompleted);

                _goals.Add(checklistGoal);
            }
        }
    }
    private int RecordEvent(int index)
    {
       int points = _goals[index].RecordEvent();
       _score += points;
       return points;
    }
    private void SaveGoals(string file)
    {        
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // // This is how I save the file in the JSON format. This was really cool and I even learned how to
            // // sort the member variables in the order I want in the JSON formatted file.
            // // However, I learned that to deserialize a JSON file, unless you create your own custom JSON converter,
            // // there is no way to deserialize polymorphic types.

            // // The serialization is how I exceeded requirements. However, I commented it out because I can't load a JSON formatted file,
            // // which in turn while cause an error when I try loading the document.

            // var options = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
            // string json = JsonSerializer.Serialize<List<Goal>>(_goals, options);
            // outputFile.WriteLine(json);

            // ################################################################################################################################### //

            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetOutputFormat());
            }
        }
    }

    private void LoadGoals(string file)
    {
        _goals = new List<Goal>();
        // string inputFile = file;
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            
            if (parts[0] == "SimpleGoal")
            {
                string classType = parts[0];
                string restOfGoal = parts[1];
                CreateGoals(classType, restOfGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                string classType = parts[0];
                string restOfGoal = parts[1];
                CreateGoals(classType, restOfGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string classType = parts[0];
                string restOfGoal = parts[1];
                CreateGoals(classType, restOfGoal);
            }
            else
            {
                _score = int.Parse(parts[0]);
            }
        }
        
    }

    private void CreateGoals(string name, string restOfGoal)
    {
        string[] parts = restOfGoal.Split("++");

        if (name == "SimpleGoal")
        {
            string shortName = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            bool completedOrNot = Convert.ToBoolean(parts[3]);

            SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points, completedOrNot);
            _goals.Add(simpleGoal);
        }
        else if (name == "EternalGoal")
        {
            string shortName = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);

            EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
            _goals.Add(eternalGoal);
        }
        else if (name == "ChecklistGoal")
        {
            string shortName = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            int bonus = int.Parse(parts[3]);
            int target = int.Parse(parts[4]);
            int amountCompleted  = int.Parse(parts[5]);

            ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, target, bonus, amountCompleted);
            _goals.Add(checklistGoal);
        }
    }
    private void GetStringRepresentation()
    {
        foreach (Goal goal in _goals)
        {
            string format = goal.GetStringRepresentation();
            Console.WriteLine(format);
        }
        Console.WriteLine();
    }
}