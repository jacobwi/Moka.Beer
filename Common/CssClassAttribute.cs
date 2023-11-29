namespace Moka.Beer.Common;

/// <summary>
///     The CssClassAttribute class is a custom attribute that can be used to annotate properties with a specific CSS
///     class.
/// </summary>
/// <remarks>
///     This attribute is used to assign a CSS class to a property. The CSS class is specified as a string argument to the
///     attribute.
/// </remarks>
/// <example>
///     Here is an example of how to use this attribute:
///     <code>
/// [CssClass("my-component")]
/// public string ComponentName { get; set; }
/// </code>
///     In this example, the ComponentName property is assigned the CSS class "my-component".
/// </example>
[AttributeUsage(AttributeTargets.Field)]
public class CssClassAttribute : Attribute
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CssClassAttribute" /> class with the specified CSS class.
    /// </summary>
    /// <param name="cssClass">The CSS class to assign to the property.</param>
    public CssClassAttribute(string cssClass)
    {
        CssClass = cssClass;
    }

    /// <summary>
    ///     Gets the CSS class assigned to the property.
    /// </summary>
    public string CssClass { get; }
}