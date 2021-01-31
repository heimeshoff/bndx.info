namespace Bndx

module View =
  open Fable.React
  open Fable.React.Props

  open Bndx.Views.Navigation
  open Bndx.Views.Hero
  open Bndx.Views.Footer
          
// TODO:
// On-Click Ablum schließen ohn ePropagation
// Daten über Textdateien laden
// Font-sans always upper, font-serif always lower


  let landingpage model dispatch =
    div [ Class "flex flex-col justify-start items-center" ]
      [ 
        hero model dispatch
      ]


  let render (model:Model) dispatch =  
    div [ Class "relative"; Id "top"
          OnClick (fun _ -> Clicked_Anywhere |> dispatch )]    
      [ 
        navbar model dispatch
        landingpage model dispatch
        match model.album with
        | Some album -> 
            div [ Class "absolute inset-0 bg-gray-500 bg-opacity-25 glass-dense flex flex-col items-center justify-center" 
                  OnClick (fun e -> Album_schliessen |> dispatch) ]
              [
                div [ Class "bg-white rounded-md shadow-xl p-8 h-full mt-24 mb-24" ]
                  [
                    div [ Class "w-full text-center font-sans font-bold text-xl text-gray-600" ]
                      [ album |> ofString ]
                    div [ Class "mt-4 grid grid-cols-2 md:grid-cols-3 gap-4 " ]
                      [ 
                        cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg" "http://www.penis-de"
                        cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg" "http://www.penis-de"
                        cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg" "http://www.penis-de"
                        cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg" "http://www.penis-de"
                        cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg" "http://www.penis-de"
                      ]                       
                  ]
              ]
        | None -> nothing

        footer model dispatch
      ]