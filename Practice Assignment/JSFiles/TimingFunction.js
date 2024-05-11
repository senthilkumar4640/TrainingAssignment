var ID = 0;
var seconds = 0;

//setTimeout and clearTimeout
function printMsg()
{
    document.getElementById("op").innerHTML="5 seconds passed";
}

function start()
{
    //window object
    ID = window.setTimeout(printMsg,5000);
}

function stop()
{
    //window object
    window.clearTimeout(ID);
}

//setInterval and clearTimeout
function printMsg1()
{
    document.getElementById("op").innerHTML=seconds+" seconds";
    seconds++;
}

function start1()
{
    //window object
    ID = window.setInterval(printMsg1,1000);
}

function stop1()
{
    //window object
    window.clearInterval(ID);
}