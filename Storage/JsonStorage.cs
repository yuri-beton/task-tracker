using System.Text.Json;

public class JsonStorage : IStorage<Task>
{
    private List<Task> tasks;
    public bool Add(Task t)
    {
        tasks = tasks.Read();
        foreach(var task in tasks)
        {
            if(task.Id == t.Id)
                return false;
        }
        tasks.Add(t);
        tasks.Save();
        return true;
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Task> GetAll()
    {
        tasks = tasks.Read();
        return tasks;
    }

    public List<Task> GetAll(string status)
    {
        throw new NotImplementedException();
    }

    public bool Mark(int id, string status)
    {
        throw new NotImplementedException();
    }

    public bool Update(int id)
    {
        throw new NotImplementedException();
    }
}