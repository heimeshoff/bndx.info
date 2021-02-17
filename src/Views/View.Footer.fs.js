import * as react from "react";

export function footer(dispatch, model) {
    return react.createElement("div", {
        className: "w-full pb-12 flex flex-col items-center justify-center",
    }, react.createElement("a", {
        className: "hover:text-blue-400",
        target: "_blank",
    }, "Impressum"), react.createElement("div", {
        className: "font-bold text-gray-500 flex flex-col md:flex-row",
    }, " © 2021 BNDX ILLUSTRATION", react.createElement("div", {
        className: "text-gray-400 font-normal md:pl-2",
    }, "WEBSITE BY", react.createElement("a", {
        className: "pl-2 text-blue-500 hover:text-blue-400",
        href: "https://www.heimeshoff.de",
        target: "_blank",
    }, "HEIMESHOFF IT"))));
}

