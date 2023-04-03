using System.Text.Json.Serialization;

public class TodoItem 
{
[JsonPropertyName("id")]
public long Id { get; set; }
[JsonPropertyName("Name")]
public string? Name { get; set; }
[JsonPropertyName("Address1")]
public string? Address1 {get; set; }

[JsonPropertyName("Town")]
public string? Town { get; set; }

[JsonPropertyName("PostCode")]
public string? PostCode { get; set; }

[JsonPropertyName("TVLicenceNum")]
public string? TvLicenceNum { get; set; }

[JsonPropertyName("FineAmount")]
public decimal? FineAmount { get; set; }

[JsonPropertyName("FineAmount")]
public string? FineAmount { get; set; }

}