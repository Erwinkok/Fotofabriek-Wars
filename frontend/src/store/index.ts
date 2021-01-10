import Vue from "vue";
import Vuex from "vuex";
import { state } from "./state.td";
import { getters } from "./getters.td";
import { mutations } from "./mutations.td";

Vue.use(Vuex);

export const store = new Vuex.Store({
    state,
    getters,
    mutations,
    actions: {}
});