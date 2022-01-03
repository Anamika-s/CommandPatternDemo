using System;

public class SimpleCalculator
    {
        private int _x, _y;
        public SimpleCalculator(int a, int b)
        {
            _x = a;
            _y = b;
        }
        public int Add()
        {
            return _x + _y;
        }
        public int Subtract()
        {
            return _x - _y;
        }
        public int Multiply()
        {
            return _x * _y;
        }
        public int Divide()
        {
            return _x / _y;
        }
    }
