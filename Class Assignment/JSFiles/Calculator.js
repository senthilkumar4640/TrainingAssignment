
var a = document.getElementById("result");

function Append(input)
{
    a.value+=input;
}

function clearValue()
{
    a.value = "";
} 

function Calculate()
{
    try
    {
        a.value=eval(a.value);
    }
    catch(error)
    {
        a.value="ERROR";
    }
}