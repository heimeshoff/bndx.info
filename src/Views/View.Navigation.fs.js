import * as react from "react";
import { Page, Msg } from "../Types.fs.js";
import { ofSeq, ofArray } from "../.fable/fable-library.3.0.1/List.js";
import { empty, singleton, append, delay } from "../.fable/fable-library.3.0.1/Seq.js";

export function anchor(dispatch, label) {
    return react.createElement("div", {
        className: "p-4 text-2xl w-full lg:w-auto border-b-2 border-transparent hover:border-red-700 cursor-pointer",
        onClick: (e) => {
            e.stopPropagation();
            dispatch(new Msg(3, label.toLocaleLowerCase()));
        },
    }, label);
}

export const bild = react.createElement("div", {
    className: "w-64 m-4 p-2 flex flex-col items-center floating-action-button cursor-pointer bg-white",
}, react.createElement("img", {
    className: "w-64 h-64 object-cover",
    src: "https://bndx.info/wp-content/uploads/2020/09/heimeshoff_it-1.jpg",
}), react.createElement("div", {
    className: "text-center",
}, "Demns "));

export function links(model, dispatch) {
    return ofArray([anchor(dispatch, "Portfolio"), anchor(dispatch, "Kontakt")]);
}

export function brand_logo(dispatch) {
    return react.createElement("div", {
        className: "text-2xl font-bold text-gray-800 p-4 ml-4 cursor-pointer border-b-2 border-transparent hover:border-red-700",
        onClick: (_arg1) => {
            dispatch(new Msg(2, new Page(0)));
        },
    }, "BNDX", react.createElement("span", {
        className: "ml-2 font-normal",
    }, "ILLUSTRATION"));
}

export function toggle_menu(dispatch) {
    return react.createElement("button", {
        className: "flex-no-shrink flex items-center m-4 px-3 py-2 border-2 rounded-md hover:text-red-700 hover:border-red-700 hover:text-blue-light hover:border-blue-light focus:outline-none",
        onClick: (e) => {
            e.stopPropagation();
            dispatch(new Msg(0));
        },
    }, react.createElement("svg", {
        className: "fill-current h-4 w-4",
        viewBox: "0 0 20 20",
        xmlns: "http://www.w3.org/2000/svg",
    }, react.createElement("path", {
        d: "M0 3h20v2H0V3zm0 6h20v2H0V9zm0 6h20v2H0v-2z",
    })));
}

export function mobile_menu(dispatch, model) {
    return react.createElement("div", {
        className: "lg:hidden",
    }, ...ofSeq(delay(() => append(singleton(react.createElement("div", {
        className: "flex flex-row items-center justify-between",
    }, brand_logo(dispatch), toggle_menu(dispatch))), delay(() => (model.menu_open ? singleton(react.createElement("div", {
        className: "flex flex-col items-center space-y-4 pl-4",
    }, ...links(model, dispatch))) : empty()))))));
}

export function desktop_model(dispatch, model) {
    return react.createElement("div", {
        className: "hidden lg:block w-full",
    }, react.createElement("div", {
        className: "flex flex-row justify-between",
    }, brand_logo(dispatch), react.createElement("div", {
        className: "hidden lg:flex flex-row items-center space-x-4 pr-8",
    }, ...links(model, dispatch))));
}

export function navbar(dispatch, model) {
    return react.createElement("div", {
        className: "z-50 fixed w-full glass-dense bg-white bg-opacity-50 shadow-lg",
    }, mobile_menu(dispatch, model), desktop_model(dispatch, model));
}

