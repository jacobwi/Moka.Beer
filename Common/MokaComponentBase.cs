using Microsoft.AspNetCore.Components;
using Moka.Beer.Common.Enums;

namespace Moka.Beer.Common;

public class MokaComponentBase : ComponentBase
{
    /// <summary>
    /// User class names, separated by space.
    /// </summary>
    [Parameter] 
    public string? Class { get; set; }
    
    
    /// <summary>
    /// User styles, applied on top of the component's own classes and styles.
    /// </summary>
    [Parameter]
    public string? Style { get; set; }
    
    /// <summary>
    /// Use Tag to attach any user data object to the component.
    /// </summary>
    [Parameter]
    public object? Tag { get; set; }

    /// <summary>
    /// The margin to use between the component and other components.
    /// </summary>
    [Parameter]
    public Margin Margin { get; set; } = Margin.NoMargin;

    
    /// <summary>
    /// The padding to use between the component and other components.
    /// </summary>
    [Parameter]
    public Padding Padding { get; set; } = Enums.Padding.NoPadding;

    
    /// <summary>
    /// Additional classes to be applied to the component.
    /// </summary>
    [Parameter] public string AdditionalClasses { get; set; } = string.Empty;

}