using System;

namespace Calculator
{
    public class Calculator
    {
        private readonly IMemory<double> memory;

        public Calculator(IMemory<double> memory)
        {
            this.memory = memory;
        }

        public void Sum(double a, double b)
        {
            memory.Store(a + b);
        }

        public double GetStored()
        {
            return memory.Read();
        }
    }
}
