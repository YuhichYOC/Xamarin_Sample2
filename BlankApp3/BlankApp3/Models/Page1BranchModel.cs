using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace BlankApp3.Models
{
    public class Page1BranchModel : BindableBase
    {
        private string message;

        public string Message
        {
            get => message;
            set => SetProperty(ref message, value, CopyMessageToTrunk);
        }

        public Page1Model Trunk { get; }

        public Page1BranchModel(Page1Model arg)
        {
            Trunk = arg;
            Message = string.Empty;
        }

        private void CopyMessageToTrunk()
        {
            Trunk.TestMessage = Message;
        }
    }
}
