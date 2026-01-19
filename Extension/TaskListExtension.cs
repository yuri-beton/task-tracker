using System.Text.Json;
public static class TaskListExtension
{
    public static List<Task> Save(this List<Task> tasks)
    {
        using (FileStream fs = new FileStream("tasks.json", FileMode.Create))
        {
            JsonSerializer.SerializeAsync<List<Task>>(fs, tasks);
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
        }
        return tasks;
    }
}