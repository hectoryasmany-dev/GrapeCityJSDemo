using DevExpress.ExpressApp.Blazor.Components.Models;
using GrapeCityJSDemo.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace GrapeCityJSDemo.Module.Blazor.Editors.GridPropertyEditor
{
    public class CustomGridModel : ComponentModelBase
    {
        //it could be xpcollection<object> in order to make it generico
        public XPCollection<Invoice> Value
        {
            get => GetPropertyValue<XPCollection<Invoice>>();
            set => SetPropertyValue(value);
        }
        public bool ReadOnly
        {
            get => GetPropertyValue<bool>();
            set => SetPropertyValue(value);
        }
        // ...
        public void SetValueFromUI(string value)
        {
            SetPropertyValue(value, notify: false, nameof(Value));
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler ValueChanged;
    }
}
