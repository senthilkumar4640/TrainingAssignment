function fn1()
{
    var para = document.getElementsByTagName("p");
    // para[0].style.fontSize = 100;
    // para[1].style.color="red";
    // para[2].style.fontWeight="bold";
    // para[3].style.fontSize = 25;

    for(var i=0; i<para.length;i++)
    {
        para[i].style.fontSize=22;
    }
}