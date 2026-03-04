namespace TaskDomain;

public class TaskItemService
{
    // instance variable - this belongs to a specific instance/object of this class
    // this is a todo list
    List<TaskItem> taskItems = [];

    public void PopulateInitialTaskItems()
    {
        TaskItem taskOne = new("Clean the chicken coop");
        TaskItem taskTwo = new("Finish convert px to rem");
        TaskItem taskThree = new("Grade Week 3 Labs");


        taskItems.Add(taskOne);
        taskItems.Add(taskTwo);
        taskItems.Add(taskThree);

    }

    public void AddTask(string title)
    {
        TaskItem taskItem = new TaskItem(title);
        taskItems.Add(taskItem);
    }

    // TODO: Move this into the UI layer - this is not the responsibility of the business logic layer
    public void DisplayTaskItems()
    {
        foreach (var item in taskItems)
        {
            Console.WriteLine($"{item.Id}: {item.Title}");
        }
    }
}