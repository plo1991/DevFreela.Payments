using System.Threading.Tasks;
using DevFreela.Payments.Api.Models;
namespace DevFreela.Payments.Api.Service
{
  public class PaymentService : IPaymentService
  {
    public Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel)
    {
      return Task.FromResult(true);
    }
  }
}