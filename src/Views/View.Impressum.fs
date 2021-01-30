module Bndx.Views.Impressum

open Fable.React
open Fable.React.Props


let impressum model dispatch =
  div [ Class "bg-grey-lighter" ; Id "kontakt"]
    [ div [ Class "my-8 w-4/5 lg:w-2/3 xl:w-1/2 flex flex-col md:flex-row items-center justify-center" ]
        [ div [ Class "p-4 w-full rounded-lg shadow-md bg-white" ]
            [ h2 [ ]
                [ str "Impressum"]
              p [ Class "italic" ]
                [ str "Impressive, I know" ]
            ]
         ]
    ]