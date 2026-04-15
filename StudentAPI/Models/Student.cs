namespace StudentAPI.Models;

public class Student
{
    public int Id { get; set; } // Auto Increment
    public string Name { get; set; }=string.Empty;
    public string Email { get; set; }= string.Empty;
    public int Age { get; set; }=int.MinValue;
    public string Course { get; set; }=String.Empty;

    public DateTime CreatedDate { get; set; } = DateTime.Now; // Auto generated
}