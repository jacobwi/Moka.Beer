namespace Moka.Beer.Common.Extensions;

public static class EnumExtensions
{
    public static string GetEnumCssClass(this Enum value)
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        var attribute =
            fieldInfo!.GetCustomAttributes(typeof(CssClassAttribute), false).FirstOrDefault() as CssClassAttribute;
        return attribute?.CssClass ?? string.Empty;
    }
    
    public static string GetBoolCssClass(this bool value)
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        var attribute =
            fieldInfo!.GetCustomAttributes(typeof(CssClassAttribute), false).FirstOrDefault() as CssClassAttribute;
        return attribute?.CssClass ?? string.Empty;
    }
}