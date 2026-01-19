public class Service : IService<Task, TaskDto>
{
    private IStorage<Task, TaskDto> storage;
    public Service(IStorage<Task, TaskDto> storage)
    {
        this.storage = storage;
    }
    public void Add(TaskDto task)
    {
        if (storage.Add(task))
        {
            Console.WriteLine("Задание успешно добавлено");
            return;
        }
        System.Console.WriteLine("Задание не удалось добавить");

    }
    public void Delete(int id)
    {
        if(storage.Delete(id))
        {
            Console.WriteLine("Запись успешно удалена");
            return;
        }
        System.Console.WriteLine("Записи с таким id не существует!");
    }

    public void GetAll()
    {
        var tasks = storage.GetAll();
        if(tasks.Count == 0)
        {
            Console.WriteLine("Заданий нет");
            return;
        }
        foreach(var task in tasks)
        {
            Console.WriteLine($"ID: {task.Id}");
            Console.WriteLine($"Description: {task.Description}");
            Console.WriteLine($"Created at: {task.CreatedAt}");
            Console.WriteLine($"Updated at: {task.UpdatedAt}");
            Console.WriteLine();
        }
    }

    public void GetAll(string status)
    {
        throw new NotImplementedException();
    }

    public void Mark(int id, string status)
    {
        throw new NotImplementedException();
    }

    public void Update(int id)
    {
        throw new NotImplementedException();
    }
}