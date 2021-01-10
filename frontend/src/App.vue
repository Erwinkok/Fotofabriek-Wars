<template>
    <div class="game">
        <World />
    </div>
</template>

<script>
import World from "@/components/world";

export default {
    components: {
        World
    }
};
</script>

<style>
* {
    image-rendering: pixelated;
    image-rendering: crisp-edges;
}

.game {
    position: absolute;
    width: 100%;
    height: 100%;
    background-color: lightgray;
    display: flex;
    align-items: center;
    justify-content: center;
}
</style>