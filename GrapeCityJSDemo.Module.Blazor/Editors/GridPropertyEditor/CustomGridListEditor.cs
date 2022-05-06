using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeCityJSDemo.Module.Blazor.Editors.GridPropertyEditor
{
    [PropertyEditor(typeof(object), "CustomGridPE", false)]
    public class CustomGridListEditor : BlazorPropertyEditorBase
    {
        public CustomGridListEditor(Type objectType, IModelMemberViewItem info)
          : base(objectType, info)
        {
            
        }
        protected override IComponentAdapter CreateComponentAdapter() => new CustomGridAdapter(new CustomGridModel());
    }
}
