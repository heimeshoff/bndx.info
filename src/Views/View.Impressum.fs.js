import * as react from "react";

export function impressum(model, dispatch) {
    return react.createElement("div", {
        className: "bg-grey-lighter",
        id: "kontakt",
    }, react.createElement("div", {
        className: "mb-8 w-4/5 lg:w-2/3 xl:w-1/2 flex flex-col md:flex-row items-center justify-center",
    }, react.createElement("div", {
        className: "pt-20 pb-4 w-full rounded-lg shadow-md bg-white",
    }, react.createElement("h2", {}, "Impressum"), react.createElement("p", {
        className: "italic",
    }, "Impressive, I know"))));
}

