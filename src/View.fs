namespace Bndx

module View =
  open Fable.React
  open Fable.React.Props

  open Bndx.Views.Navigation
  open Bndx.Views.Hero
  open Bndx.Views.Impressum
  open Bndx.Views.Footer
          

  let landingpage model dispatch =
    div [ Class "flex flex-col justify-start items-center shadow-xl" ]
      [ 
        hero model dispatch
      ]


  let render (model:Model) dispatch =  
    div [ Class ""; Id "top"
          OnClick (fun _ -> Clicked_Anywhere |> dispatch )]    
      [ 
        navbar model dispatch
        landingpage model dispatch
        footer model dispatch
      ]