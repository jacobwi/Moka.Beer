namespace Moka.Beer.Common.Enums;

public enum InputType
{
    [CssClass("text")] Text,
    [CssClass("password")] Password,
    [CssClass("color")] Color,
    [CssClass("file")] File,
    [CssClass("date")] Date,
    [CssClass("time")] Time,
    [CssClass("tel")] Phone,
    [CssClass("url")] Url,
    [CssClass("number")] Number
}