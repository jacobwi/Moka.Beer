namespace Moka.Beer.Common.Enums;

public enum Flex
{
    [CssClass("flex-row")] Row,
    [CssClass("flex-column")] Column
}

public enum FlexWrap
{
    [CssClass("")] Default,

    [CssClass("flex-wrap")] Wrap,
    [CssClass("flex-nowrap")] NoWrap,
    [CssClass("flex-wrap-reverse")] WrapReverse
}

public enum FlexJustify
{
    [CssClass("")] Default,

    [CssClass("justify-start")] Start,
    [CssClass("justify-end")] End,
    [CssClass("justify-center")] Center,
    [CssClass("justify-between")] SpaceBetween,
    [CssClass("justify-around")] SpaceAround
}

public enum FlexItems
{
    [CssClass("")] Default,

    [CssClass("items-start")] Start,
    [CssClass("items-end")] End,
    [CssClass("items-center")] Center,
    [CssClass("items-baseline")] Baseline,
    [CssClass("items-stretch")] Stretch
}

public enum FlexJustifyContent
{
    [CssClass("")] Default,

    [CssClass("justify-content-start")] Start,
    [CssClass("justify-content-end")] End,
    [CssClass("justify-content-center")] Center,
    [CssClass("justify-content-between")] Between,
    [CssClass("justify-content-around")] Around,
    [CssClass("justify-content-evenly")] Evenly
}

public enum FlexAlignItems
{
    [CssClass("")] Default,

    [CssClass("align-items-start")] Start,
    [CssClass("align-items-end")] End,
    [CssClass("align-items-center")] Center,
    [CssClass("align-items-baseline")] Baseline,
    [CssClass("align-items-stretch")] Stretch
}

public enum FlexAlignContent
{
    [CssClass("")] Default,

    [CssClass("align-content-start")] Start,
    [CssClass("align-content-end")] End,
    [CssClass("align-content-center")] Center,
    [CssClass("align-content-between")] Between,
    [CssClass("align-content-around")] Around,
    [CssClass("align-content-stretch")] Stretch
}

public enum FlexAlignSelf
{
    [CssClass("")] Default,

    [CssClass("align-self-auto")] Auto,

    [CssClass("align-self-start")] Start,
    [CssClass("align-self-end")] End,
    [CssClass("align-self-center")] Center,
    [CssClass("align-self-baseline")] Baseline,
    [CssClass("align-self-stretch")] Stretch
}

public enum FlexGrowShrink
{
    [CssClass("")] Default,

    [CssClass("flex-grow")] Grow,
    [CssClass("flex-shrink")] Shrink
}

public enum FlexBasis
{
    [CssClass("")] Default,
    [CssClass("flex-basis-auto")] Auto,
    [CssClass("flex-basis-0")] Zero
}

public enum Order
{
    [CssClass("")] Default,

    [CssClass("order-0")] Zero,
    [CssClass("order-1")] One,
    [CssClass("order-2")] Two,
    [CssClass("order-3")] Three,
    [CssClass("order-last")] Last
}