using System;


    public enum CommandOption
    {
        Add, Substract, Multiply, Divide
    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator calculator = new SimpleCalculator(15, 3);
            var addCommand = new AddCommand(calculator);
            var substractCommand = new SubtractCommand(calculator);
            var multiplyCommand = new MultiplyCommand(calculator);
            var divideCommand = new DivideCommand(calculator);
            Invoker invoker = new Invoker();
            invoker.SetCommand(addCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());
            invoker.SetCommand(substractCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());
            invoker.SetCommand(multiplyCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());
            invoker.SetCommand(divideCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());
            
            


        }
    }

