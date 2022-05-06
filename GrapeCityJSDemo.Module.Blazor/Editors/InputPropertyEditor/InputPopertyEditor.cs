using System;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;

namespace GrapeCityJSDemo.Module.Blazor.Editors.InputPropertyEditor
{
    [PropertyEditor(typeof(object), "CustomInputPE", false)]
    public class InputPopertyEditor : BlazorPropertyEditorBase
    {

        public InputPopertyEditor(Type objectType, IModelMemberViewItem info)
            : base(objectType, info)
        {

        }

        protected override IComponentAdapter CreateComponentAdapter() => new CustomInputAdapter(new CustomInputModel());
    }
}
