using System.Text.Json;

public class JsonStorage : IStorage<Task, TaskDto>
{
    private List<Task> tasks;
    public bool Add(TaskDto t)
    {
        int maxId = 0;
        tasks = tasks.Read();
        foreach(var task in tasks)
        {
            if(task.Id > maxId)
                maxId = task.Id;
        }
        var newTask = new Task()
        {
            Id = maxId + 1,
            Description = t.Description,
            Status = t.Status,
            CreatedAt = t.CreatedAt,
            UpdatedAt = t.UpdatedAt
        };
        tasks.Add(newTask);
        tasks.Save();
        return true;
    }

    public bool Delete(int id)
    {
        tasks = tasks.Read();
        var newTask = tasks.Where(x => x.Id != id).ToList();
        if(tasks.Count == newTask.Count)
            return false;
        newTask.Save();
        return true;
    }

    public List<Task> GetAll()
    {
        tasks = tasks.Read();
        return tasks;
    }

    public List<Task> GetAll(string status)
    {
        tasks = tasks.Read();
        return tasks.Where(task => task.Status == status).ToList();
    }

    public bool Mark(int id, string status)
    {
        tasks = tasks.Read();
        for(int i = 0; i < tasks.Count; i++)
        {
            if(tasks[i].Id == id)
            {
                tasks[i].Status = status;
                tasks.Save();
                return true;
            }
        }
        return false;
    }

    public bool Update(int id, TaskDto task)
    {
        throw new NotImplementedException();
    }
}