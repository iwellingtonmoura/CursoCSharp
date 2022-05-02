using System;
namespace CouseAula208ExercicioFixacao.Services
{
    public interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
