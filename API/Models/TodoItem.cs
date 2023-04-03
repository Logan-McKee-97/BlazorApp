namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Address1 {get; set; }
    public string? Town { get; set; }
    public string? PostCode { get; set; }
    
    public string? TvLicenceNum { get; set; }
    public decimal? FineAmount { get; set; }
    public string? LetterReference { get; set; }
    //public bool IsComplete { get; set; }

}