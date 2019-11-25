using System;

namespace Concept.Event.Lesson1 {
    class Main {
        private event EventHandler<EditEventArgs> OnEdit;
        public Main() {
            OnEdit += OnEditDefault;
        }
        ~Main() {
            OnEdit -= OnEditDefault;
        }
        void OnEditDefault(object sender, EditEventArgs args) => Console.WriteLine($"Edit event !: {args.Path}");
        public void Run() {
            OnEdit?.Invoke(this, new EditEventArgs("test.txt"));
        }
    }
    class EditEventArgs : EventArgs {
        public string Path { get; }
        public EditEventArgs(string path) => Path = path;
    }
}
