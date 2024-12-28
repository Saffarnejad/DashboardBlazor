using Microsoft.JSInterop;

namespace DashboardBlazor.Helpers.Extensions
{
    public static class IJSRuntimeExtensions
    {
        public static async Task Toastr(this IJSRuntime js, ToastrType type, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", type.ToString().ToLower(), message);
        }

        public static async Task<bool> Confirmation(this IJSRuntime js, string title, string text, SwalIcon icon)
        {
            return await js.InvokeAsync<bool>("ShowSwal", title, text, icon.ToString().ToLower());
        }

        public static async Task Toast(this IJSRuntime js, string title, SwalIcon icon)
        {
            await js.InvokeVoidAsync("ShowToast", title, icon.ToString().ToLower());
        }

        public static async Task PersianDatePicker(this IJSRuntime js, string? startDate = null, string? endDate = null)
        {
            await js.InvokeVoidAsync("PersianDatepickerInit", startDate, endDate);
        }
    }

    public enum ToastrType
    {
        Success = 0,
        Warning = 1,
        Error = 2,
        Info = 3
    }

    public enum SwalIcon
    {
        Success = 0,
        Warning = 1,
        Error = 2,
        Info = 3,
        Question = 4
    }
}
