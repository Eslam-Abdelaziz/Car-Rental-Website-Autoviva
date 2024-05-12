using CarRental.Data.Abstracts;

namespace CarRental.Application.Extenstions
{
    public static class EnumExtenstions
    {
        public static string ToFriendlyName(this PaymentStatus payment)
        {
            switch (payment)
            {
                case  PaymentStatus.NotPaid:
                    return "Not Paid";
                default:
                    return payment.ToString();
            }
        }
        public static string ToFriendlyName(this PaymentType type)
        {
            switch (type)
            {
                case PaymentType.CashOnDelivery:
                    return "Cash On Delivery";
                case PaymentType.CreditCard:
                    return "Credit Card";
                default:
                    return type.ToString();
            }
        }
    }
}
