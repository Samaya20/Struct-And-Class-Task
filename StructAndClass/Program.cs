using System;

namespace ConsoleApp2
{
    internal class Counter
    {
        private int current = 0;
        private int min;
        private int max;

        public int Min
        {
            get { return min; }
            set { min = value; }
        }

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public Counter()
        {
            min = 0;
            max = 0;
        }

        public Counter(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public void Increment()
        {
            if (current < max)
            {
                current++;
            }
            else
            {
                current = min;
            }
        }

        public void Decrement()
        {
            if (current > min)
            {
                current--;
            }
            else
            {
                current = max;
            }
        }

        public int GetCurrent()
        {
            return current;
        }
    }
}
