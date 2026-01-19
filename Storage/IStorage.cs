public interface IStorage<T>
{
    bool Add(T t);
    bool Update(int id);
    bool Delete(int id);
    bool Mark(int id, string status);
    List<T> GetAll();
    List<T> GetAll(string status);
}