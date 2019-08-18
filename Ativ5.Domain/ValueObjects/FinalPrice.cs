namespace Ativ5.Domain.ValueObjects
{
    public class FinalPrice
    {
        public double Value { get; private set; }

        public FinalPrice(double value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator FinalPrice(double value)
        {
            return new FinalPrice(value);
        }

        public static FinalPrice operator +(FinalPrice amount1, FinalPrice amount2)
        {
            return new FinalPrice(amount1.Value + amount2.Value);
        }

        public static FinalPrice operator -(FinalPrice amount1, FinalPrice amount2)
        {
            return new FinalPrice(amount1.Value - amount2.Value);
        }

        public static bool operator <(FinalPrice amount1, FinalPrice amount2)
        {
            return amount1.Value < amount2.Value;
        }

        public static bool operator >(FinalPrice amount1, FinalPrice amount2)
        {
            return amount1.Value > amount2.Value;
        }

        public static bool operator <=(FinalPrice amount1, FinalPrice amount2)
        {
            return amount1.Value <= amount2.Value;
        }

        public static bool operator >=(FinalPrice amount1, FinalPrice amount2)
        {
            return amount1.Value >= amount2.Value;
        }
    }
}
