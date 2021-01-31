module Bndx.Views.Hero

open Fable.React
open Fable.React.Props
open Bndx

let cover dispatch (title:string) file album = 
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
                 font-sans font-bold text-xl text-gray-600 text-center
                 transform translate-y-32 group-hover:translate-y-0 transition-transform duration-200 ease-in-out"]
            [ title.ToUpper() |> ofString]                 

      img 
        [ Class "w-full h-full object-cover"
          Src (sprintf "img/%s" file ) ]
    ]

let hero model dispatch =
  div [ Class "mt-28 grid grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-4 xl:gap-8" ]
    [ 
      cover dispatch "Heimeshoff" "heimesstuff/cover/heimeshoff_it Kopie.jpg" "http://www.penis-de"
      cover dispatch "StuffNThinkgs" "illustrationen_soltau/cover/soltau.jpg" "http://www.penis-de"
      cover dispatch "StuffNThinkgs""layout_und_piktogramme/cover/Buch_S_B.jpg" "http://www.penis-de"
      cover dispatch "StuffNThinkgs""heimesstuff/cover/heimeshoff_it Kopie.jpg" "http://www.penis-de"
      cover dispatch "StuffNThinkgs""illustrationen_soltau/cover/soltau.jpg" "http://www.penis-de"
      cover dispatch "StuffNThinkgs""layout_und_piktogramme/cover/Buch_S_B.jpg" "http://www.penis-de"
      cover dispatch "StuffNThinkgs""heimesstuff/cover/heimeshoff_it Kopie.jpg" "http://www.penis-de"
      cover dispatch "StuffNThinkgs""illustrationen_soltau/cover/soltau.jpg" "http://www.penis-de"
      cover dispatch "StuffNThinkgs""layout_und_piktogramme/cover/Buch_S_B.jpg" "http://www.penis-de"
      cover dispatch "StuffNThinkgs""illustrationen_soltau/cover/soltau.jpg" "http://www.penis-de"
      cover dispatch "StuffNThinkgs""layout_und_piktogramme/cover/Buch_S_B.jpg" "http://www.penis-de"
    ] 
 