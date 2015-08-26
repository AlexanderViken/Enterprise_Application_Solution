using $ext_safeprojectname$.CrossCutting.ValueConverters;
namespace $ext_safeprojectname$.$safeprojectname$.Values
{
    public class Money
    {
        private decimal _value { get; set; }

        public Money(decimal value = 0.0M)
        {
            _value = value;
        }

        public decimal Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (_value == value)
                    return;

                _value = value;
            }
        }

        public override string ToString()
        {
            return CurrencyConverter.DecimalToCurrencyString(this.Value);
        }


        #region Implicit Conversion

        public static implicit operator Money(decimal value)
        {
            return new Money(value);
        }

        public static implicit operator decimal(Money money)
        {
            return money.Value;
        }

        #endregion
    }
}
