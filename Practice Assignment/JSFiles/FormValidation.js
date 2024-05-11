function validate1()
{
    var username = document.getElementById("input1");
    var password = document.getElementById("input2");

    if(username.value.trim()=="" || password.value.trim()=="")
    {
        alert("No blank values allowed");
        return false;
    }
    else
    {
        true;
    }
}

function validate2()
{
    var username = document.getElementById("input1");
    var password = document.getElementById("input2");

    if(username.value.trim()=="")
    {
        alert("Username Blank");
        username.style.border="2px solid red"
        document.getElementById("ilabel").style.visibility="visible";
        return false;
    }
    else if(password.value.trim()=="")
    {
        alert("Password Blank");
        password.style.border="2px solid red"
        return false;
    }
    else if(password.value.trim().length<5)
    {
        alert("Password is too short");
        password.style.border="2px solid red"
        return false;
    }
    else
    {
        return true;
    }
}