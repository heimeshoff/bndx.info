namespace Bndx


type Link = {
  url: string
  label: string
}


type Page =
    | Landingpage
    | About


type Model = {
  menu_open: bool
  currentPage: Page
}


type Msg = 
  | Toggle_menu
  | Clicked_Anywhere
  | Navigate_to of Page
  | ScrollTo of string
  | OnLogError of exn