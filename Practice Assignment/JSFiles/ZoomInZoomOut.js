var width = 100;
var difference = 2;
var intervalID = 0;
//document.getElementById("img1").style.width=width1;

function increase()
{
    clearInterval(intervalID);
    intervalID = setInterval(zoomIn,20);
}

function decrease()
{
    clearInterval(intervalID);
    intervalID = setInterval(zoomOut,20);
}

function zoomIn()
{
    if(width<200)
    {
        width=width+difference;
        document.getElementById("img1").style.width=width;
    }
    else
    {
        clearInterval(intervalID);
    }
}

function zoomOut()
{
    if(width>100)
    {
        width=width-difference;
        document.getElementById("img1").style.width=width;
    }
    else
    {
        clearInterval(intervalID);
    }
}

