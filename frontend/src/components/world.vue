<template>
    <div class="world">
        <img :src="world.image" :style="style.transform" />
    </div>
</template>

<script lang="ts">
import { mapState } from "vuex";

export default {
    computed: {
        ...mapState(["world"]),
        style () {
            const xOffset = this.world.startingPosition.x * this.world.tileWidth;
            const yOffset = this.world.startingPosition.y * this.world.tileWidth;

            return {
                transform: `transform: translate3d(-${xOffset}px, -${yOffset}px, 0px);`
            };
        }
    }
};
</script>

<style>
.world {
    position: relative;
    display: flex;
    justify-content: center;
    align-items: center;
    width: 100%;
}

.world img {
    width: 80%;
}
</style>