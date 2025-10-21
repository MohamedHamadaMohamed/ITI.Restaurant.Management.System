namespace RMS.Domain.Constants
{
    public record OrderStatus(string Value)
    {
        public static readonly OrderStatus Pending = new("Pending");
        public static readonly OrderStatus Approved = new("Approved");
        public static readonly OrderStatus Shipped = new("Shipped");
        public static readonly OrderStatus Cancelled = new("Cancelled");

        public override string ToString() => Value;
        
    }
}
