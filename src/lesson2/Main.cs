using System;

namespace Concept.Event.Lesson2 {
    class Main {
        public event EventHandler OnEdit {
            add { onEdit += value; }
            remove { onEdit -= value; }
        }
        private event EventHandler onEdit;
        public Main() {
            OnEdit += OnEditDefault;
        }
        ~Main() {
            OnEdit -= OnEditDefault;
        }
        void OnEditDefault(object sender, EventArgs args) => Console.WriteLine("Edit event Lesson 2 !");
        public void Run() {
//            OnEdit?.Invoke(this, EventArgs.Empty); // error CS0079
            onEdit?.Invoke(this, EventArgs.Empty); // error CS0079
        }
    }
}
