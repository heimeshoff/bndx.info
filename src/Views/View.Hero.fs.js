import * as react from "react";
import { Msg } from "../Types.fs.js";
import { printf, toText } from "../.fable/fable-library.3.0.1/String.js";

export function cover(dispatch, title, file, album) {
    return react.createElement("div", {
        className: "group relative w-40 h-40 md:w-48 md:h-48 xl:w-64 xl:h-64 overflow-hidden cursor-pointer select-none",
        onClick: (e) => {
            dispatch(new Msg(5, title));
        },
    }, react.createElement("div", {
        className: "transform -translate-y-32 group-hover:translate-y-0 transition-transform\r\n                 absolute top-0 w-full h-32 bg-gray-50 bg-opacity-60 glass-light flex flex-col-reverse items-center ",
    }), react.createElement("div", {
        className: "absolute bottom-0  w-full h-32 p-4 bg-gray-100\r\n                 font-sans font-bold text-xl text-gray-600 text-center\r\n                 transform translate-y-32 group-hover:translate-y-0 transition-transform duration-200 ease-in-out",
    }, title.toLocaleUpperCase()), react.createElement("img", {
        className: "w-full h-full object-cover",
        src: toText(printf("img/%s"))(file),
    }));
}

export function hero(model, dispatch) {
    return react.createElement("div", {
        className: "mt-28 grid grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-4 xl:gap-8",
    }, cover(dispatch, "Heimeshoff", "heimesstuff/cover/heimeshoff_it Kopie.jpg", "http://www.penis-de"), cover(dispatch, "StuffNThinkgs", "illustrationen_soltau/cover/soltau.jpg", "http://www.penis-de"), cover(dispatch, "StuffNThinkgs", "layout_und_piktogramme/cover/Buch_S_B.jpg", "http://www.penis-de"), cover(dispatch, "StuffNThinkgs", "heimesstuff/cover/heimeshoff_it Kopie.jpg", "http://www.penis-de"), cover(dispatch, "StuffNThinkgs", "illustrationen_soltau/cover/soltau.jpg", "http://www.penis-de"), cover(dispatch, "StuffNThinkgs", "layout_und_piktogramme/cover/Buch_S_B.jpg", "http://www.penis-de"), cover(dispatch, "StuffNThinkgs", "heimesstuff/cover/heimeshoff_it Kopie.jpg", "http://www.penis-de"), cover(dispatch, "StuffNThinkgs", "illustrationen_soltau/cover/soltau.jpg", "http://www.penis-de"), cover(dispatch, "StuffNThinkgs", "layout_und_piktogramme/cover/Buch_S_B.jpg", "http://www.penis-de"), cover(dispatch, "StuffNThinkgs", "illustrationen_soltau/cover/soltau.jpg", "http://www.penis-de"), cover(dispatch, "StuffNThinkgs", "layout_und_piktogramme/cover/Buch_S_B.jpg", "http://www.penis-de"));
}

