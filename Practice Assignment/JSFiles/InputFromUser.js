function fn1()
{
    var str = document.getElementById("text1").value;
    alert(str);
}

function fn2()
{
    var str1 = document.getElementById("text1").value;
    var str2 = document.getElementById("text2").value;
    if(str1==str2)
    {
        alert("Match")
    }
    else
    {
        alert("Not match")
    }
}