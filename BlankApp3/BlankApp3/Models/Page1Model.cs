using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace BlankApp3.Models
{
    public class Page1Model : BindableBase
    {
        private string page1Title;

        private ObservableCollection<TestDataRow> rows;

        public string Page1Title
        {
            get => page1Title;
            set => SetProperty(ref page1Title, value);
        }

        public ObservableCollection<TestDataRow> Rows
        {
            get => rows;
            set => SetProperty(ref rows, value);
        }

        public Page1Model()
        {
            Page1Title = @"Test Page1 Title";
            Rows = new ObservableCollection<TestDataRow>()
            {
                new TestDataRow() { Property1 = @"AAA", Property2 = @"BBB", Property3 = @"CCC", Property4 = 1 },
                new TestDataRow() { Property1 = @"DDD", Property2 = @"EEE", Property3 = @"FFF", Property4 = 2 },
                new TestDataRow() { Property1 = @"GGG", Property2 = @"HHH", Property3 = @"III", Property4 = 3 },
            };
        }

        public void IncrementProperty4()
        {
            foreach (var row in Rows)
            {
                row.Property4 += 1;
            }
        }
    }
}