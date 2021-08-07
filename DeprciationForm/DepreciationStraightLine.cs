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

        private int lifetime;
        public int Lifetime
        { get { return lifetime; }
          set { lifetime = value; Calc();  } 
        }
        public decimal deprciationValue { get; set; }
        //uses the DateTime struct
        public DateTime Start = new();

        public DateTime End = new();
        public virtual void Calc()
        {
            //Straight Line depriciation calculations
            this.deprciationValue = (this.StartValue - this.EndValue) * (1 / this.Lifetime);
        }
        public override string ToString()
        {
            return this.Title + " start value of $" + this.StartValue + " and end value of $" + this.EndValue + " life time of " + this.Lifetime;
        }

    }
}
