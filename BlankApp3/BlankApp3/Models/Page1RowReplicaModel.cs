using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace BlankApp3.Models
{
    public class Page1RowReplicaModel : BindableBase
    {
        private string property1;

        public string Property1
        {
            get => property1;
            set => SetProperty(ref property1, value, BypassProp1);
        }

        public delegate void BypassDelegate(string arg);

        public BypassDelegate Bypass { get; set; }

        public void BypassProp1()
        {
            if (Bypass == null) return;
            Bypass(Property1);
        }

        public void CopyToProp1(string arg)
        {
            Property1 = arg;
        }
    }
}
