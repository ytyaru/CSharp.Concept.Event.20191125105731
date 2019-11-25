using System;
using System.Threading.Tasks;

// 非同期イベントが正しく実行できない……
namespace Concept.Event.Lesson5 {
    class Main {
        private event EventHandler OnEdit;
        public Main() {
            OnEdit += OnEditDefault;
            /*
            OnEdit += async (object sender, EventArgs args) => {
                try {
                    await Task.Delay(2000);
                    Console.WriteLine("Edit event Lesson 5 !");
                } catch (Exception e) {
                    Console.WriteLine("ERROR: async task.");
                }
            };
            */
        }
        ~Main() {
            OnEdit -= OnEditDefault;
        }
        // Taskを返せない！ eventの仕様。
        async void OnEditDefault(object sender, EventArgs args) {
//        async OnEditDefault(object sender, EventArgs args) { // error CS0246
            try {
                await Task.Delay(2000);
                Console.WriteLine("Edit event Lesson 5 !");
            } catch (Exception e) {
                Console.WriteLine("ERROR: async task.");
            }
        }
        public void Run() {
//        public async Task Run() {
//        public async Run() { // error CS0246
//        public async Task Run() {
//            await OnEdit?.Invoke(this, EventArgs.Empty); // error CS4008: Cannot await 'void'
            OnEdit?.Invoke(this, EventArgs.Empty); // error CS4008: Cannot await 'void'
        }
    }
}
