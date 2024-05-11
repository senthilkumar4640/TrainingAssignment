function fn1()
{
    var element = document.getElementsByClassName("mypara");
    for(var i=0; i<element.length;i++)
    {
        element[i].style.color="red";
    }
}