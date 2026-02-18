using TaskTracker.TaskDomain;

var shouldContinue = true;
do
{
    Console.WriteLine("Welcome to TaskTracker!");
    Console.WriteLine("1. List Tasks");
    Console.WriteLine("2. About");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");

    int.TryParse(Console.ReadLine(), null, out int input);


    switch (input)
    {
        case 1:
            // list the tasks
            // TODO: add a project reference by turning the Domain into a Class Library
            TaskItem taskOne = new();
            taskOne.Title = "Clean the chicken coop";
            TaskItem taskTwo = new();
            taskTwo.Title = "Finish convert px to rem";
            TaskItem taskThree = new();
            taskThree.Title = "Grade Week 3 Labs";

            List<TaskItem> taskItems = [];
            taskItems.Add(taskOne);
            taskItems.Add(taskTwo);
            taskItems.Add(taskThree);

            foreach(var item in taskItems)
            {
                Console.WriteLine($"{item.Id}: {item.Title}");
            }

            Console.WriteLine(taskItems);
            Console.WriteLine(TaskItem.TotalCount);

            break;
        case 2:
    // dotnet restore
    // dotnet build
            break;
        case 3:
            shouldContinue = false;
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