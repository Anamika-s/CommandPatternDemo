using System;

    public class DivideCommand : Command
    {
        private SimpleCalculator _calculator;
        public DivideCommand(SimpleCalculator calculator) :
        base(calculator)
        {
            _calculator = calculator;
        }
        public override int Execute()
        {
            return _calculator.Divide();
        }
    }
