<template>
    <canvas />
</template>

<script>
import { mapGetters } from "vuex";

export default {
    computed: {
        ...mapGetters([
            "keyboard"
        ])
    },
    created () {
        this.keyboard.onKeyDown("DIRECTION_DOWN", alert);
    }
};
</script>

<style lang="scss"></style>