using System.Text.Json.Serialization;

public class TodoItem 
{
[JsonPropertyName("id")]
public long Id { get; set; }
[JsonPropertyName("name")]
public string? Name { get; set; }
[JsonPropertyName("isCompleted")]


//Dylans Comment
public bool IsComplete { get; set; } = false;
}