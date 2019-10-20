// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('#postValues').click(function () {
    var band1Value = document.getElementById("band1").value;
    var band2Value = document.getElementById("band2").value;
    var multiplierValue = document.getElementById("multiplier").value;
    var toleranceValue = document.getElementById("tolerance").value;
    debugger;
    var inputValues = { Band1: band1Value, Band2: band2Value, Multiplier: multiplierValue, Tolerance: toleranceValue }
    $.ajax({
        type: "POST",
        async: false,
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(inputValues),
        url: "Calculator/Calculate",
        success: function (data) {
            $('.result input').val(data);
        }
    })         
})
