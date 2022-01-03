using System;

    public class Invoker
    {
        private Command _command;
        public void SetCommand(Command command)
        {
            _command = command;
        }
        public int Execute()
        {
            return _command.Execute();
        }
    }
