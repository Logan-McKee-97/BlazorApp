using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class PaymentDetails 
{
[JsonPropertyName("cardNumber")]
[StringLength(16, ErrorMessage = "Invalid card number, must be 16 digits long")]
[Required]
public string? cardNumber { get; set; }

[JsonPropertyName("expDate")]
[Required]
[RegularExpression ("[0-1][0-9]/[2-9][3-9]", ErrorMessage = "Invalid must follow format XX/XX")]
public string? expDate { get; set; }

[JsonPropertyName("cvc")]
[Required]
[RegularExpression ("[0-9][0-9][0-9]", ErrorMessage = "Invalid CVC must be 3 digits long")]
public string? cvc { get; set; }

[JsonPropertyName("cardName")]
[Required]
public string? cardName { get; set; }



}