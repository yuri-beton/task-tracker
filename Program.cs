using System.Data;

class Program
{
    public static void Main(string[] args)
    {
        var task = new TaskDto()
        {
            Description = "blabla", Status = "ready"
        };
        var jsonStorage = new JsonStorage();
        var service = new Service(jsonStorage);

        // service.Add(task);
        // service.Add(task);

        // service.Delete(1);

        service.GetAll("ready");
    }
}
