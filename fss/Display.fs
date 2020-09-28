namespace Fss

open Global
open Types
open Fss.Utilities.Helpers

module Display =
    // https://developer.mozilla.org/en-US/docs/Web/CSS/display
    type Display =
        | None
        | Inline
        | InlineBlock
        | Block
        | RunIn
        | Flex
        | Grid
        | FlowRoot

        | Table
        | TableCell
        | TableColumn
        | TableColumnGroup
        | TableHeaderGroup
        | TableRowGroup
        | TableFooterGroup
        | TableRow
        | TableCaption
        interface IDisplay

module DisplayValue =
    open Display

    let display (v: IDisplay): string =
        match v with
            | :? Global  as g -> GlobalValue.globalValue g
            | :? None    as n -> GlobalValue.none n
            | :? Display as d -> duToKebab d
            | _ -> "Unknown display"

module Flex =
    open Units.Size

    // https://developer.mozilla.org/en-US/docs/Web/CSS/flex-direction
    type FlexDirection =
        | Row
        | RowReverse
        | Column
        | ColumnReverse
        interface IFlexDirection

    // https://developer.mozilla.org/en-US/docs/Web/CSS/flex-wrap
    type FlexWrap =
        | NoWrap
        | Wrap
        | WrapReverse
        interface IFlexWrap

    // https://developer.mozilla.org/en-US/docs/Web/CSS/justify-content
    type JustifyContent =
        | Start
        | End
        | FlexStart
        | FlexEnd
        | Center
        | Left
        | Right
        | Normal
        | Baseline
        | SpaceBetween
        | SpaceAround
        | SpaceEvenly
        | Stretch
        | Safe
        | Unsafe
        interface IJustifyContent

    // https://developer.mozilla.org/en-US/docs/Web/CSS/align-items
    type AlignItems =
        | Start
        | End
        | FlexStart
        | FlexEnd
        | Center
        | Left
        | Right
        | Normal
        | Baseline
        | SpaceBetween
        | SpaceAround
        | SpaceEvenly
        | Stretch
        | Safe
        | Unsafe
        interface IAlignItems

    // https://developer.mozilla.org/en-US/docs/Web/CSS/align-content
    type AlignContent =
        | Start
        | End
        | FlexStart
        | FlexEnd
        | Center
        | Left
        | Right
        | Normal
        | Baseline
        | SpaceBetween
        | SpaceAround
        | SpaceEvenly
        | Stretch
        | Safe
        | Unsafe
        interface IAlignContent

    // https://developer.mozilla.org/en-US/docs/Web/CSS/align-self
    type AlignSelf =
        | Normal
        | SelfStart
        | SelfEnd
        | FlexStart
        | FlexEnd
        | Center
        | Baseline
        | Stretch
        | Safe
        | Unsafe
        interface IAlignSelf

    // https://developer.mozilla.org/en-US/docs/Web/CSS/order
    type Order =
        | Order of int
        interface IOrder

    // https://developer.mozilla.org/en-US/docs/Web/CSS/flex-grow
    type FlexGrow =
        | Grow of float
        interface IFlexGrow

    // https://developer.mozilla.org/en-US/docs/Web/CSS/flex-shrink
    type FlexShrink =
        | Shrink of float
        interface IFlexShrink

    // https://developer.mozilla.org/en-US/docs/Web/CSS/flex-basis
    type FlexBasis =
        | Fill
        | MaxContent
        | MinContent
        | FitContent
        | Content
        interface IFlexBasis

module FlexValue =
    open Flex
    open Units.Size
    open Units.Percent

    let flexDirection (v: IFlexDirection): string =
        match v with
            | :? Global        as g -> GlobalValue.globalValue g
            | :? FlexDirection as f -> duToKebab f
            | _ -> "Unknown flex direction"

    let flexWrap (v: IFlexWrap): string =
        match v with
            | :? Global   as g -> GlobalValue.globalValue g
            | :? FlexWrap as f -> duToKebab f
            | _ -> "Unknown flex wrap"

    let justifyContent (v: IJustifyContent): string =
        match v with
            | :? Global         as g -> GlobalValue.globalValue g
            | :? Center         as c -> GlobalValue.center c
            | :? JustifyContent as j -> duToKebab j
            | _ -> "Unknown justify content"

    let alignItems (v: IAlignItems): string =
        match v with
            | :? Global     as g -> GlobalValue.globalValue g
            | :? Center     as c -> GlobalValue.center c
            | :? AlignItems as a -> duToKebab a
            | _ -> "Unknown align items"

    let alignContent (v: IAlignContent): string =
        match v with
            | :? Global       as g -> GlobalValue.globalValue g
            | :? Center       as c -> GlobalValue.center c
            | :? AlignContent as a -> duToKebab a
            | _ -> "Unknown align content"

    let alignSelf (v: IAlignSelf): string =
        match v with
            | :? Global    as g -> GlobalValue.globalValue g
            | :? Auto      as a -> GlobalValue.auto a
            | :? Center    as c -> GlobalValue.center c
            | :? AlignSelf as a -> duToKebab a
            | _ -> "Unknown align self"

    let order (v: IOrder): string =
        let stringifyOrder (Order o): string = string  o
        match v with
            | :? Global as g -> GlobalValue.globalValue g
            | :? Order  as o -> stringifyOrder o
            | _ -> "Unknown order"

    let flexGrow (v: IFlexGrow): string =
        let stringifyFlexGrow (Grow f) = string f
        match v with
            | :? Global   as g -> GlobalValue.globalValue g
            | :? FlexGrow as s -> stringifyFlexGrow s
            | _ -> "Unknown flex grow"

    let flexShrink (v: IFlexShrink): string =
        let stringifyFlexShrink (Shrink f) = string f
        match v with
            | :? Global     as g -> GlobalValue.globalValue g
            | :? FlexShrink as s -> stringifyFlexShrink s
            | _ -> "Unknown flex shrink"

    let flexBasis (v: IFlexBasis): string =
        match v with
            | :? Global    as g -> GlobalValue.globalValue g
            | :? Auto      as a -> GlobalValue.auto a
            | :? Size      as s -> Units.Size.value s
            | :? Percent   as p -> Units.Percent.value p
            | :? FlexBasis as b -> duToKebab b
            | _ -> "Unknown flex basis"