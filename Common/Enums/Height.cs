namespace Moka.Beer.Common.Enums;

public enum Height
{
    [CssClass("height-auto")] Auto,
    [CssClass("height-100vh")] FullViewport,
    [CssClass("height-50vh")] HalfViewport,
    [CssClass("height-25vh")] QuarterViewport,
    [CssClass("height-75vh")] ThreeQuartersViewport
}