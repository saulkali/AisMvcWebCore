var urlBase = "http://localhost:5065/api/Calculadora/";
var arrayNumeros = [];

function obtenerFactorialAjax() {
    var number = document.getElementById("number").value;
    $.ajax({
        url: urlBase + number,
        dataType: 'text',
        type: 'get',
        success: response => alert(response),
        error: error => alert("Ingrese un valor valido: " + error)
    });
}

function AgregarNumero() {
    var number = document.getElementById("number").value;
    arrayNumeros.push(number);
    document.getElementById("number").value = "";
}

function OrdenarNumeros() {
    $.ajax({
        url: urlBase + number,
        dataType: 'text',
        data: { arrayNumeros: JSON.stringify(arrayNumeros) },
        contentType:"application/json",
        type: 'post',
        success: response => alert(response),
        error: error => alert("Ingrese un valor valido: " + error)
    });
}