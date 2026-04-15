using StudentAPI.Models;

namespace StudentAPI.Services;

public interface IStudentService
{
    Task<List<Student>> GetAll();
    Task<Student?> GetById(int id);
    Task Add(Student student);
    Task Update(Student student);
    Task Delete(int id);
}