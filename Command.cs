using System;

 public abstract class Command
    {
        protected SimpleCalculator receiver;
        public Command(SimpleCalculator receiver)
        {
            this.receiver = receiver;
        }
        public abstract int Execute();
    }

