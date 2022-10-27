using System.Threading.Tasks;
using DevFreela.Payments.Api.Models;
namespace DevFreela.Payments.Api.Service
{
  public interface IPaymentService
  {
    Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel);
  }
}