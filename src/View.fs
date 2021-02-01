namespace Bndx

module View =
  open Fable.React
  open Fable.React.Props

  open Bndx.Views.Navigation
  open Bndx.Views.Footer
          
// TODO:
// On-Click Ablum schließen ohn ePropagation
// Daten über Textdateien laden
// Font-sans always upper, font-serif always lower


  let cover dispatch (title:string) file = 
    div 
      [ Class "group relative w-40 h-40 md:w-48 md:h-48 xl:w-64 xl:h-64 overflow-hidden cursor-pointer select-none"
        OnClick (fun e -> (Album_anzeigen title) |> dispatch )
      ]
      [
        div 
          [ Class "transform -translate-y-32 group-hover:translate-y-0 transition-transform
                   absolute top-0 w-full h-32 bg-gray-50 bg-opacity-60 glass-light flex flex-col-reverse items-center " ] []

        div 
          [ Class "absolute bottom-0  w-full h-32 p-4 bg-gray-100
                   font-bold text-xl text-gray-600 text-center
                   transform translate-y-32 group-hover:translate-y-0 transition-transform duration-200 ease-in-out"]
              [ title.ToUpper() |> ofString]                 

        img 
          [ Class "w-full h-full object-cover"
            Src (sprintf "img/%s" file ) ]
      ]


  let hero dispatch model =
    div [ Class "relative w-full h-screen  overflow-hidden" ]
      [ 
        img [ Class "absolute w-full h-full object-cover"
              Src "img/hero.jpg" ]
        div [ Class "absolute inset-0 bg-purple-700 bg-opacity-25" ] []
        div [ Class "absolute bottom-0 right-0 mb-28 mr-4 sm:mr-8 sm:mb-32 md:mr-12 lg:mr-32 lg:mb-48 font-serif text-white text-shadow sm:w-2/3 md:w-1/2" ]
          [
            ["Illustrator, der" |> ofString ] |> div [ Class "font-bold text-4xl mb-4 text-right" ]
            ["Substantiv, maskulin; ein Künstler, der einen Text mit Illustrationen ausgestaltet." |> ofString ] |> div [ Class "text-xl mb-1 leading-tight text-right" ]
            ["Vielleicht ja auch bald für sie?" |> ofString ] |> div [ Class "text-xl text-right" ]
          ]              
      ]


  let albums dispatch model =
    div [ Class " grid grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-4 xl:gap-8" ]
      [ 
        cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg"
        cover dispatch "StuffNThinkgs" "illustrationen_soltau/cover/soltau.jpg"
        cover dispatch "StuffNThinkgs""layout_und_piktogramme/cover/Buch_S_B.jpg"
        cover dispatch "StuffNThinkgs""heimesstuff/cover/heimeshoff_it Kopie.jpg"
        cover dispatch "StuffNThinkgs""illustrationen_soltau/cover/soltau.jpg"
        cover dispatch "StuffNThinkgs""layout_und_piktogramme/cover/Buch_S_B.jpg"
        cover dispatch "StuffNThinkgs""heimesstuff/cover/heimeshoff_it Kopie.jpg"
        cover dispatch "StuffNThinkgs""illustrationen_soltau/cover/soltau.jpg"
        cover dispatch "StuffNThinkgs""layout_und_piktogramme/cover/Buch_S_B.jpg"
        cover dispatch "StuffNThinkgs""illustrationen_soltau/cover/soltau.jpg"
        cover dispatch "StuffNThinkgs""layout_und_piktogramme/cover/Buch_S_B.jpg"
      ] 

  let album dispatch model =
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
                    cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg"
                    cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg"
                    cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg"
                    cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg"
                    cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg"
                  ]                       
              ]
          ]
    | None -> nothing


  let render (model:Model) dispatch =  
    div [ Class "relative font-sans"; Id "top"
          OnClick (fun _ -> Clicked_Anywhere |> dispatch )]    
      [ 
        album dispatch model 

        navbar dispatch model 
        hero dispatch model 
        albums dispatch model 
        footer dispatch model 
      ]