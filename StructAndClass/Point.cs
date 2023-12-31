﻿using System;

namespace ConsoleApp2
{
    internal class Pointer
    {
        private int x;
        private int y;

        public Pointer()
        {
            x = 0;
            y = 0;
        }

        public Pointer(int num1, int num2)
        {
            x = num1;
            y = num2;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public void ShowData()
        {
            Console.WriteLine($"x={x} ve y={y}");
        }

        public override string ToString()
        {
            return $"x={x} ve y={y}";
        }
    }
}
