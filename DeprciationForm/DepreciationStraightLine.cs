using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeprciationForm
{
    class DepreciationStraightLine
    {
        public string Title { get; set; }

        private decimal startValue;
        public decimal StartValue
        {
            get { return startValue; }
            set { startValue = value; Calc(); }
        }

        private decimal endValue;
        public decimal EndValue
        {
            get { return endValue; }
            set { endValue = value; Calc(); }
        }

        private double lifetime;
        public double Lifetime
        {
            get { return lifetime; }
            set { lifetime = value; Calc(); }
        }
        public decimal deprciatedValue;
        //uses the DateTime struct
        public DateTime Start = new();

        public DateTime End = new();
        public virtual void Calc()
        {
            //Straight Line depriciation calculations
            deprciatedValue = Decimal.Multiply((startValue - endValue), Convert.ToDecimal((1 / Lifetime)));
        }
        public override string ToString()
        {
            return this.Title + " start value of $" + this.startValue + " and end value of $" + this.endValue + " life time of " + this.Lifetime;
        }

    }
}
