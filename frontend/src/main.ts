import Vue from "vue";
import App from "./App.vue";
import { store } from "./store";

new Vue({
    render: h => h(App),
    store,
    created () {
    }
}).$mount(document.body);
