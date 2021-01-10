import { State } from "../state.td";

export function modifyKeyBinding (state: State, payload: { name: string, newKey: string, replaceKey: string | null }) {

    const indexOfKeyBinding = state.keyboardMapping.findIndex(km => km.name === payload.name);

    if (payload.replaceKey !== null) {
        const keyIndex = state.keyboardMapping[indexOfKeyBinding].keys.indexOf(payload.replaceKey);

        state.keyboardMapping[indexOfKeyBinding].keys[keyIndex] = payload.newKey;
    } else {
        state.keyboardMapping[indexOfKeyBinding].keys.push(payload.newKey);
    }
}