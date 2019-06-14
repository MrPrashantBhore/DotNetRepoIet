using System;

namespace MathLibrary
{
    public class MathCalculator
    {
        private int num1;
        private int num2;

        public MathCalculator()
        {
            this.num1 = 1;
            this.num2 = 1;
        }
        public MathCalculator(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
                
        }
        private int Number1
        {
            get { return this.num1; }
            set { this.num1 = value; }

        }
        private int Number2
        {
            get { return this.num2; }
            set { this.num2 = value; }

        }

        public int DoAdd()
        {
            return this.num1 + this.num2;
        }

        public int DoMul()
        {
            return this.num1 * this.num2;
        }

        public int SquareIT(int x)
        {
            return x * x;
        }

        public string Dispaly()
        {
            return "Oh yo see I am late binding Invocation example";
        }
    }
}
