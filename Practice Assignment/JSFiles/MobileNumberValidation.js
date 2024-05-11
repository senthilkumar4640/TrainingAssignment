//  \d - match any digit (equal to [0-9])
//  \w - match any word character (a-z,A-Z,0-9 & _ )
//  \s - match whitespace character (eg- spaces & tabs)
//  \t - match a tab only


function validate()
{
    var text = document.getElementById("input1").value;

    var regex = /^[7-9]\d{9}$/; //starting and ending point

    //another way -- var regex = /^[7-9][0-9]{9}$/; //starting and ending point

    if(regex.test(text))
    {
        document.getElementById("ilabel").innerHTML="Valid";
        document.getElementById("ilabel").style.visibility="visible"
        document.getElementById("ilabel").style.color="green";
    }
    else
    {
        document.getElementById("ilabel").innerHTML="Invalid";
        document.getElementById("ilabel").style.visibility="visible"
        document.getElementById("ilabel").style.color="red";
    }
}