#region

using Microsoft.JSInterop;

#endregion

namespace Moka.Beer.Common.Services;

/// <summary>
///     Service class for handling theme related operations.
/// </summary>
public class ThemeService
{
    private readonly Lazy<Task<IJSObjectReference>> _moduleTask;

    /// <summary>
    ///     Constructor for ThemeService. Initializes the JavaScript module.
    /// </summary>
    /// <param name="jSRuntime">The JSRuntime instance used for JavaScript interop.</param>
    public ThemeService(IJSRuntime jSRuntime)
    {
        _moduleTask = new Lazy<Task<IJSObjectReference>>(() =>
            jSRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/Moka.Beer/js/MokaInterop.js").AsTask());
    }

    /// <summary>
    ///     Retrieves the current mode from local storage.
    /// </summary>
    /// <returns>A boolean indicating whether the current mode is dark.</returns>
    public async Task<bool> GetMode()
    {
        var module = await _moduleTask.Value;
        var mode = await module.InvokeAsync<string>("getLocalStorage", "mode");
        return !string.IsNullOrEmpty(mode) && mode == "dark";
    }

    /// <summary>
    ///     Retrieves the current theme from local storage.
    /// </summary>
    /// <returns>The current theme as a string.</returns>
    public async Task<string> GetTheme()
    {
        var module = await _moduleTask.Value;
        var theme = await module.InvokeAsync<string>("getLocalStorage", "theme");
        return theme;
    }

    /// <summary>
    ///     Sets the mode in local storage.
    /// </summary>
    /// <param name="darkMode">A boolean indicating whether to set the mode to dark.</param>
    public async Task SetDarkMode(bool darkMode)
    {
        var module = await _moduleTask.Value;
        var mode = darkMode ? "dark" : "light";
        await module.InvokeVoidAsync("setMode", mode);
    }

    /// <summary>
    ///     Sets the theme color in local storage.
    /// </summary>
    /// <param name="color">The color to set as the theme color.</param>
    public async Task SetThemeColor(string color)
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("setTheme", color);
    }

    /// <summary>
    ///     Updates the colors based on the current theme and mode.
    /// </summary>
    public async Task UpdateColors()
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("updateColors");
    }
}