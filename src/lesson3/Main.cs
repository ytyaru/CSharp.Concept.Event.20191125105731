using System;

namespace Concept.Event.Lesson3 {
    class Main {
        private Func<string> GetFunc { get; set; }
        private Func<int, string> GetMessageFunc { get; set; }

        public void Run() {
            GetFunc = Get;
            GetMessageFunc = GetMessage;
            Console.WriteLine($"{GetFunc()}");
            Console.WriteLine($"{GetMessageFunc(100)}");
        }
        private string Get() => "Hello world !! Lesson 3.";
        private string GetMessage(int value) => $"value is {value}.";
    }
}
