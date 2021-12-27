namespace csharp_docker.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
    public bool IsCooked { get; set; }

}