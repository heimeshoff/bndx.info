namespace Bndx

module State =
  open Elmish
  open Fable.Core

  [<Emit("scrollIntoView($0)")>]
  let scrollIntoView (t : string) = jsNative


  let init result =
    {
        menu_open = false
        currentPage = Landingpage
        album = None
    }, Cmd.none


  let update (msg:Msg) (model:Model) =
    match msg with
    | Toggle_menu ->
        { model with menu_open = not model.menu_open }, Cmd.none
        
    | Clicked_Anywhere ->
        { model with
            menu_open = false }, Cmd.none
        
    | OnLogError e ->
        model, Cmd.none
        
    | ScrollTo s ->
        { model with menu_open = false } , Cmd.OfFunc.attempt scrollIntoView s OnLogError
    
    | Navigate_to p ->
        { model with currentPage = p ; menu_open = false }, Cmd.ofMsg (ScrollTo "top")

    | Album_anzeigen album ->
        { model with album = Some album }, Cmd.none

    | Album_schliessen ->
        { model with album = None }, Cmd.none
