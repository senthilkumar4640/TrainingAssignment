//assigning
let a = document.getElementById("input1");
let b = document.getElementById("input2");
let c = document.getElementById("result");

//addition
function addition()
{
    let d = parseFloat(a.value) + parseFloat(b.value)
    result.value=d;
}

//subtraction
function subtraction()
{
    let d = parseFloat(a.value) - parseFloat(b.value)
    result.value=d;
}

//multiplication
function multiplication()
{
    let d = parseFloat(a.value) * parseFloat(b.value)
    result.value=d;
}

//division
function division()
{
    let d = parseFloat(a.value) / parseFloat(b.value)
    result.value=d;
}

//clear
function clearValue()
{
    a.value = "";
    b.value = "";
    c.value = "";
} 