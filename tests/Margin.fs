﻿namespace FSSTests

open Fable.Mocha
open Fable.Core.JsInterop
open Utils
open Fss

module Margin =
    let tests =
        testList "Margin"
            [
                test
                    "Margin top px"
                    [ MarginTop' (px 10)]
                    ["marginTop" ==> "10px"]
                test
                    "Margin right px"
                    [ MarginRight' (px 10)]
                    ["marginRight" ==> "10px"]
                test
                    "Margin bottom px"
                    [ MarginBottom' (px 10)]
                    ["marginBottom" ==> "10px"]
                test
                    "Margin left px"
                    [ MarginLeft' (px 10)]
                    ["marginLeft" ==> "10px"]
                test
                    "Margin px"
                    [ Margin' (px 10)]
                    [ "margin" ==> "10px" ]
                test
                    "Margin pct"
                    [ Margin' (pct 10)]
                    [ "margin" ==> "10%" ]
                test
                    "Margin em"
                    [ Margin' (em 10.0)]
                    [ "margin" ==> "10.0em" ]
                test
                    "Margin auto"
                    [ Margin.Auto]
                    [ "margin" ==> "auto" ]
                test
                    "Margin inherit"
                    [ Margin.Inherit]
                    [ "margin" ==> "inherit" ]
                test
                    "Margin initial"
                    [ Margin.Initial]
                    [ "margin" ==> "initial" ]
                test
                    "Margin unset"
                    [ Margin.Unset ]
                    [ "margin" ==> "unset" ]
                test
                    "Margins multiple"
                    [ Margin.Value (px 10, px 20, px 30, px 40) ]
                    [ "margin" ==> "10px 20px 30px 40px" ]
                test
                    "ScrollMargin top px"
                    [ ScrollMarginTop' (px 10)]
                    ["scrollMarginTop" ==> "10px"]
                test
                    "ScrollMargin right px"
                    [ ScrollMarginRight' (px 10)]
                    ["scrollMarginRight" ==> "10px"]
                test
                    "ScrollMargin bottom px"
                    [ ScrollMarginBottom' (px 10)]
                    ["scrollMarginBottom" ==> "10px"]
                test
                    "ScrollMargin left px"
                    [ ScrollMarginLeft' (px 10)]
                    ["scrollMarginLeft" ==> "10px"]
                test
                    "ScrollMargin px"
                    [ ScrollMargin' (px 10)]
                    [ "scrollMargin" ==> "10px" ]
                test
                    "ScrollMargin em"
                    [ ScrollMargin' (em 10.0)]
                    [ "scrollMargin" ==> "10.0em" ]
                test
                    "ScrollMargin inherit"
                    [ ScrollMargin.Inherit]
                    [ "scrollMargin" ==> "inherit" ]
                test
                    "ScrollMargin initial"
                    [ ScrollMargin.Initial]
                    [ "scrollMargin" ==> "initial" ]
                test
                    "ScrollMargin unset"
                    [ ScrollMargin.Unset ]
                    [ "scrollMargin" ==> "unset" ]
                test
                    "ScrollMargins multiple"
                    [ ScrollMargin.Value (px 10, px 20, px 30, px 40) ]
                    [ "scrollMargin" ==> "10px 20px 30px 40px" ]
            ]