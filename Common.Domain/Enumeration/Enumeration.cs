using Ardalis.SmartEnum;

namespace Common.Domain.Enumeration
{
    public abstract class Enumeration<TEnum> : SmartEnum<TEnum>
    where TEnum : SmartEnum<TEnum, int>
    {
        protected Enumeration(int value, string name)
            : base(name, value)
        {
        }
    }
}
