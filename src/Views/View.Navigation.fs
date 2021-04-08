module Bndx.Views.Navigation

open System
open Fable.React
open Fable.React.Props

open Bndx


let anchor dispatch (label:String) =
  div [ Class "p-4 text-2xl w-full lg:w-auto border-b-2 border-transparent hover:border-purple-400 cursor-pointer"
        OnClick (fun e -> e.stopPropagation() ; ScrollTo (label.ToLower()) |> dispatch) ]
    [ str label ]
    

let bild = 
  div [ Class "w-64 m-4 p-2 flex flex-col items-center floating-action-button cursor-pointer bg-white" ] 
    [ 
      img 
        [ Class "w-64 h-64 object-cover" 
          Src "https://bndx.info/wp-content/uploads/2020/09/heimeshoff_it-1.jpg" ]
      div [Class "text-center"]
        [ "Demns " |> ofString ] ]


let links model dispatch =
  [ "Portfolio" |> anchor dispatch
    "Kontakt" |> anchor dispatch  ]


let brand_logo dispatch = 
  div [ Class "text-2xl font-bold text-gray-800 p-4 ml-4 cursor-pointer border-b-2 border-transparent hover:border-purple-400"
        OnClick (fun _ -> Navigate_to Landingpage |> dispatch) ]
    [ str "BNDX"
      span [ Class "ml-2 font-normal" ]
        [ "ILLUSTRATION" |> ofString ]   
    ]


let toggle_menu dispatch = 
  button [ Class "flex-no-shrink mr-4 flex items-center  focus:outline-none"
           OnClick (fun e -> e.stopPropagation() ; Toggle_menu |> dispatch ) ]
    [ 
      img [ Src "./img/hamberder.svg"
            Class "h-20 w-20" ]
    ] 


let mobile_menu dispatch model = 
  div [ Class "lg:hidden" ]
    [
      div [ Class "h-20 flex flex-row items-center justify-between"]
        [
          brand_logo dispatch
          toggle_menu dispatch 
        ]
      if model.menu_open then
        div [ Class "flex flex-col items-center space-y-4 pl-4" ]
          ( links model dispatch )
    ]


let desktop_model dispatch model = 
  div [ Class "hidden lg:block w-full" ]
    [
      div [ Class "h-20 flex flex-row justify-between" ]
        [
          brand_logo dispatch
          div [ Class "hidden lg:flex flex-row items-center space-x-4 pr-8" ]    
            ( links model dispatch )
        ]
    ]


let navbar dispatch (model:Model) =
  div [ Class "z-40 fixed w-full glass-dense bg-white bg-opacity-50 shadow-lg" ]
    [ 
      mobile_menu dispatch model 
      desktop_model dispatch model 
    ]