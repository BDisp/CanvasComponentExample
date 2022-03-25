using Microsoft.JSInterop;

namespace CanvasComponentExampleCore
{
    //public class DivCanvasJsInterop
    //{
    //    public const string JsGetDivCanvasOffset = "divCanvasJsFunctions.getDivCanvasOffset";

    //    public static ValueTask<string> GetDivCanvasOffset(IJSRuntime jsRuntime, object[] divCanvas)
    //    {
    //        // Implemented in divCanvasJsInterop.js
    //        return jsRuntime.InvokeAsync<string>(
    //            JsGetDivCanvasOffset,
    //            divCanvas);
    //    }
    //}

    public class DivCanvasJsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public DivCanvasJsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
               "import", "./_content/CanvasComponentExampleCore/divCanvasJsInterop.js").AsTask());
        }

        public async ValueTask<string> GetDivCanvasOffset(object[] divCanvas)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("getDivCanvasOffset", divCanvas);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
