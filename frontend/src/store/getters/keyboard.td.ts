import { State } from "../state.td";
import { Getters } from "../getters.td";

export const keyboard = (state: State, getters: Getters): { onKeyPress : Function, onKeyDown: Function, onKeyUp: Function } => {
    const matchKey = (name: string, key: string): boolean => {
        return getters.tryGetKeys(name)?.includes(key);
    };

    return {
        onKeyPress: (name: string, callback: Function) => {
            window.addEventListener("keypress", (event: KeyboardEvent) => {
                if (matchKey(name, event.key)) {
                    callback(event);
                }
            });
        },
        onKeyDown (name: string, callback: Function) {
            window.addEventListener("keydown", (event: KeyboardEvent) => {
                if (matchKey(name, event.key)) {
                    callback(event);
                }
            });
        },
        onKeyUp (name: string, callback: Function) {
            window.addEventListener("keyup", (event: KeyboardEvent) => {
                if (matchKey(name, event.key)) {
                    callback(event);
                }
            });
        }
    };
};