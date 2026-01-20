using System.Data;

class Program
{
    public static void Main(string[] args)
    {
        var jsonStorage = new JsonStorage();
        var service = new Service(jsonStorage);

        try
        {
            switch(args[0].ToLower())
            {
                case "add":
                    service.Add(new TaskDto() {
                        Description = args[1], 
                        Status = "todo", 
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now}); 
                    break;
                case "update":
                    service.Update(int.Parse(args[1]), args[2]);
                    break;
                case "delete":
                    service.Delete(int.Parse(args[1]));
                    break;
                case "mark-in-progress":
                    service.Mark(int.Parse(args[1]), "in-progress");
                    break;
                case "mark-done":
                    service.Mark(int.Parse(args[1]), "done");
                    break;
                case "list":
                    if(args.Length == 1)
                        service.GetAll();
                    else
                        service.GetAll(args[1]);
                    break;
                default:
                    Console.WriteLine("This command doesn't exist");
                    break;
                
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
