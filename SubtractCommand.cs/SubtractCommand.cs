using System;
    public class SubtractCommand : Command
    {
        private SimpleCalculator _calculator;
        public SubtractCommand(SimpleCalculator calculator) :
        base(calculator)
        {
            _calculator = calculator;
        }
        public override int Execute()
        {
            return _calculator.Subtract();
        }
    }
