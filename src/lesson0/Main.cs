using System;

namespace Concept.Event.Lesson0 {
    class Main {
        private event EventHandler OnEdit;
        public Main() {
            OnEdit += OnEditDefault;
        }
        ~Main() {
            OnEdit -= OnEditDefault;
        }
        void OnEditDefault(object sender, EventArgs args) => Console.WriteLine("Edit event !");
        public void Run() {
            OnEdit?.Invoke(this, EventArgs.Empty);
        }
    }
}
