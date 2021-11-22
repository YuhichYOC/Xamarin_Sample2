using BlankApp3.Models;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace BlankApp3.ViewModels
{
    public class Page1ViewModel
    {
        private Page1Model model;

        public ReactiveProperty<string> Page1Title { get; set; } = new ReactiveProperty<string>();

        public ReactiveCollection<Page1Row> Rows { get; set; } = new ReactiveCollection<Page1Row>();

        public Page1ViewModel()
        {
            model = new Page1Model();

            Page1Title = model.ObserveProperty(model => model.Page1Title).ToReactiveProperty();
            var rows = model.ObserveProperty(model => model.Rows).ToReactiveProperty();
            foreach (var row in rows.Value)
            {
                Rows.Add(new Page1Row()
                {
                    Property1 = row.ObserveProperty(r => r.Property1).ToReactiveProperty(),
                    Property2 = row.ObserveProperty(r => r.Property2).ToReactiveProperty(),
                    Property3 = row.ObserveProperty(r => r.Property3).ToReactiveProperty(),
                    Property4 = row.ObserveProperty(r => r.Property4).ToReactiveProperty(),
                });
            }
        }
    }
}