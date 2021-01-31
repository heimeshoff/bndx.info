import * as react from "react";

export function footer(model, dispatch) {
    return react.createElement("div", {
        className: "w-full pt-24 pb-12 flex flex-col items-center justify-center",
    }, react.createElement("a", {
        className: "hover:text-blue-400",
        target: "_blank",
    }, "Impressum"), react.createElement("div", {
        className: "font-bold text-gray-500 font-sans flex",
    }, "© 2021 BNDX ILLUSTRATION - WEBSITE BY", react.createElement("a", {
        className: "pl-2 text-blue-500 hover:text-blue-400",
        href: "https://www.heimeshoff.de",
        target: "_blank",
    }, "HEIMESHOFF IT")));
}

