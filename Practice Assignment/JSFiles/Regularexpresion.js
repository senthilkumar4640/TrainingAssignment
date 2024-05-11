function validate()
{
    var username = document.getElementById("input1").value;
    var regex = /E00/; //regular expression representation

    if(regex.test(username))
    {
        alert("Valid Username");
    }
    else
    {
        alert("Invalid Username");
        document.getElementById("ilabel").style.visibility="visible";
    }
}

function validate1()
{
    var username = document.getElementById("input1").value;
    var regex = /[a-x]0[6-9][a-z]/i; //regular expression representation //i-casesensitive
    var regex = /[^1abc]abc/i; //^ exclude that

    if(regex.test(username))
    {
        alert("Valid Username");
    }
    else
    {
        //alert("Invalid Username");
        document.getElementById("ilabel").style.visibility="visible";
    }
}