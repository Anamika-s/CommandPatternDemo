using System;

 public class MultiplyCommand : Command
    {
        private SimpleCalculator _calculator;
        public MultiplyCommand(SimpleCalculator calculator) :
        base(calculator)
        {
            _calculator = calculator;
        }
        public override int Execute()
        {
            return _calculator.Multiply();
        }
    }
