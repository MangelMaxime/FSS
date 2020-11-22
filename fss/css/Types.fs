namespace Fss

[<AutoOpen>]
module Global =
    // Interfaces
    type IAnimationDirection      = interface end
    type IAnimationFillMode       = interface end
    type IAnimationPlayState      = interface end
    type IAnimationIterationCount = interface end
    type IAnimationName           = interface end

    type IColor = interface end

    type IColorStop = interface end

    type ILengthPercentage = interface end

    type ITemplateType = interface end

    type IFontSize             = interface end
    type IFontStyle            = interface end
    type IFontStretch          = interface end
    type IFontWeight           = interface end
    type IFontDisplay          = interface end
    type IFontFamily           = interface end
    type IFontFeatureSetting   = interface end
    type IFontVariantNumeric   = interface end
    type IFontVariantCaps      = interface end
    type IFontVariantEastAsian = interface end
    type IFontVariantLigature  = interface end
    type ILineHeight           = interface end
    type ILetterSpacing        = interface end

    type ITextAlign               = interface end
    type ITextDecorationLine      = interface end
    type ITextDecorationThickness = interface end
    type ITextDecorationStyle     = interface end
    type ITextDecorationSkip      = interface end
    type ITextDecorationSkipInk   = interface end
    type ITextTransform           = interface end
    type ITextIndent              = interface end
    type ITextShadow              = interface end
    type ITextEmphasisPosition    = interface end
    type ITextEmphasisStyle       = interface end
    type ITextUnderlinePosition   = interface end
    type ITextUnderlineOffset     = interface end
    type ITextOverflow            = interface end
    type IQuotes                  = interface end
    type IHyphens                 = interface end
    type ITextDecorationColor     = interface end
    type ITextEmphasisColor       = interface end

    type IListStyleImage    = interface end
    type IListStylePosition = interface end
    type IListStyleType     = interface end

    type IBackgroundClip       = interface end
    type IBackgroundOrigin     = interface end
    type IBackgroundRepeat     = interface end
    type IBackgroundSize       = interface end
    type IBackgroundAttachment = interface end
    type IBackgroundPosition   = interface end

    type IBorderRadius      = interface end
    type IBorderWidth       = interface end
    type IBorderStyle       = interface end
    type IBorderCollapse    = interface end
    type IBorderImageOutset = interface end
    type IBorderRepeat      = interface end
    type IBorderImageSlice  = interface end
    type IBorderColor       = interface end
    type IBorderSpacing     = interface end
    type IBorderImageWidth  = interface end
    type IBorderImageSource = interface end

    type ITransform       = interface end
    type ITransformOrigin = interface end

    type ITransitionDelay          = interface end
    type ITransitionDuration       = interface end
    type ITransitionTimingFunction = interface end
    type ITransitionProperty       = interface end

    type IDisplay        = interface end
    type IAlignContent   = interface end
    type IAlignItems     = interface end
    type IAlignSelf      = interface end
    type IJustifyContent = interface end
    type IJustifyItems   = interface end
    type IJustifySelf    = interface end
    type IFlexDirection  = interface end
    type IFlexWrap       = interface end
    type IOrder          = interface end
    type IFlexGrow       = interface end
    type IFlexShrink     = interface end
    type IFlexBasis      = interface end

    type IMargin  = interface end
    type IPadding = interface end

    type IContentSize = interface end

    type IVisibility = interface end

    type IOverflow      = interface end
    type IPositioned    = interface end
    type IVerticalAlign = interface end
    type IFloat         = interface end
    type IDirection     = interface end

    type IPerspective = interface end

    type ICursor = interface end

    type IContent = interface end

    type IOutlineColor = interface end
    type IOutlineWidth = interface end
    type IOutlineStyle = interface end

    type IGridAutoFlow        = interface end
    type IGridTemplateArea    = interface end
    type IGridGap             = interface end
    type IGridRowGap          = interface end
    type IGridColumnGap       = interface end
    type IGridPosition        = interface end
    type IGridTemplateRows    = interface end
    type IGridTemplateColumns = interface end
    type IGridAutoRows        = interface end
    type IGridAutoColumns     = interface end

    type INthChild = interface end

    // Types
    type CSSProperty = CSSProperty of string * obj

    type CssInt =
        | CssInt of int
        interface IAnimationIterationCount
        interface IOrder
        interface IFontWeight
        interface INthChild

    type CssFloat =
        | CssFloat of float
        interface IBorderImageWidth
        interface IFlexGrow
        interface IFlexShrink
        interface ILineHeight

    type CssString =
        | CssString of string
        interface IAnimationName
        interface ITextEmphasisStyle
        interface ITextOverflow
        interface IQuotes
        interface IListStyleType
        interface IContent
        interface INthChild

    type Auto =
        | Auto
        interface IFontDisplay
        interface ITextDecorationThickness
        interface ITextDecorationSkipInk
        interface ITextUnderlinePosition
        interface ITextUnderlineOffset
        interface IQuotes
        interface IHyphens
        interface IBackgroundSize
        interface IBorderImageWidth
        interface IFlexBasis
        interface IMargin
        interface IPadding
        interface IContentSize
        interface IOverflow
        interface IPositioned
        interface ICursor
        interface IGridPosition
        interface IGridTemplateRows
        interface IGridTemplateColumns
        interface IGridAutoRows
        interface IGridAutoColumns

    type None =
        | None
        interface IAnimationFillMode
        interface IAnimationName
        interface IFontVariantLigature
        interface ITextDecorationLine
        interface ITextDecorationSkip
        interface ITextDecorationSkipInk
        interface ITextEmphasisStyle
        interface ITextTransform
        interface IQuotes
        interface IHyphens
        interface IListStyleImage
        interface IBorderStyle
        interface IBorderImageSource
        interface ITransform
        interface ITransitionProperty
        interface IDisplay
        interface IFloat
        interface IPerspective
        interface ICursor
        interface IContent
        interface IOutlineStyle
        interface IGridTemplateArea
        interface IGridTemplateRows
        interface IGridTemplateColumns

    type Normal =
        | Normal
        interface IAnimationDirection
        interface IFontStyle
        interface IFontStretch
        interface IFontWeight
        interface IFontVariantNumeric
        interface IFontVariantCaps
        interface IFontVariantEastAsian
        interface IFontVariantLigature
        interface ILineHeight
        interface ILetterSpacing
        interface IAlignContent
        interface IAlignItems
        interface IAlignSelf
        interface IJustifyContent
        interface IJustifyItems
        interface IJustifySelf
        interface IContent
        interface IGridRowGap
        interface IGridColumnGap

    type Keywords =
        | Inherit
        | Initial
        | Unset
        interface IAnimationDirection
        interface IAnimationPlayState
        interface IAnimationName
        interface IColor
        interface IFontSize
        interface IFontStyle
        interface IFontStretch
        interface IFontWeight
        interface IFontFamily
        interface IFontFeatureSetting
        interface IFontVariantNumeric
        interface IFontVariantCaps
        interface IFontVariantEastAsian
        interface IFontVariantLigature
        interface ILineHeight
        interface ILetterSpacing
        interface ITextAlign
        interface ITextDecorationLine
        interface ITextDecorationThickness
        interface ITextDecorationStyle
        interface ITextDecorationSkip
        interface ITextDecorationSkipInk
        interface ITextTransform
        interface ITextIndent
        interface ITextShadow
        interface ITextEmphasisPosition
        interface ITextEmphasisStyle
        interface ITextUnderlinePosition
        interface ITextUnderlineOffset
        interface IQuotes
        interface IHyphens
        interface ITextDecorationColor
        interface ITextEmphasisColor
        interface IListStyleImage
        interface IListStylePosition
        interface IListStyleType
        interface IBackgroundClip
        interface IBackgroundOrigin
        interface IBackgroundRepeat
        interface IBackgroundSize
        interface IBackgroundAttachment
        interface IBackgroundPosition
        interface IBorderRadius
        interface IBorderWidth
        interface IBorderStyle
        interface IBorderCollapse
        interface IBorderImageOutset
        interface IBorderRepeat
        interface IBorderImageSlice
        interface IBorderColor
        interface IBorderSpacing
        interface IBorderImageWidth
        interface IBorderImageSource
        interface ITransform
        interface ITransformOrigin
        interface ITransitionDelay
        interface ITransitionDuration
        interface ITransitionTimingFunction
        interface ITransitionProperty
        interface IDisplay
        interface IAlignContent
        interface IAlignItems
        interface IAlignSelf
        interface IJustifyContent
        interface IJustifyItems
        interface IJustifySelf
        interface IFlexDirection
        interface IFlexWrap
        interface IOrder
        interface IFlexGrow
        interface IFlexShrink
        interface IFlexBasis
        interface IMargin
        interface IPadding
        interface IContentSize
        interface IVisibility
        interface IOverflow
        interface IPositioned
        interface IVerticalAlign
        interface IFloat
        interface IPerspective
        interface ICursor
        interface IContent
        interface IOutlineColor
        interface IOutlineWidth
        interface IOutlineStyle
        interface IGridAutoFlow
        interface IGridTemplateArea
        interface IGridGap
        interface IGridRowGap
        interface IGridColumnGap
        interface IGridPosition
        interface IGridTemplateRows
        interface IGridTemplateColumns
        interface IGridAutoRows
        interface IGridAutoColumns
        interface IDirection

[<RequireQualifiedAccess>]
module GlobalValue =
    let auto = "auto"
    let none = "none"
    let normal = "normal"

    let int (CssInt i) = string i
    let float (CssFloat f) = string f
    let string (CssString s) = s

    let keywords =
        function
            | Inherit -> "inherit"
            | Initial -> "initial"
            | Unset -> "unset"

    let CSSValue (CSSProperty (s,o)) = s,o

