public interface IService<T, TDto>
{
    void Add(TDto t);
    void Update(int id, TaskDto task);
    void Delete(int id);
    void Mark(int id, string status);
    void GetAll();
    void GetAll(string status);
}