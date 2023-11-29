#region

using Microsoft.JSInterop;

#endregion

namespace Moka.Beer.Common.Services;

public class ThemeService(IJSRuntime jSRuntime)
{
    private readonly Lazy<Task<IJSObjectReference>> _moduleTask = new(() =>
        jSRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/Moka.Beer/js/MokaInterop.js").AsTask());


    public async Task<bool> GetMode()
    {
        var module = await _moduleTask.Value;
        var mode = await module.InvokeAsync<string>("getLocalStorage", "mode");
        return !string.IsNullOrEmpty(mode) && mode == "dark";
    }

    public async Task<string> GetTheme()
    {
        var module = await _moduleTask.Value;
        var theme = await module.InvokeAsync<string>("getLocalStorage", "theme");
        return theme;
    }

    public async Task SetDarkMode(bool darkMode)
    {
        var module = await _moduleTask.Value;
        var mode = darkMode ? "dark" : "light";
        await module.InvokeVoidAsync("setMode", mode);
    }

    public async Task SetThemeColor(string color)
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("setTheme", color);
    }

    public async Task UpdateColors()
    {
        var module = await _moduleTask.Value;

        await module.InvokeVoidAsync("updateColors");
    }
}