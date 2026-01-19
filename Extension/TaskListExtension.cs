using System.Text.Json;
public static class TaskListExtension
{
    public static List<Task> Save(this List<Task> tasks)
    {
        using (FileStream fs = new FileStream("tasks.json", FileMode.OpenOrCreate))
        {
            JsonSerializer.SerializeAsync<List<Task>>(fs, tasks);
            Console.WriteLine("Data has been saved to file");
        }
        return tasks;
    }
    public static List<Task> Read(this List<Task> tasks)
    {
        using (FileStream fs = new FileStream("tasks.json", FileMode.OpenOrCreate))
        {
            if(fs.Length == 0)
                return new List<Task>();
            tasks = JsonSerializer.Deserialize<List<Task>>(fs);
            Console.WriteLine("Data has been readed");
        }
        return tasks;
    }
}