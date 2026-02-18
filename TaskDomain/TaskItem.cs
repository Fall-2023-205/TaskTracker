namespace TaskTracker.TaskDomain;

/// <summary>
/// This class is a template/blueprint for our todo items
/// </summary>
public class TaskItem
{
    // static property
    // static properties belong to the class itself - they are shared between objects
    private static int _totalCount = 0;

    public static int TotalCount
    {
        get => _totalCount;
    }

    // constructor builds/constructs the object/instance
    public TaskItem()
    {
        ++_totalCount;
    }

    // Instance properties
    // Instance properties belong to the object
    public int Id;
    public string Title = string.Empty;
    public bool IsComplete = false;
}