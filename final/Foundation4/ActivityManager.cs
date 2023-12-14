public class ActivityManager
{
    private List<Activity> _activityList;

    public ActivityManager()
    {
        _activityList = new List<Activity>();
    
        Running running = new Running("03 Nov 2022", 30, 3.0);
        Cycling cycling = new Cycling("05 Mar 2023", 240, 100);
        Swimming swimming = new Swimming("14 Jul 2023", 60, 30);

        _activityList.Add(running);
        _activityList.Add(cycling);
        _activityList.Add(swimming);

        DisplaySummaries();
    }

    private void DisplaySummaries()
    {
        foreach (Activity activity in _activityList)
        {
            activity.GetSummary();
        }
    }
}