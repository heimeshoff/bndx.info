namespace Bndx

module View =
  open Fable.React
  open Fable.React.Props

  open Bndx.Views.Navigation
  open Bndx.Views.Footer
          
// TODO:
// On-Click Ablum schließen ohn ePropagation
// Daten über Textdateien laden

  let image album filename = 
    img 
      [ Class "w-full md:w-48 lg:w-56 xl:w-64 object-cover shadow-lg m-4 lg:m-6 xl:m-8 border border-gray-100"
        Src (sprintf "img/%s/sub_page/%s" album filename ) ]


  let cover dispatch (title:string) file = 
    div 
      [ Class "justify-self-center group relative w-36 h-36 md:w-48 md:h-48 lg:w-56 lg:h-56 xl:w-64 xl:h-64 overflow-hidden cursor-pointer select-none"
        OnClick (fun e -> (Album_anzeigen title) |> dispatch )
      ]
      [
        div 
          [ Class "transform -translate-y-20 md:-translate-y-24 xl:-translate-y-32 group-hover:translate-y-0 transition-transform
                   absolute top-0 w-full h-20 md:h-24 lg:h-28 xl:h-32 bg-gray-50 bg-opacity-60 glass-light flex flex-col-reverse items-center " ] []

        div 
          [ Class "absolute bottom-0  w-full h-20 md:h-24 lg:h-28 xl:h-32 p-4 bg-gray-100
                   font-bold text-xl text-gray-600 text-center
                   transform translate-y-20 md:translate-y-24 xl:translate-y-32 group-hover:translate-y-0 transition-transform duration-200 ease-in-out"]
              [ title.ToUpper() |> ofString]                 

        img 
          [ Class "w-full h-full object-cover"
            Src (sprintf "img/%s" file ) ]
      ]


  let hero dispatch model =
    div [ Class "relative w-full h-screen overflow-hidden" ]
      [ 
        img [ Class "absolute w-full h-full object-cover"
              Src "img/hero.jpg" ]
        div [ Class "absolute inset-0 bg-purple-700 bg-opacity-25" ] []
        div [ Class "absolute bottom-0 right-0 mb-28 mr-4 sm:mr-8 sm:mb-32 md:mr-12 lg:mr-32 lg:mb-48 font-serif text-white text-shadow w-2/3 md:w-1/2" ]
          [
            ["Illustrator, der" |> ofString ] |> div [ Class "font-bold text-4xl mb-4 text-right" ]
            ["Substantiv, maskulin; ein Künstler, der einen Text mit Illustrationen ausgestaltet." |> ofString ] |> div [ Class "text-xl mb-1 leading-tight text-right" ]
            ["Vielleicht ja auch bald für sie?" |> ofString ] |> div [ Class "text-xl text-right" ]
          ]              
      ]
      

  let album dispatch model =
    let trans = match model.album with | Some album -> "translate-x-0" | None -> "translate-x-full"

    div [ Class (sprintf "pt-20 xl:pt-32 flex flex-col items-center transform %s transition-transform duration-500 ease-in-out" trans); Id "portfolio" ]
      [
        div [ Class "flex flex-row flex-wrap justify-around items-center" ]
          [ 
            image "heimesstuff" "1.png"
            image "heimesstuff" "2.png"
            image "heimesstuff" "shirt.jpg"
            image "heimesstuff" "3.png"
            image "heimesstuff" "4.png"
          ] 
      ]


  let albums dispatch model =
    div [ Class "relative w-full py-20 xl:py-32 flex flex-col items-center"; Id "portfolio" ]
      [
        div [ Class "grid grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-2 md:gap-4 lg:gap-6 xl:gap-8 " ]
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
      ]


  let album_overlay dispatch model =
    let transformation =  
      match model.album with
      | Some a -> "translate-y-0"
      | None -> "translate-y-full"

    div [ Class (sprintf "fixed z-50 h-screen w-screen transform transition-transform duration-300 ease-out %s" transformation) ]
      [

        div [ Class "h-full w-full bg-gray-50 overflow-y-scroll overscroll-none" ]
          [
            div [ Class "sticky top-0 h-20 shadow-lg group cursor-pointer bg-white w-full flex items-center justify-center"
                  OnClick (fun _ -> Album_schliessen |> dispatch )]
              [ 
                div [ Class "flex items-center justify-center w-12 h-12 rounded-full bg-gray-200 group-hover:bg-gray-100"]
                  [
                    img [ Src "./img/doubledown.svg"
                          Class "w-6 h-6"
                        ]
                  ]
              ]

            div [ Class "py-8 px-4 md:py-10 md:px-8 lg:py-12 lg:px-10 xl:py-16 xl:px-12  flex flex-row flex-wrap justify-center items-center" ]
              [ 
                image "heimesstuff" "1.png"
                image "heimesstuff" "2.png"
                image "heimesstuff" "shirt.jpg"
                image "heimesstuff" "3.png"
                image "heimesstuff" "4.png"
              ] 
          ]
      ]


  let render (model:Model) dispatch =  
    div [ Class "relative font-sans h-screen overflow-y-scroll overflow-x-hidden"; Id "top"
          OnClick (fun _ -> Clicked_Anywhere |> dispatch )]    
      [ 
        album_overlay dispatch model

        navbar dispatch model 
        hero dispatch model 
        albums dispatch model 
        footer dispatch model 
      ]