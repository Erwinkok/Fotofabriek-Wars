import { State } from "../state.td";

export const tryGetKeys = (state : State) => (name: string): string[] => {
    const mapping = state.keyboardMapping.find(km => km.name === name);

    if (mapping == null) {
        throw Error(`Keymap with name "${name}" could not be found.`);
    }

    return mapping.keys;
};