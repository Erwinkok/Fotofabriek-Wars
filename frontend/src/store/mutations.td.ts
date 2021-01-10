import { modifyKeyBinding } from "./mutations/modifyKeyBinding.td";

export const mutations = {
    MODIFY_KEY_BINDING: modifyKeyBinding
};

export type Mutations = typeof mutations;