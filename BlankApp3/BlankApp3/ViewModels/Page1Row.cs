using Reactive.Bindings;

namespace BlankApp3.ViewModels
{
    public class Page1Row
    {
        public ReactiveProperty<string> Property1 { get; set; } = new ReactiveProperty<string>();

        public ReactiveProperty<string> Property2 { get; set; } = new ReactiveProperty<string>();

        public ReactiveProperty<string> Property3 { get; set; } = new ReactiveProperty<string>();

        public ReactiveProperty<int> Property4 { get; set; } = new ReactiveProperty<int>();
    }
}