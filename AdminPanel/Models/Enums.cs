namespace AdminPanel.Models
{
    public enum CarSize
    {
        Sedan,
        SUV,
        Hatchback,
        u4x4,
        Coupe
    }
    public enum RentalStatus
    {
        Processed,
        Confirmed,
        Rejected,
        Cancelled,
        Received,
        Returned,
    }

    public enum PaymentType
    {
        CreditCard,
        CashOnDelivery
    }
    public enum PaymentStatus
    {
        Paid,
        NotPaid,
        Refunded
    }
}
