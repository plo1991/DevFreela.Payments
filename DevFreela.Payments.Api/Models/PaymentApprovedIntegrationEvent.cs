namespace DevFreela.Payments.Api.Models
{
  public class PaymentApprovedIntegrationEvent
  {
    public PaymentApprovedIntegrationEvent(int idProject)
    {
      IdProject = idProject;
    }
    public int IdProject { get; set; }
  }
}