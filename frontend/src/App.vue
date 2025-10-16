<script setup>

</script>

<template>
    <form class="form">
        <h1 class="title">Caluladora de Impressões</h1>
        <p class="text">Estime o custo dos seus projetos de impressão 3D com facilidade.</p>

        <section class="card">
            <div class="materialForm">
                <div class="materialWeightInput">
                    <label for="materialWeight"></label>
                    <input type="text" name="materialWeight">
                </div>
                //https://drive.google.com/file/d/1fX5S4aeiUGQjj6bNSgKNjTogQ7MSJ74F/view?usp=drive_link
                <input type="text">
            </div>
        </section>
    </form>
</template>

<style scoped>
.form{
    display: flex;
    flex-direction: column;
    align-items: center;
    height: 100vh;
    width: 100vw;
    background-color: #f5f5f5;
}


.text, .title{
    color: #333;
    margin: 0;
}

.text{
    margin-bottom: 20px;
    display: inline-block;
}

.title{
    text-align: center;
    margin-top: 20px;
    font-size: 2rem;
}
.card{
    box-shadow: 0 0px 8px rgba(0, 0, 0, 0.1);
    border-radius: 5px;
    width:  90%;
    height: 70dvh;
}
.materialForm{
    display: flex;
    flex-direction: column;
    gap: 20px;
    padding: 20px;
}
</style>
