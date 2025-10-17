<template>
    <a class="buttonTurnBack" href="https://www.nerdstecnologias.com.br">
        <i class="bi bi-arrow-left"></i>
    </a>
</template>

<script setup>
defineOptions({
    name: 'TurnBack'
});
</script>

<style scoped>
.buttonTurnBack {
    position: absolute;
    top: 30px;
    left: 30px;
    z-index: 2;
    border: 2px solid #4e0b7e;
    width: 70px;
    height: 35px;
    display: flex;
    justify-content: center;
    align-items: center;
    border-radius: 5px;
    transition: background-color 0.25s ease-in-out, color 0.25s ease-in-out;
}
.buttonTurnBack:hover{
    background-color: #4e0b7e;
    color: #ffffff;
}
</style>