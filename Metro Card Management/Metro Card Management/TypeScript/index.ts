let CurrentUser: UserDetails;


//UserDetails Class
interface UserDetails {
    cardID: any;
    userName: string;
    userPhoneNumber: string;
    userPassword: string;
    balance: number;
}


//TravelDetails Class
interface TravelDetails {
    travelID: any;
    cardID: number;
    fromLocation: string;
    toLocation: string;
    travelDate: string;
    travelFair: number
}

//TicketFairDetails Class
interface TicketFairDetails {
    ticketID: any;
    fromLocation: string;
    toLocation: string;
    ticketFair: number
}

//TicketFairDetails Array
// let TicketFairArrayList : Array<TicketFairDetails> = new Array<TicketFairDetails>();
// TicketFairArrayList.push(new TicketFairDetails("Airport","Egmore",55))
// TicketFairArrayList.push(new TicketFairDetails("Airport","Koyambedu",25))
// TicketFairArrayList.push(new TicketFairDetails("Alandur","Koyambedu",25))
// TicketFairArrayList.push(new TicketFairDetails("Koyambedu","Egmore",32))
// TicketFairArrayList.push(new TicketFairDetails("Vadapalani","Egmore",45))
// TicketFairArrayList.push(new TicketFairDetails("Arumbakkam","Egmore",25))
// TicketFairArrayList.push(new TicketFairDetails("Vadapalani","Koyambedu",25))
// TicketFairArrayList.push(new TicketFairDetails("Arumbakkam","Koyambedu",16))

//fetch UserDetails
async function fetchUser(): Promise<UserDetails[]> {
    const apiUrl = 'http://localhost:5149/api/UserDetails';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('Failed to fetch userdetails');
    }
    return await response.json();
}

//fetch TravelDetails
async function fetchTravel(): Promise<TravelDetails[]> {
    const apiUrl = 'http://localhost:5149/api/TravelDetails';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('Failed to fetch traveldetails');
    }
    return await response.json();
}

//fetch TicketFairDetails
async function fetchTicket(): Promise<TicketFairDetails[]> {
    const apiUrl = 'http://localhost:5149/api/TicketFairDetails';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('Failed to fetch ticketfairdetails');
    }
    return await response.json();
}


//add user
async function addUser(user: UserDetails): Promise<void> {
    const response = await fetch('http://localhost:5149/api/UserDetails', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(user)

    });
    if (!response.ok) {
        throw new Error('Failed to add user');
    }
}

//update balance
async function updateAmount(id: number, amt: number): Promise<void> {
    const response = await fetch(`http://localhost:5149/api/UserDetails/${id}/${amt}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(amt)
    });
    if (!response.ok) {
        throw new Error('Failed to update balance');
    }
}

//update user
async function updateUser(id: number, user: UserDetails): Promise<void> {
    const response = await fetch(`http://localhost:5149/api/UserDetails/${id}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(user)
    });
    if (!response.ok) {
        throw new Error('Failed to update userdetails');
    }
}

//add tictetfair
async function addTicket(ticket: TicketFairDetails): Promise<void> {
    const response = await fetch('http://localhost:5149/api/TicketFairDetails', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(ticket)
    });
    if (!response.ok) {
        throw new Error('Failed to add ticket');
    }

    Ticket();
}

//edit ticketfair
async function updateTicket(id: number, ticket: TicketFairDetails): Promise<void> {
    const response = await fetch(`http://localhost:5149/api/TicketFairDetails/${id}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(ticket)
    });
    if (!response.ok) {
        throw new Error('Failed to update ticket');
    }
    Ticket();
}
//delete ticketfair
async function deleteTicket(id: number): Promise<void> {
    const response = await fetch(`http://localhost:5149/api/TicketFairDetails/${id}`, {
        method: 'DELETE'
    });
    if (!response.ok) {
        throw new Error('Failed to delete ticket');
    }
    Ticket();
}

