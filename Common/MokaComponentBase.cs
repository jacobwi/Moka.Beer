#region

using Microsoft.AspNetCore.Components;
using Moka.Beer.Common.Enums;

#endregion

namespace Moka.Beer.Common;

/// <summary>
///     Base class for Moka components. This class contains common properties that can be used by all Moka components.
/// </summary>
public class MokaComponentBase : ComponentBase
{
    /// <summary>
    ///     Gets or sets the user class names, separated by space.
    /// </summary>
    [Parameter]
    public string? Class { get; set; }


    /// <summary>
    ///     Gets or sets the user styles, applied on top of the component's own classes and styles.
    /// </summary>
    [Parameter]
    public string? Style { get; set; }

    /// <summary>
    ///     Gets or sets the Tag property to attach any user data object to the component.
    /// </summary>
    [Parameter]
    public object? Tag { get; set; }

    /// <summary>
    ///     Gets or sets the margin to use between the component and other components.
    /// </summary>
    [Parameter]
    public Margin Margin { get; set; } = Margin.NoMargin;


    /// <summary>
    ///     Gets or sets the padding to use between the component and other components.
    /// </summary>
    [Parameter]
    public Padding Padding { get; set; } = Padding.NoPadding;

    /// <summary>
    ///     Gets or sets the position of the component.
    /// </summary>
    [Parameter]
    public Position Position { get; set; } = Position.Default;

    /// <summary>
    ///     Gets or sets the alignment of the component.
    /// </summary>
    [Parameter]
    public Alignment Alignment { get; set; } = Alignment.Default;


    [Parameter] public Alignment VerticalAlignment { get; set; } = Alignment.Default;
    [Parameter] public Alignment HorizontalAlignment { get; set; } = Alignment.MiddleAlign;

    /// <summary>
    ///     Gets or sets the theme of the component.
    /// </summary>
    [Parameter]
    public Theme Theme { get; set; } = Theme.Default;

    /// <summary>
    ///     Gets or sets the color of the component.
    /// </summary>
    [Parameter]
    public Color Color { get; set; } = Color.Default;

    /// <summary>
    ///     Gets or sets additional classes to be applied to the component.
    /// </summary>
    [Parameter]
    public string AdditionalClasses { get; set; } = string.Empty;
}