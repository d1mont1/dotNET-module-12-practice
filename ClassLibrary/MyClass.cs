using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MyClass : IPropertyChanged
    {
        private string myProperty;

        public event PropertyEventHandler PropertyChanged;

        public string MyProperty
        {
            get { return myProperty; }
            set
            {
                if (value != myProperty)
                {
                    myProperty = value;
                    OnPropertyChanged(nameof(MyProperty));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyEventArgs(propertyName));
        }
    }
}
