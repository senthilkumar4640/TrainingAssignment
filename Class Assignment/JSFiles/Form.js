
function TotalValidation()
{
    
    checkform();
    validate();
    GenderCheck();
    Interest();
    passwordCheck();
    mailcheck();
    language();
    userAddress();
    tableVisiblity();

    function checkform()
    {
        var firstname=document.getElementById("FirstName").value;
        var lastname=document.getElementById("LastName").value;
        if(firstname.trim()==""|| lastname.trim()=="")
        {
            alert("user name cannot be blank");
            return false;
        }
        else{
            document.getElementById("fname").innerHTML=firstname;
            document.getElementById("lname").innerHTML=lastname;
            return true;
        }
    }

    function validate()
    {
        
        var phn=document.getElementById("phone").value;
        var testNumber=/^[7-9][0-9]{9}$/;
        if(testNumber.test(phn))
        {
            document.getElementById("Phone2").innerHTML=phn;
            document.getElementById("numcheck").style.visibility="hidden";
            return true;
        }
        else{
            alert("Invalid number");
            document.getElementById("numcheck").style.visibility="visible";
            return false;
        }
    }
    function GenderCheck()
    {
        var gen1=document.getElementById("male");
        var gen2=document.getElementById("female");
        var gen3=document.getElementById("others");
            if(gen1.checked == true)
            {
                document.getElementById("gender2").innerHTML=gen1.value;
            }
            else if(gen2.checked == true)
            {
                document.getElementById("gender2").innerHTML=gen2.value;
            }
            else if(gen3.checked == true)
            {
                document.getElementById("gender2").innerHTML=gen3.value;
            }
            else{
                alert("Gender doesnot selected");
                return false;
            }
            return true;
    }
    function Interest()
    {
        var selectInterest=document.getElementById("intrest");
        var interest=[];
        for(var i=0;i<selectInterest.options.lenght;i++)
        {
            if(selectInterest.options[i].selected)
            {
                interest.push(selectInterest.options[i].value);
            }
        }
        document.getElementById("Interest2").innerHTML=interest.join(",");
        return true;
    }
    function passwordCheck()
    {
        var pass=document.getElementById("password");
        if(pass.value.trim("")=="")
        {
            alert("blank password");
            pass.style.border="2px solid red";
            document.getElementById("pass1").style.visibility="visible";
            return false;
        }
        else if(pass.value.trim().Lenght<5)
        {
            alert("password is too short");
            pass.style.border="2px solid red";
            return false;
        }
        else{
            document.getElementById("password2").innerHTML=pass.value;
            return true;
        }
    }
    function mailcheck()
    {
        var getEmail=document.getElementById("mailId").value;
        {
            var regx=/^([a-zA-Z0-9\.-]+)@([a-zA-Z0-9-]+).([a-z]{2,20})$/;
            if(regx.test(getEmail))
            {
                document.getElementById("mail2").innerHTML=getEmail;
                document.getElementById("mail1").style.color="green";
                return true;
            }
            else{
                document.getElementById("mail1").style.visibility="visible";
                return false;
            }
        }
    }
    function language()
    {
        var lang1=document.getElementById("tamil");
        var lang2=document.getElementById("english");
        var lang3=document.getElementById("french");
        var alllang=[];

        if(lang1.checked)
        {
            alllang.push(lang1.value);
        }
        if(lang2.checked)
        {
            alllang.push(lang2.value);
        }
        if(lang3.checked)
        {
            alllang.push(lang3.value);
        }
        for(var i=0;i<alllang.length;i++){
            document.getElementById("language2").innerHTML=alllang.join(",")
        }
        return true;
    }
    function userAddress()
    {
        document.getElementById("caddress").innerHTML=document.getElementById("add").value;
        document.getElementById("dob2").innerHTML=document.getElementById("dob").value;
        document.getElementById("time2").innerHTML=document.getElementById("time").value;
        return true;
    }
    function tableVisiblity()
    {
        if(checkform() && validate() && GenderCheck() && Interest() && passwordCheck() && mailcheck() && language() && userAddress())
        {
            alert("All are correct");
            document.getElementById("table").style.display="block";
            document.getElementById("mainform").style.display="none";
        }
    }
}
