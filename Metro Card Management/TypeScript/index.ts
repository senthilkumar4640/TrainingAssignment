let CardIdAutoIncrement = 1000;
let TravelIdAutoIncrement = 2000;
let TicketIdAutoIncrement = 3000;
let CurrentUser: UserDetails;
let CurrentUserId: string;
let CurrentUserName: string;

//PersonalDetails Class
class PersonalDetails
{
    UserName : string;
    UserPhoneNumber : number;
    UserPassword : string;
    constructor(paramUsername:string, paramUserPhoneNumber:number, paraUserPassword:string)
    {
        this.UserName = paramUsername;
        this.UserPhoneNumber = paramUserPhoneNumber;
        this.UserPassword = paraUserPassword;
    }
}

//IBalance Interface
interface IBalance
{
    Balance:number;
    WalletRecharge(amount:number):void;
    DeductBalance(amount:number):void; 
}

//UserDetails Class
class UserDetails extends PersonalDetails  implements IBalance{
    WalletRecharge(amount:number): void {
        this.Balance +=amount;
    }
 
    DeductBalance(amount:number): void {
        this.Balance-=amount;
    }
   CardId:string;
   Balance: number = 0;
   constructor(UserName:string, UserPhoneNumber:number,UserPassword:string)
   {
    super(UserName,UserPhoneNumber,UserPassword)
    this.CardId = "CMRL"+CardIdAutoIncrement++;
   }

  
}


//TravelDetails Class
class TravelDetails{
    TravelId : string;
    CardId : string;
    FromLocation : string;
    ToLocation : string;
    Date : Date;
    TravelFair:number
    constructor(paramCardId:string,paramFromLocation:string,paramToLocation:string,paramDate:Date,paramTravelFair:number)
    {
        this.TravelId = "TID"+TravelIdAutoIncrement;
        this.CardId = paramCardId;
        this.FromLocation = paramFromLocation;
        this.ToLocation = paramToLocation;
        this.Date = paramDate;
        this.TravelFair = paramTravelFair;
    }
}

//TicketFairDetails Class
class TicketFairDetails{
    TicketId : string;
    FromLocation : string;
    ToLocation : string;
    TravelFair:number
    constructor(paramFromLocation:string,paramToLocation:string,paramTravelFair:number)
    {
        this.TicketId = "MR"+TicketIdAutoIncrement;
        this.FromLocation = paramFromLocation;
        this.ToLocation = paramToLocation;
        this.TravelFair = paramTravelFair;
    }
}

//UserDetail Array
let UserArrayList : Array<UserDetails> = new Array<UserDetails>();
UserArrayList.push(new UserDetails("SenthilKumar",8825816924,"Senthil@123"));
UserArrayList.push(new UserDetails("Bhuvaneshwari",8903089312,"Bhuvi@123"));

//TravelDetails Array 
let TravelArrayList : Array<TravelDetails> = new Array<TravelDetails>();//Array only created

//TicketFairDetails Array
let TicketFairArrayList : Array<TicketFairDetails> = new Array<TicketFairDetails>();
TicketFairArrayList.push(new TicketFairDetails("Airport","Egmore",55))
TicketFairArrayList.push(new TicketFairDetails("Airport","Koyambedu",25))
TicketFairArrayList.push(new TicketFairDetails("Alandur","Koyambedu",25))
TicketFairArrayList.push(new TicketFairDetails("Koyambedu","Egmore",32))
TicketFairArrayList.push(new TicketFairDetails("Vadapalani","Egmore",45))
TicketFairArrayList.push(new TicketFairDetails("Arumbakkam","Egmore",25))
TicketFairArrayList.push(new TicketFairDetails("Vadapalani","Koyambedu",25))
TicketFairArrayList.push(new TicketFairDetails("Arumbakkam","Koyambedu",16))

var homepage = document.getElementById('homepage') as HTMLDivElement;
var signup = document.getElementById('signup') as HTMLDivElement;
var signupinput = document.getElementById('sign-up') as HTMLDivElement;
var signin = document.getElementById('signin') as HTMLDivElement;
var signininput = document.getElementById('sign-in') as HTMLDivElement;

var menubars= document.getElementById('menubars') as HTMLDivElement;

var home = document.getElementById('home-tab') as HTMLDivElement;
var travel = document.getElementById('travel-tab') as HTMLDivElement;
var cancel = document.getElementById('cancel-tab') as HTMLDivElement;
var recharge = document.getElementById('recharge-tab') as HTMLDivElement;
var travelhistory = document.getElementById('travel-history-tab') as HTMLDivElement;
var showbalance = document.getElementById('show-balance-tab') as HTMLDivElement;
var logout = document.getElementById('logout-tab') as HTMLDivElement;

var nameInput = document.getElementById('name') as HTMLInputElement
var pwdInput = document.getElementById('pwd') as HTMLInputElement
var phnInput = document.getElementById('phn') as HTMLInputElement



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
function SignIn()
{
    signininput.style.display = "block"
    signupinput.style.display = "none"
    let phone = document.getElementById('phn1') as HTMLInputElement;
    let password = document.getElementById('pwd1') as HTMLInputElement;
    var isflag: boolean = true;
    for (var i = 0; i < UserArrayList.length; i++) {
        if (UserArrayList[i].UserPhoneNumber.toString() == phone.value && UserArrayList[i].UserPassword == password.value) {
            var signin = document.getElementById('homepage') as HTMLDivElement;
            signin.style.display = "none";
            isflag = false;
            CurrentUser = UserArrayList[i];
            MenuBar();
        }
    }
    if (isflag) {
        alert("Invalid Email or Password")
    }
}

function SignUp()
{
    signupinput.style.display = "block"
    signininput.style.display = "none"
    let phone = document.getElementById('phn1') as HTMLInputElement;
    var isflag: boolean = true;
    for (var i = 0; i < UserArrayList.length; i++) {
        if (UserArrayList[i].UserPhoneNumber.toString() == phone.value) {
            isflag = false;
            break
        }
    }
    if (isflag == true) {
        let user: UserDetails = new UserDetails(nameInput.value, Number(phnInput.value), pwdInput.value);
        UserArrayList.push(user);
        CurrentUser = user;
        MenuBar();

    }
    if (isflag == false) {
        alert("User Exists");
    }
}
    
function MenuBar()
{
    homepage.style.display = "none"
    menubars.style.display = "block"
}

function Home()
{
    displayNone();
    home.style.display = "block";
    (document.getElementById('welcome') as HTMLHeadElement).innerHTML = "Welcome "+CurrentUser.UserName
}

function Travel()
{
    displayNone()
    travel.style.display = "block";

    
}

function Cancel()
{
    displayNone()
    cancel.style.display = "block";
}

function Recharge()
{
    displayNone()
    recharge.style.display = "block";
}
function Deposit()
{
    var rechargeamount : number = Number((document.getElementById('recharge-amount') as HTMLInputElement).value)
    CurrentUser.WalletRecharge(rechargeamount)
    alert("Rechrged Succesfully")
}

function TravelHistory()
{
    displayNone();
    travelhistory.style.display = "block";
}

function ShowBalance()
{
    displayNone();
    showbalance.style.display = "block";
    (document.getElementById('balance') as HTMLHeadElement).innerHTML = "Your Balance is "+Number(CurrentUser.Balance)
}




