using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace BlankApp3.Models
{
    public class Page1Model : BindableBase
    {
        private string page1Title;

        private ObservableCollection<TestDataRow> rows;

        private string message;

        private string testMessage;

        private Page1BranchModel branch;

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

        public string Message
        {
            get => message;
            set => SetProperty(ref message, value);
        }

        public string TestMessage
        {
            get => testMessage;
            set => SetProperty(ref testMessage, value);
        }

        public Page1Model()
        {
            branch = new Page1BranchModel(this);
            Page1Title = @"Test Page1 Title";

            Rows = new ObservableCollection<TestDataRow>();
            TestDataRowBranch addBranch;
            TestDataRow add;
            addBranch = new TestDataRowBranch(branch);
            add = new TestDataRow(addBranch) { Property1 = @"AAA", Property2 = @"BBB", Property3 = @"CCC", Property4 = 1 };
            Rows.Add(add);
            addBranch = new TestDataRowBranch(branch);
            add = new TestDataRow(addBranch) { Property1 = @"DDD", Property2 = @"EEE", Property3 = @"FFF", Property4 = 2 };
            Rows.Add(add);
            addBranch = new TestDataRowBranch(branch);
            add = new TestDataRow(addBranch) { Property1 = @"GGG", Property2 = @"HHH", Property3 = @"III", Property4 = 3 };
            Rows.Add(add);

            Message = string.Empty;
            TestMessage = string.Empty;
        }

        public void IncrementProperty4()
        {
            foreach (var row in Rows)
            {
                row.Property4 += 1;
            }
        }

        public void ValueCheck()
        {
            var r1p1 = Rows[0].Property1;
            if (Rows[0].Property2 == r1p1)
            {
                Message = @"Row1.Property1 is same as Row1.Property2";
                return;
            }
            if (Rows[0].Property3 == r1p1)
            {
                Message = @"Row1.Property1 is same as Row1.Property3";
                return;
            }
            if (Rows[1].Property1 == r1p1)
            {
                Message = @"Row1.Property1 is same as Row2.Property1";
                return;
            }
            if (Rows[1].Property2 == r1p1)
            {
                Message = @"Row1.Property1 is same as Row2.Property2";
                return;
            }
            if (Rows[1].Property3 == r1p1)
            {
                Message = @"Row1.Property1 is same as Row2.Property3";
                return;
            }
            if (Rows[2].Property1 == r1p1)
            {
                Message = @"Row1.Property1 is same as Row3.Property1";
                return;
            }
            if (Rows[2].Property2 == r1p1)
            {
                Message = @"Row1.Property1 is same as Row3.Property2";
                return;
            }
            if (Rows[2].Property3 == r1p1)
            {
                Message = @"Row1.Property1 is same as Row3.Property3";
                return;
            }
            Message = string.Empty;
        }
    }
}