using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);

    public interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }
}
