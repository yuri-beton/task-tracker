public interface IStorage<T, TDto>
{
    bool Add(TDto t);
    bool Update(int id);
    bool Delete(int id);
    bool Mark(int id, string status);
    List<T> GetAll();
    List<T> GetAll(string status);
}