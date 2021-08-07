using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeprciationForm
{
    class DeprecitationDoubleDeclining : DepreciationStraightLine
    {

        public decimal depreciationValue;
    public override void Calc()
        {
            // Calculates the deprciation with the Double declining type
           decimal bgnYearVal = (2 * (1 / this.Lifetime) * this.StartValue);
            for (int i = 0; i > this.Lifetime; i++)
            {
               bgnYearVal = (2 * bgnYearVal * (1 / this.Lifetime));
            }
            this.deprciationValue = (this.StartValue - bgnYearVal);
        }
        public override string ToString()
        {
            return "Using Double Declining Depreciation: " + base.ToString();
        }
    }
}
