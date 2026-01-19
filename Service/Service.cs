using System.Net.NetworkInformation;

public class Service : IService<Task, TaskDto>
{
    private IStorage<Task, TaskDto> storage;
    public Service(IStorage<Task, TaskDto> storage)
    {
        this.storage = storage;
    }
    public void Add(TaskDto task)
    {
        //To-do: validation for status
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
            Console.WriteLine($"Запись {id} успешно удалена");
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
            Console.WriteLine($"Status: {task.Status}");
            Console.WriteLine($"Created at: {task.CreatedAt}");
            Console.WriteLine($"Updated at: {task.UpdatedAt}");
            Console.WriteLine();
        }
    }

    public void GetAll(string status)
    {
        //To-do: validation for incorrect status
        var tasks = storage.GetAll(status);
        if(tasks.Count == 0)
        {
            Console.WriteLine("Заданий нет");
            return;
        }
        foreach(var task in tasks)
        {
            Console.WriteLine($"ID: {task.Id}");
            Console.WriteLine($"Description: {task.Description}");
            Console.WriteLine($"Status: {task.Status}");
            Console.WriteLine($"Created at: {task.CreatedAt}");
            Console.WriteLine($"Updated at: {task.UpdatedAt}");
            Console.WriteLine();
        }
    }

    public void Mark(int id, string status)
    {
        //To-do валидация на корректный статус
        if(storage.Mark(id, status))
        {
            Console.WriteLine($"Запись {id} успешно обновлена");
            return;
        }
        Console.WriteLine("Записи с таким id не существует!");
    }

    public void Update(int id, TaskDto task)
    {
        throw new NotImplementedException();
    }
}