// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Carlton.Base.Client.State
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class CarltonDataComponent<TViewModel> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.State\CarltonDataComponent.razor"
      
    private RenderFragment<CarltonDataWrapperContext<TViewModel>> DynamicChild { get; set; }

    [Inject]
    private ICarltonStateFactory factory { get; set; }

    private delegate Task ComponentEventDel(object evt);


    protected override void OnInitialized()
    {
        DynamicChild = (CarltonDataWrapperContext<TViewModel> context) =>
        builder =>
        {
            var viewModel = context.ViewModel;
            var del = new ComponentEventDel(context.OnComponentEvent);
            var eventCallback = new EventCallback(this, del);

            builder.OpenComponent(1, factory.GetComponentType<TViewModel>());
            builder.AddAttribute(1, "ViewModel", viewModel);
            builder.AddAttribute(2, "OnComponentEvent", eventCallback);
            builder.CloseComponent();
        };

        base.OnInitialized();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
