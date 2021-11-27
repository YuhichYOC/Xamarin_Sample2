using BlankApp3.Models;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System.Threading.Tasks;

namespace BlankApp3.ViewModels
{
    public class Page1ViewModel
    {
        private Page1Model model;

        public ReactiveProperty<string> Page1Title { get; set; } = new ReactiveProperty<string>();

        public ReactiveCollection<Page1Row> Rows { get; set; } = new ReactiveCollection<Page1Row>();

        public ReactiveProperty<string> Message { get; set; } = new ReactiveProperty<string>();

        public ReadOnlyReactiveProperty<string> TestMessage { get; }

        public AsyncReactiveCommand IncrementProperty4 => new AsyncReactiveCommand().WithSubscribe(() =>
        {
            model.IncrementProperty4();
            return Task.CompletedTask;
        });

        public AsyncReactiveCommand ValueCheck => new AsyncReactiveCommand().WithSubscribe(() =>
        {
            model.ValueCheck();
            return Task.CompletedTask;
        });

        public Page1ViewModel()
        {
            model = new Page1Model();

            Page1Title = model.ObserveProperty(model => model.Page1Title).ToReactiveProperty();
            var rows = model.ObserveProperty(model => model.Rows).ToReactiveProperty();
            foreach (var row in rows.Value)
            {
                Rows.Add(new Page1Row()
                {
                    Property1 = row.ToReactivePropertyAsSynchronized(r => r.Property1),
                    Property2 = row.ToReactivePropertyAsSynchronized(r => r.Property2),
                    Property3 = row.ToReactivePropertyAsSynchronized(r => r.Property3),
                    Property4 = row.ToReactivePropertyAsSynchronized(r => r.Property4),
                });
            }
            Message = model.ObserveProperty(model => model.Message).ToReactiveProperty();
            TestMessage = model.ObserveProperty(model => model.TestMessage).ToReadOnlyReactiveProperty();
        }
    }
}