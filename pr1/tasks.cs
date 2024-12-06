using System;

interface ITask
{
    void Perform();
}

class Task1 : ITask
{
    public void Perform()
    {
        int baseNumber = 7;
        int[] values = { 3, 11, 5 };
        int minRange = 1;
        int maxRange = 10 + baseNumber;

        Console.WriteLine("Task 1: Числа у діапазоні:");
        foreach (int value in values)
        {
            if (value >= minRange && value <= maxRange)
            {
                Console.WriteLine(value);
            }
        }
    }
}

class Task2 : ITask
{
    public void Perform()
    {
        int side1 = 3, side2 = 4, side3 = 5;

        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            int perimeter = side1 + side2 + side3;
            double semiPerimeter = perimeter / 2.0;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

            Console.WriteLine($"Task 2: Периметр трикутника: {perimeter}");
            Console.WriteLine($"Площа трикутника: {area:F2}");

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("Рівносторонній трикутник");
            else if (side1 == side2 || side2 == side3 || side1 == side3)
                Console.WriteLine("Рівнобедрений трикутник");
            else
                Console.WriteLine("Різносторонній трикутник");
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами неможливий.");
        }
    }
}

class Task3 : ITask
{
    public void Perform()
    {
        int offset = 7;
        int arrayLength = 10 + offset;
        int[] array = new int[arrayLength];
        Random random = new Random();

        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = random.Next(-100, 100);
        }

        int smallest = array[0], largest = array[0];
        foreach (int num in array)
        {
            if (num < smallest) smallest = num;
            if (num > largest) largest = num;
        }

        Console.WriteLine("Task 3: Масив:");
        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine($"Мінімум: {smallest}, Максимум: {largest}");
    }
}

class Task4 : ITask
{
    public void Perform()
    {
        int offset = 7;
        int arraySize = 10 + offset;
        int threshold = 15;
        int[] inputArray = new int[arraySize];
        Random rng = new Random();

        for (int i = 0; i < arraySize; i++)
        {
            inputArray[i] = rng.Next(-100, 100);
        }

        int[] filteredArray = Array.FindAll(inputArray, num => Math.Abs(num) > threshold);

        Console.WriteLine("Task 4: Число M: " + threshold);
        Console.WriteLine("Вихідний масив:");
        Console.WriteLine(string.Join(", ", inputArray));
        Console.WriteLine("Масив після фільтрації:");
        Console.WriteLine(string.Join(", ", filteredArray));
    }
}

class TaskManager
{
    private readonly ITask[] taskList;

    public TaskManager()
    {
        taskList = new ITask[] { new Task1(), new Task2(), new Task3(), new Task4() };
    }

    public void ExecuteAllTasks()
    {
        foreach (ITask task in taskList)
        {
            task.Perform();
            Console.WriteLine(new string('=', 30));
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();
        taskManager.ExecuteAllTasks();
    }
}