//add travel
async function addTravel(travel: TravelDetails): Promise<void> {
    const response = await fetch('http://localhost:5149/api/TravelDetails', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(travel)

    });
    if (!response.ok) {
        throw new Error('Failed to add travel');
    }
}

//edit travel
async function updateTravel(id: number, travel: TravelDetails): Promise<void> {
    const response = await fetch(`http://localhost:5149/api/TravelDetails/${id}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(travel)
    });
    if (!response.ok) {
        throw new Error('Failed to update ticket');
    }
    // renderContacts();
}




var homepage = document.getElementById('homepage') as HTMLDivElement;
var signup = document.getElementById('signup') as HTMLDivElement;
var signupinput = document.getElementById('sign-up') as HTMLDivElement;
var signin = document.getElementById('signin') as HTMLDivElement;
var signininput = document.getElementById('sign-in') as HTMLDivElement;

var menubars = document.getElementById('menubars') as HTMLDivElement;

var home = document.getElementById('home-tab') as HTMLDivElement;
var ticket = document.getElementById('ticket-tab') as HTMLDivElement;
var travel = document.getElementById('travel-tab') as HTMLDivElement;
var recharge = document.getElementById('recharge-tab') as HTMLDivElement;
var travelhistory = document.getElementById('travel-history-tab') as HTMLDivElement;
var showbalance = document.getElementById('show-balance-tab') as HTMLDivElement;
var logout = document.getElementById('logout-tab') as HTMLDivElement;

var nameInput = document.getElementById('name') as HTMLInputElement
var pwdInput = document.getElementById('pwd') as HTMLInputElement
var cnfpwdInput = document.getElementById('cnfpwd') as HTMLInputElement
var phnInput = document.getElementById('phn') as HTMLInputElement

var addbutton = document.getElementById('add') as HTMLDivElement;
var editbutton = document.getElementById('edit') as HTMLDivElement;

let rechargeAmount = document.getElementById('recharge-amount') as HTMLInputElement;
let rechargebutton = document.getElementById('rechargebutton') as HTMLInputElement;


home.style.display = "none";
ticket.style.display = "none";
travel.style.display = "none";
recharge.style.display = "none";
travelhistory.style.display = "none";
showbalance.style.display = "none";
logout.style.display = "none";
menubars.style.display = "none";
signupinput.style.display = "none";
addbutton.style.display = "none";
editbutton.style.display = "none";
rechargeAmount.style.display = "none";
rechargebutton.style.display = "none";

function displayNone() {
    home.style.display = "none";
    ticket.style.display = "none";
    travel.style.display = "none";
    recharge.style.display = "none";
    travelhistory.style.display = "none";
    showbalance.style.display = "none";
    logout.style.display = "none";
}

//signup
async function SignUp() {
    signupinput.style.display = "block"
    signininput.style.display = "none"
}

let editingID: number | null = null;
//signupsubmit
async function SignUpSubmit() {
    const name = nameInput.value.trim();
    const password = pwdInput.value.trim();
    const phone = phnInput.value.trim();
    if (editingID !== null) {
        const user: UserDetails = {
            cardID: editingID,
            userName: name,
            userPassword: password,
            userPhoneNumber: phone,
            balance: 0
        };
        updateUser(editingID, user);
    }
    else {
        const user: UserDetails = {
            cardID: undefined,
            userName: name,
            userPassword: password,
            userPhoneNumber: phone,
            balance: 0
        };
        addUser(user);
        alert("User Registered Successfully");
    }
    nameInput.value = "";
    phnInput.value = "";
    pwdInput.value = "";
    cnfpwdInput.value = "";
    SignIn();

}

//Signin
async function SignIn() {
    signupinput.style.display = "none"
    signininput.style.display = "block"
}

//SignInSubmit
async function SignInSubmit() {
    const UserList = await fetchUser();
    let phone = document.getElementById('phn1') as HTMLInputElement;
    let password = document.getElementById('pwd1') as HTMLInputElement;
    let isFlag: boolean = true

    for (var i = 0; i < UserList.length; i++) {
        if (UserList[i].userPhoneNumber == phone.value && UserList[i].userPassword == password.value) {
            CurrentUser = UserList[i];
            isFlag = false;
            phone.value = "";
            password.value = "";
        }
    }
    if (isFlag) {
        alert("Invalid Phone or Password")
    }

    else {
        alert("Signed In Successfully");

        MenuBar();
    }
}

//MenuBar
async function MenuBar() {
    menubars.style.display = "block"
    homepage.style.display = "none"
}

//Home
function Home() {
    displayNone();
    home.style.display = "block";
    (document.getElementById('welcome') as HTMLHeadElement).innerHTML = "Welcome " + CurrentUser.userName
}

//ticket
async function Ticket() {
    displayNone();
    const TicketFairList = await fetchTicket();
    ticket.style.display = "block";
    let Table = document.getElementById('ticket-table') as HTMLTableElement
    Table.innerHTML = "";
    let headRow = document.createElement('tr');
    headRow.innerHTML =
        `
    <th>From Location</th>
    <th>To Location</th>
    <th>Ticket Fair</th>
    <th>Edit</th>
    <th>Delete</th>`
    Table.appendChild(headRow);

    for (var i = 0; i < TicketFairList.length; i++) {
        let bodyRow = document.createElement('tr');
        bodyRow.innerHTML =
            `
            <td>${TicketFairList[i].fromLocation}</td>
            <td>${TicketFairList[i].toLocation}</td>
            <td>${TicketFairList[i].ticketFair}</td>
            <td><button onclick="EditButton(${i})">Edit</button></td>
            <td><button onclick="DeleteButton(${TicketFairList[i].ticketID})">Delete</button></td>
            `;
        Table.appendChild(bodyRow);
    }
}

//addbuttton
function AddButton() {
    addbutton.style.display = "block";
    editbutton.style.display = "none";
}

//submit in add details
async function AddSubmit() {
    let fromLocationAdd = document.getElementById('ticket-from') as HTMLInputElement;
    let toLocationAdd = document.getElementById('ticket-to') as HTMLInputElement;
    let ticketFairAdd = document.getElementById('ticket-fair') as HTMLInputElement;
    const ticket: TicketFairDetails = {
        ticketID: undefined,
        fromLocation: fromLocationAdd.value,
        toLocation: toLocationAdd.value,
        ticketFair: Number(ticketFairAdd.value)
    }
    addTicket(ticket);
    fromLocationAdd.value = "";
    toLocationAdd.value = "";
    ticketFairAdd.value = "";
    Ticket();
}

let ticketIndex: number = 0;
//edit button in table
async function EditButton(count: number) {
    const TicketFairList = await fetchTicket();
    editbutton.style.display = "block"
    addbutton.style.display = "none"
    ticketIndex = count;
    for (var i = 0; i < TicketFairList.length; i++) {
        if (i == ticketIndex) {
            (document.getElementById('ticket-from-edit') as HTMLInputElement).value = TicketFairList[i].fromLocation.toString();
            (document.getElementById('ticket-to-edit') as HTMLInputElement).value = TicketFairList[i].toLocation.toString();
            (document.getElementById('ticket-fair-edit') as HTMLInputElement).value = TicketFairList[i].ticketFair.toString();
        }
    }
}

//submit in edit details
async function EditSubmit() {
    const TicketFairList = await fetchTicket();
    for (var i = 0; i < TicketFairList.length; i++) {
        if (i == ticketIndex) {
            TicketFairList[i].fromLocation = (document.getElementById('ticket-from-edit') as HTMLInputElement).value;
            TicketFairList[i].toLocation = (document.getElementById('ticket-to-edit') as HTMLInputElement).value;
            TicketFairList[i].ticketFair = Number((document.getElementById('ticket-fair-edit') as HTMLInputElement).value);

            updateTicket(TicketFairList[i].ticketID, TicketFairList[i]);
            (document.getElementById('ticket-from-edit') as HTMLInputElement).value = "";
            (document.getElementById('ticket-to-edit') as HTMLInputElement).value = "";
            (document.getElementById('ticket-fair-edit') as HTMLInputElement).value = "";
            Ticket();
        }
    }

}

//delete
function DeleteButton(count: number) {
    deleteTicket(count);
    Ticket();
}

//travel
async function Travel() {
    const TicketFairList = await fetchTicket();
    displayNone();
    travel.style.display = "block";
    let Table = document.getElementById('travel-table') as HTMLTableElement
    Table.innerHTML = "";
    let headRow = document.createElement('tr');
    headRow.innerHTML =
        `
    <th>From Location</th>
    <th>To Location</th>
    <th>Ticket Fair</th>
    <th>Action</th>`
    Table.appendChild(headRow);

    for (var i = 0; i < TicketFairList.length; i++) {
        let bodyRow = document.createElement('tr');
        bodyRow.innerHTML =
            `
            <td>${TicketFairList[i].fromLocation}</td>
            <td>${TicketFairList[i].toLocation}</td>
            <td>${TicketFairList[i].ticketFair}</td>
            <td><button onclick="buy(${i})">Buy</button></td>
            `;
        Table.appendChild(bodyRow);
    }
}

//Buy
async function buy(count: number) {
    const TicketFairList = await fetchTicket();
    for (var i = 0; i < TicketFairList.length; i++) {
        if (i == count) {
            if (CurrentUser.balance >= TicketFairList[i].ticketFair) {
                CurrentUser.balance -= TicketFairList[i].ticketFair;
                let travelHistory: TravelDetails = {
                    travelID: undefined,
                    cardID: CurrentUser.cardID,
                    fromLocation: TicketFairList[i].fromLocation,
                    toLocation: TicketFairList[i].toLocation,
                    travelDate: new Date().toISOString(),
                    travelFair: TicketFairList[i].ticketFair
                };
                addTravel(travelHistory);
                alert("Booked Successfully");
                Travel();
            }
            else
            {
                alert("insufficent balance");
            }
        }
    }
}

//Recharge
function Recharge() {
    displayNone();
    recharge.style.display = "block";
    rechargeAmount.style.display = "block";
    rechargebutton.style.display = "block";
}

function Deposit() {
    CurrentUser.balance = Number(rechargeAmount.value) + CurrentUser.balance;
    alert("RecrentUser.userharged Sucessfully");
    updateAmount(CurrentUser.cardID,Number(rechargeAmount.value) )
    rechargeAmount.value = "";
}

//show balance
function ShowBalance() {
    displayNone();
    showbalance.style.display = "block";
    let balanceShow = document.getElementById('balance') as HTMLDivElement;
    balanceShow.innerHTML = "Your Balance is " + CurrentUser.balance;
}

//travel history
async function TravelHistory() {
    displayNone();
    travelhistory.style.display = "block";
    let TravelList=await fetchTravel();  
    let table = document.getElementById("travel-history-table") as HTMLTableElement
    table.innerHTML = "";
    let row1 = document.createElement("tr");
    row1.innerHTML = `
    <th>From Location</th>
    <th>To Location</th>
    <th>Travel Date</th>
    <th>Travel Fair</th>
    `;
    table.appendChild(row1);
    for(let i = 0;i<TravelList.length ;i++)
    {
        if(TravelList[i].cardID == CurrentUser.cardID)
        {
            let row = document.createElement("tr");
            row.innerHTML = `
            <td>${TravelList[i].fromLocation}</td>
            <td>${TravelList[i].toLocation}</td>
            <td>${TravelList[i].travelDate.toString().split('T')[0].split('-').reverse().join('/')}</td>
            <td>${TravelList[i].travelFair}</td>
            `;
            table.appendChild(row);
        }
    }
}

function LogOut()
{
    displayNone();
    logout.style.display = "block";
 
}

function Yes()
{
    displayNone();
    logout.style.display = "none";
    menubars.style.display = "none";
    homepage.style.display = "block";
    
}

function No()
{
  logout.style.display = "none";
    displayNone();
    Home();
}