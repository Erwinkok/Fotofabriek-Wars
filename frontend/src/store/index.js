import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

const store = new Vuex.Store({
    state: {
        world: {
            tileWidth: 32,
            image: "/assets/worlds/starting-world.png",
            startingPosition: {
                x: 4,
                y: 4
            }
        }
    },
    getters: {},
    mutations: {},
    actions: {}
});

export default store;