using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeprciationForm
{
    class DeprecitationDoubleDeclining : DepreciationStraightLine
    {
        public override void Calc()
        {
            // Calculates the deprciation with the Double declining type
            decimal bgnYearVal = Decimal.Multiply(Convert.ToDecimal((1 / Lifetime)), (2 * StartValue));
            for (int i = 0; i > Lifetime; i++)
            {
                bgnYearVal = Decimal.Multiply((2 * bgnYearVal), Convert.ToDecimal((1 / Lifetime)));
            }
            deprciatedValue = (StartValue - bgnYearVal);
        }
        public override string ToString()
        {
            return "Using Double Declining Depreciation: " + base.ToString();
        }
    }
}
