"use strict";
let CardIdAutoIncrement = 1000;
let TravelIdAutoIncrement = 2000;
let TicketIdAutoIncrement = 3000;
let CurrentUser;
let CurrentUserId;
let CurrentUserName;
//PersonalDetails Class
class PersonalDetails {
    constructor(paramUsername, paramUserPhoneNumber, paraUserPassword) {
        this.UserName = paramUsername;
        this.UserPhoneNumber = paramUserPhoneNumber;
        this.UserPassword = paraUserPassword;
    }
}
//UserDetails Class
class UserDetails extends PersonalDetails {
    WalletRecharge(amount) {
        this.Balance += amount;
    }
    DeductBalance(amount) {
        this.Balance -= amount;
    }
    constructor(UserName, UserPhoneNumber, UserPassword) {
        super(UserName, UserPhoneNumber, UserPassword);
        this.Balance = 0;
        this.CardId = "CMRL" + CardIdAutoIncrement++;
    }
}
//TravelDetails Class
class TravelDetails {
    constructor(paramCardId, paramFromLocation, paramToLocation, paramDate, paramTravelFair) {
        this.TravelId = "TID" + TravelIdAutoIncrement;
        this.CardId = paramCardId;
        this.FromLocation = paramFromLocation;
        this.ToLocation = paramToLocation;
        this.Date = paramDate;
        this.TravelFair = paramTravelFair;
    }
}
//TicketFairDetails Class
class TicketFairDetails {
    constructor(paramFromLocation, paramToLocation, paramTravelFair) {
        this.TicketId = "MR" + TicketIdAutoIncrement;
        this.FromLocation = paramFromLocation;
        this.ToLocation = paramToLocation;
        this.TravelFair = paramTravelFair;
    }
}
//UserDetail Array
let UserArrayList = new Array();
UserArrayList.push(new UserDetails("SenthilKumar", 8825816924, "Senthil@123"));
UserArrayList.push(new UserDetails("Bhuvaneshwari", 8903089312, "Bhuvi@123"));
//TravelDetails Array 
let TravelArrayList = new Array(); //Array only created
//TicketFairDetails Array
let TicketFairArrayList = new Array();
TicketFairArrayList.push(new TicketFairDetails("Airport", "Egmore", 55));
TicketFairArrayList.push(new TicketFairDetails("Airport", "Koyambedu", 25));
TicketFairArrayList.push(new TicketFairDetails("Alandur", "Koyambedu", 25));
TicketFairArrayList.push(new TicketFairDetails("Koyambedu", "Egmore", 32));
TicketFairArrayList.push(new TicketFairDetails("Vadapalani", "Egmore", 45));
TicketFairArrayList.push(new TicketFairDetails("Arumbakkam", "Egmore", 25));
TicketFairArrayList.push(new TicketFairDetails("Vadapalani", "Koyambedu", 25));
TicketFairArrayList.push(new TicketFairDetails("Arumbakkam", "Koyambedu", 16));
var homepage = document.getElementById('homepage');
var signup = document.getElementById('signup');
var signupinput = document.getElementById('sign-up');
var signin = document.getElementById('signin');
var signininput = document.getElementById('sign-in');
var menubars = document.getElementById('menubars');
var home = document.getElementById('home-tab');
var travel = document.getElementById('travel-tab');
var cancel = document.getElementById('cancel-tab');
var recharge = document.getElementById('recharge-tab');
var travelhistory = document.getElementById('travel-history-tab');
var showbalance = document.getElementById('show-balance-tab');
var logout = document.getElementById('logout-tab');
var nameInput = document.getElementById('name');
var pwdInput = document.getElementById('pwd');
var phnInput = document.getElementById('phn');
function displayNone() {
    home.style.display = "none";
    travel.style.display = "none";
    recharge.style.display = "none";
    travelhistory.style.display = "none";
    showbalance.style.display = "none";
    logout.style.display = "none";
    cancel.style.display = "none";
}
home.style.display = "none";
travel.style.display = "none";
recharge.style.display = "none";
travelhistory.style.display = "none";
showbalance.style.display = "none";
logout.style.display = "none";
menubars.style.display = "none";
signupinput.style.display = "none";
//signin
function SignIn() {
    signininput.style.display = "block";
    signupinput.style.display = "none";
    let phone = document.getElementById('phn1');
    let password = document.getElementById('pwd1');
    var isflag = true;
    for (var i = 0; i < UserArrayList.length; i++) {
        if (UserArrayList[i].UserPhoneNumber.toString() == phone.value && UserArrayList[i].UserPassword == password.value) {
            var signin = document.getElementById('homepage');
            signin.style.display = "none";
            isflag = false;
            CurrentUser = UserArrayList[i];
            MenuBar();
        }
    }
    if (isflag) {
        alert("Invalid Email or Password");
    }
}
function SignUp() {
    signupinput.style.display = "block";
    signininput.style.display = "none";
    let phone = document.getElementById('phn1');
    var isflag = true;
    for (var i = 0; i < UserArrayList.length; i++) {
        if (UserArrayList[i].UserPhoneNumber.toString() == phone.value) {
            isflag = false;
            break;
        }
    }
    if (isflag == true) {
        let user = new UserDetails(nameInput.value, Number(phnInput.value), pwdInput.value);
        UserArrayList.push(user);
        CurrentUser = user;
        MenuBar();
    }
    if (isflag == false) {
        alert("User Exists");
    }
}
function MenuBar() {
    homepage.style.display = "none";
    menubars.style.display = "block";
}
function Home() {
    displayNone();
    home.style.display = "block";
    document.getElementById('welcome').innerHTML = "Welcome " + CurrentUser.UserName;
}
function Travel() {
    displayNone();
    travel.style.display = "block";
}
function Cancel() {
    displayNone();
    cancel.style.display = "block";
}
function Recharge() {
    displayNone();
    recharge.style.display = "block";
}
function Deposit() {
    var rechargeamount = Number(document.getElementById('recharge-amount').value);
    CurrentUser.WalletRecharge(rechargeamount);
    alert("Rechrged Succesfully");
}
function TravelHistory() {
    displayNone();
    travelhistory.style.display = "block";
}
function ShowBalance() {
    displayNone();
    showbalance.style.display = "block";
    document.getElementById('balance').innerHTML = "Your Balance is " + Number(CurrentUser.Balance);
}
function LogOut() {
    displayNone();
    logout.style.display = "block";
}
function Yes() {
    displayNone();
    menubars.style.display = "none";
    homepage.style.display = "block";
}
function No() {
    displayNone();
    Home();
}
