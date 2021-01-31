module Bndx.Views.Footer

open Fable.React
open Fable.React.Props


let footer model dispatch =
  div [ Class "w-full pt-24 pb-12 flex flex-col items-center justify-center" ]
    [ a [ Class "hover:text-blue-400"
          Target "_blank"
        ]
        [ "Impressum" |> ofString ]
      div 
        [ Class "font-bold text-gray-500 font-sans flex" ] 
        [
          str "© 2021 BNDX ILLUSTRATION - WEBSITE BY"
          a [ Class "pl-2 text-blue-500 hover:text-blue-400"
              Href "https://www.heimeshoff.de"
              Target "_blank"
            ]
            [ "HEIMESHOFF IT" |> ofString ]
        ]
    ]  
