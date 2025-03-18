//import "_content/Blazor.Extensions.Canvas/blazor.extensions.canvas.js"
//import "./_content/Blazor.Extensions.Canvas/blazor.extensions.canvas.js"
//import "blazor.extensions.canvas.js"

//window.divCanvasJsFunctions = {
//    getDivCanvasOffset: function (el) {
//        var obj = {};
//        obj.offsetLeft = el.offsetLeft;
//        obj.offsetTop = el.offsetTop;
//        return JSON.stringify(obj);
//    }
//};

export function getDivCanvasOffset(el) {
    var obj = {};
    obj.offsetLeft = el.offsetLeft;
    obj.offsetTop = el.offsetTop;
    return JSON.stringify(obj);
}
