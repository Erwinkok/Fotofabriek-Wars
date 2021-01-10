import { keyboard } from "./getters/keyboard.td";
import { tryGetKeys } from "./getters/tryGetKeys.td";

export const getters = {
    keyboard,
    tryGetKeys
};

export type Getters = {
    keyboard: Function,
    tryGetKeys: Function
};