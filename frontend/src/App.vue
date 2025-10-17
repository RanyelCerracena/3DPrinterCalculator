<script setup>
import TurnBack from './components/TurnBack.vue';

</script>

<template>
    <form class="form">
        <TurnBack/>
        <h1 class="title">Caluladora de Impressões</h1>
        <p class="text">Estime o custo dos seus projetos de impressão 3D com facilidade.</p>

        <section class="card">
            <div class="materialForm">
                <div class="materialWeight">
                    <label for="materialWeight">Peso do material</label>
                    <input type="text" class="input-style" placeholder="Kg" name="materialWeight">
                </div>
                <div class="materialPrice">
                    <label for="materialPrice">Preço do material</label>
                    <input type="text" class="input-style" placeholder="R$" name="materialPrice">
                </div>
            </div>
            <div class="printerForm">
                <div class="printerGrid">
                    <div class="gridItem">
                        <label for="printerModel">Material usado</label>
                        <input id="printerModel" name="printerModel" class="input-style" placeholder="Gramas">
                        <label for="printTime">Tempo de impressão</label>
                        <input id="printTime" name="printTime" class="input-style" placeholder="Horas">
                    </div>

                    <div class="gridItem">
                        <label for="printWeight">Consumo em Watts</label>
                        <input id="printWeight" name="printWeight" class="input-style" placeholder="Watts">
                        <label for="printerCostPerHour">Custo da energia</label>
                        <input id="printerCostPerHour" name="printerCostPerHour" class="input-style" placeholder="kWh">
                    </div>
                </div>
            </div>
            <div class="profitForm">
                    <label for="desiredProfit">Lucro desejado</label>
                    <input id="desiredProfit" name="desiredProfit" class="input-style" placeholder="%">
            </div>
            <button class="calculateButton">
                Calcular
            </button>
            <div class="response input-style">
                <p class="totalWithoutProfit">Total sem Lucro: R$ xx,xx</p>
                <p class="totalWithProfit">Total com Lucro: R$ xx,xx</p>
            </div>
        </section>
    </form>
</template>

<style scoped>
.form {
    display: flex;
    flex-direction: column;
    align-items: center;
    height: 100vh;
    width: 100vw;
    background-color: #f5f5f5;
}
.text,
.title {
    color: #333;
    margin: 0;
}

.text {
    margin-bottom: 20px;
    display: inline-block;
}

.title {
    text-align: center;
    margin-top: 20px;
    font-size: 2rem;
}

.card {
    box-shadow: 0 0px 8px rgba(0, 0, 0, 0.1);
    border-radius: 5px;
    width: auto;
    height: 70dvh;
}

.materialForm {
    display: flex;
    flex-direction: row;
    justify-content: center;
    gap: 20px;
}

.materialWeight,
.materialPrice {
    display: flex;
    flex-direction: column;
    gap: 10px;
}

label,
p {
    color: #555;
}

.input-style {
    padding: 10px;
    border: 2px solid #ccc;
    border-radius: 5px;
    background-color: #f3f3f3;
    font-size: 16px;
    color: #555;
    outline: none;
}

.input-style:focus {
    border-color: #c164ffcb;
    box-shadow: 0 0 0 0.2rem #d400ff2d;
}
.printerGrid{
    display: flex;
    justify-content: center;
    flex-direction: row;
}
.gridItem{
    display: flex;
    flex-direction: column;
    gap: 10px;
    margin: 10px;
}
.profitForm{
    display: flex;
    flex-direction: column;
    align-items: center;
}
.calculateButton{
    margin-top: 50px;
    width: 97%;
    border-radius: 5px;
}
.response{
    margin-top: 50px;
    text-align: center;
}
</style>
