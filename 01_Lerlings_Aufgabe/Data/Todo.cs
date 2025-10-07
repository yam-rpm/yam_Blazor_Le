using Microsoft.AspNetCore.Components;

namespace _01_Lerlings_Aufgabe.Data;
    public record Todo {
    
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool isCompleted { get; set; }
}

