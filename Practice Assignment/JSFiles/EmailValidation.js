//  \d - match any digit (equal to [0-9])
//  \w - match any word character (a-z,A-Z,0-9 & _ )
//  \s - match whitespace character (eg- spaces & tabs)
//  \t - match a tab only


function validate()
{
    var text = document.getElementById("input1").value;

    var regex = /^([a-z 0-9\.-]+)@([a-z0-9-]+).([a-z]{2,8})?$/;

    
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