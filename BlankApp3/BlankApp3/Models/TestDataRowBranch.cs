using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace BlankApp3.Models
{
    public class TestDataRowBranch : BindableBase
    {
        private string testValue;

        public string TestValue
        {
            get => testValue;
            set => SetProperty(ref testValue, value, CopyValueToParent);
        }

        public Page1BranchModel Parent { get; }

        public TestDataRowBranch(Page1BranchModel arg)
        {
            Parent = arg;
            TestValue = string.Empty;
        }

        private void CopyValueToParent()
        {
            Parent.Message = TestValue;
        }
    }
}
