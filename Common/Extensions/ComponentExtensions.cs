#region

using System.Reflection;
using Microsoft.AspNetCore.Components;

#endregion

namespace Moka.Beer.Common.Extensions;

/// <summary>
///     Provides extension methods for ComponentBase derived classes.
/// </summary>
public static class ComponentExtensions
{
    /// <summary>
    ///     Retrieves the CSS classes assigned to the properties of a component.
    /// </summary>
    /// <typeparam name="TComponent">The type of the component, derived from ComponentBase.</typeparam>
    /// <param name="component">The instance of the component.</param>
    /// <returns>A string containing the CSS classes assigned to the properties of the component, separated by spaces.</returns>
    /// <remarks>
    ///     This method uses reflection to get the properties of the component type.
    ///     It then retrieves the CssClassAttribute from each property (if present) and constructs a string of CSS classes.
    /// </remarks>
    public static string GetCssClasses<TComponent>(this TComponent component) where TComponent : ComponentBase
    {
        return string.Join(" ", typeof(TComponent).GetProperties()
            .Select(property => new
                { Property = property, Attribute = property.GetCustomAttribute<CssClassAttribute>() })
            .Where(pair => pair.Attribute != null)
            .Select(pair => $"{pair.Attribute?.CssClass} {pair.Property.GetValue(component)}")
            .ToArray());
    }
}