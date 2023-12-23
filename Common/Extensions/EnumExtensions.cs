#region

using System.Linq.Expressions;
using System.Reflection;

#endregion

namespace Moka.Beer.Common.Extensions;

public static class BooleanExtensions
{
    public static string GetBoolCssClass<TComponent>(this TComponent component,
        Expression<Func<TComponent, bool>> propertySelector)
    {
        if (propertySelector.Body is not MemberExpression memberExpression)
            throw new ArgumentException("The expression is not a member access expression.", nameof(propertySelector));

        var property = memberExpression.Member as PropertyInfo;
        if (property == null)
            throw new ArgumentException("The member access expression does not access a property.",
                nameof(propertySelector));

        var attribute = property.GetCustomAttribute<CssClassAttribute>();
        return attribute?.CssClass ?? string.Empty;
    }
}

public static class EnumExtensions
{
    public static string GetEnumCssClass(this Enum value)
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        var attribute =
            fieldInfo!.GetCustomAttributes(typeof(CssClassAttribute), false).FirstOrDefault() as CssClassAttribute;
        return attribute?.CssClass ?? string.Empty;
    }
}