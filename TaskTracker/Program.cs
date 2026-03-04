using TaskDomain;
using TaskTracker;

var shouldContinue = true;
do
{
    Console.WriteLine("Welcome to TaskTracker!");

    foreach (var item in Enum.GetValues<MainMenu>())
    {
        Console.WriteLine($"{(int)item}. {item}");
    }

    Console.Write("Choose an option: ");

    int.TryParse(Console.ReadLine(), null, out int input);
    // this is a object representing our to do list
    TaskItemService taskItemService = new();
    taskItemService.PopulateInitialTaskItems();

    switch (input)
    {
        case (int)MainMenu.ListTasks:
            taskItemService.DisplayTaskItems();
            break;
        case (int)MainMenu.AddTask:

            Console.WriteLine("What is the name of the task to add?");
            var userInput = Console.ReadLine();
            if (userInput != null)
            {
                // add logic to add a task
                taskItemService.AddTask(userInput);
            }
            break;
        case (int)MainMenu.DeleteTask:
            break;
        case (int)MainMenu.UpdateTask:
            break;
        default:
            shouldContinue = false;
            break;
    }
    // make it so that the pro
} while (shouldContinue);

void AboutMeInformation()
{
    Console.WriteLine("My name is Melissa Hegney");
    Console.WriteLine("My GitHub name is Merlissa09");
    Console.WriteLine();
}