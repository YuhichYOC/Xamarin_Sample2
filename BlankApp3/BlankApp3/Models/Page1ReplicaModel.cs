using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace BlankApp3.Models
{
    public class Page1ReplicaModel : BindableBase
    {
        private string message;

        public string Message
        {
            get => message;
            set => SetProperty(ref message, value, BypassMessage);
        }

        public delegate void BypassDelegate(string arg);

        public BypassDelegate Bypass { get; set; }

        public void BypassMessage()
        {
            if (Bypass == null) return;
            Bypass(Message);
        }

        public void CopyToMessage(string arg)
        {
            Message = arg;
        }
    }
}
