using System.Data;

class Program
{
    public static void Main(string[] args)
    {
        var task = new Task()
        {
            Id = 2, Description = "blabla", Status = "ready"
        };
        var jsonStorage = new JsonStorage();
        jsonStorage.Add(task);
    }
}
