namespace DevFreela.Payments.Api.Models
{
  public class PaymentInfoInputModel
  {
    public int IdProject { get; set; }
    public string CreditCardNumber { get; set; }
    public string Cvv { get; set; }
    public string ExpiresAt { get; set; }
    public string FullName { get; set; }
    public decimal Amount { get; set; }


  }
}