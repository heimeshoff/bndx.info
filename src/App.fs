module App

open Elmish
open Elmish.React
open Fable.Core.JsInterop

open Bndx
open Fable.Core

importAll "./style.css"


[<Emit("scrollIntoView($0)")>]
let scrollIntoView (t : string) = jsNative


Program.mkProgram State.init State.update View.render
|> Program.withReactSynchronous "elmish-app"
#if DEBUG
|> Program.withConsoleTrace
#endif
|> Program.run