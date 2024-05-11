"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
let CurrentUser;
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
function fetchUser() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5149/api/UserDetails';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch userdetails');
        }
        return yield response.json();
    });
}
//fetch TravelDetails
function fetchTravel() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5149/api/TravelDetails';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch traveldetails');
        }
        return yield response.json();
    });
}
//fetch TicketFairDetails
function fetchTicket() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5149/api/TicketFairDetails';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch ticketfairdetails');
        }
        return yield response.json();
    });
}
//add user
function addUser(user) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5149/api/UserDetails', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        });
        if (!response.ok) {
            throw new Error('Failed to add user');
        }
    });
}
//update balance
function updateAmount(id, amt) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5149/api/UserDetails/${id}/${amt}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(amt)
        });
        if (!response.ok) {
            throw new Error('Failed to update balance');
        }
    });
}
//update user
function updateUser(id, user) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5149/api/UserDetails/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        });
        if (!response.ok) {
            throw new Error('Failed to update userdetails');
        }
    });
}
//add tictetfair
function addTicket(ticket) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5149/api/TicketFairDetails', {
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
    });
}
//edit ticketfair
function updateTicket(id, ticket) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5149/api/TicketFairDetails/${id}`, {
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
    });
}
//delete ticketfair
function deleteTicket(id) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5149/api/TicketFairDetails/${id}`, {
            method: 'DELETE'
        });
        if (!response.ok) {
            throw new Error('Failed to delete ticket');
        }
        Ticket();
    });
}
//add travel
function addTravel(travel) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5149/api/TravelDetails', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(travel)
        });
        if (!response.ok) {
            throw new Error('Failed to add travel');
        }
    });
}
//edit travel
function updateTravel(id, travel) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5149/api/TravelDetails/${id}`, {
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
    });
}
var homepage = document.getElementById('homepage');
var signup = document.getElementById('signup');
var signupinput = document.getElementById('sign-up');
var signin = document.getElementById('signin');
var signininput = document.getElementById('sign-in');
var menubars = document.getElementById('menubars');
var home = document.getElementById('home-tab');
var ticket = document.getElementById('ticket-tab');
var travel = document.getElementById('travel-tab');
var recharge = document.getElementById('recharge-tab');
var travelhistory = document.getElementById('travel-history-tab');
var showbalance = document.getElementById('show-balance-tab');
var logout = document.getElementById('logout-tab');
var nameInput = document.getElementById('name');
var pwdInput = document.getElementById('pwd');
var cnfpwdInput = document.getElementById('cnfpwd');
var phnInput = document.getElementById('phn');
var addbutton = document.getElementById('add');
var editbutton = document.getElementById('edit');
let rechargeAmount = document.getElementById('recharge-amount');
let rechargebutton = document.getElementById('rechargebutton');
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
function SignUp() {
    return __awaiter(this, void 0, void 0, function* () {
        signupinput.style.display = "block";
        signininput.style.display = "none";
    });
}
let editingID = null;
//signupsubmit
function SignUpSubmit() {
    return __awaiter(this, void 0, void 0, function* () {
        const name = nameInput.value.trim();
        const password = pwdInput.value.trim();
        const phone = phnInput.value.trim();
        if (editingID !== null) {
            const user = {
                cardID: editingID,
                userName: name,
                userPassword: password,
                userPhoneNumber: phone,
                balance: 0
            };
            updateUser(editingID, user);
        }
        else {
            const user = {
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
    });
}
//Signin
function SignIn() {
    return __awaiter(this, void 0, void 0, function* () {
        signupinput.style.display = "none";
        signininput.style.display = "block";
    });
}
//SignInSubmit
function SignInSubmit() {
    return __awaiter(this, void 0, void 0, function* () {
        const UserList = yield fetchUser();
        let phone = document.getElementById('phn1');
        let password = document.getElementById('pwd1');
        let isFlag = true;
        for (var i = 0; i < UserList.length; i++) {
            if (UserList[i].userPhoneNumber == phone.value && UserList[i].userPassword == password.value) {
                CurrentUser = UserList[i];
                isFlag = false;
                phone.value = "";
                password.value = "";
            }
        }
        if (isFlag) {
            alert("Invalid Phone or Password");
        }
        else {
            alert("Signed In Successfully");
            MenuBar();
        }
    });
}
//MenuBar
function MenuBar() {
    return __awaiter(this, void 0, void 0, function* () {
        menubars.style.display = "block";
        homepage.style.display = "none";
    });
}
//Home
function Home() {
    displayNone();
    home.style.display = "block";
    document.getElementById('welcome').innerHTML = "Welcome " + CurrentUser.userName;
}
//ticket
function Ticket() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        const TicketFairList = yield fetchTicket();
        ticket.style.display = "block";
        let Table = document.getElementById('ticket-table');
        Table.innerHTML = "";
        let headRow = document.createElement('tr');
        headRow.innerHTML =
            `
    <th>From Location</th>
    <th>To Location</th>
    <th>Ticket Fair</th>
    <th>Edit</th>
    <th>Delete</th>`;
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
    });
}
//addbuttton
function AddButton() {
    addbutton.style.display = "block";
    editbutton.style.display = "none";
}
//submit in add details
function AddSubmit() {
    return __awaiter(this, void 0, void 0, function* () {
        let fromLocationAdd = document.getElementById('ticket-from');
        let toLocationAdd = document.getElementById('ticket-to');
        let ticketFairAdd = document.getElementById('ticket-fair');
        const ticket = {
            ticketID: undefined,
            fromLocation: fromLocationAdd.value,
            toLocation: toLocationAdd.value,
            ticketFair: Number(ticketFairAdd.value)
        };
        addTicket(ticket);
        fromLocationAdd.value = "";
        toLocationAdd.value = "";
        ticketFairAdd.value = "";
        Ticket();
    });
}
let ticketIndex = 0;
//edit button in table
function EditButton(count) {
    return __awaiter(this, void 0, void 0, function* () {
        const TicketFairList = yield fetchTicket();
        editbutton.style.display = "block";
        addbutton.style.display = "none";
        ticketIndex = count;
        for (var i = 0; i < TicketFairList.length; i++) {
            if (i == ticketIndex) {
                document.getElementById('ticket-from-edit').value = TicketFairList[i].fromLocation.toString();
                document.getElementById('ticket-to-edit').value = TicketFairList[i].toLocation.toString();
                document.getElementById('ticket-fair-edit').value = TicketFairList[i].ticketFair.toString();
            }
        }
    });
}
//submit in edit details
function EditSubmit() {
    return __awaiter(this, void 0, void 0, function* () {
        const TicketFairList = yield fetchTicket();
        for (var i = 0; i < TicketFairList.length; i++) {
            if (i == ticketIndex) {
                TicketFairList[i].fromLocation = document.getElementById('ticket-from-edit').value;
                TicketFairList[i].toLocation = document.getElementById('ticket-to-edit').value;
                TicketFairList[i].ticketFair = Number(document.getElementById('ticket-fair-edit').value);
                updateTicket(TicketFairList[i].ticketID, TicketFairList[i]);
                document.getElementById('ticket-from-edit').value = "";
                document.getElementById('ticket-to-edit').value = "";
                document.getElementById('ticket-fair-edit').value = "";
                Ticket();
            }
        }
    });
}
//delete
function DeleteButton(count) {
    deleteTicket(count);
    Ticket();
}
//ticket
function Travel() {
    return __awaiter(this, void 0, void 0, function* () {
        const TicketFairList = yield fetchTicket();
        displayNone();
        travel.style.display = "block";
        let Table = document.getElementById('travel-table');
        Table.innerHTML = "";
        let headRow = document.createElement('tr');
        headRow.innerHTML =
            `
    <th>From Location</th>
    <th>To Location</th>
    <th>Ticket Fair</th>
    <th>Action</th>`;
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
    });
}
//Buy
function buy(count) {
    return __awaiter(this, void 0, void 0, function* () {
        const TicketFairList = yield fetchTicket();
        for (var i = 0; i < TicketFairList.length; i++) {
            if (i == count) {
                if (CurrentUser.balance >= TicketFairList[i].ticketFair) {
                    CurrentUser.balance -= TicketFairList[i].ticketFair;
                    let travelHistory = {
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
                else {
                    alert("insufficent balance");
                }
            }
        }
    });
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
    updateAmount(CurrentUser.cardID, Number(rechargeAmount.value));
    rechargeAmount.value = "";
}
//show balance
function ShowBalance() {
    displayNone();
    showbalance.style.display = "block";
    let balanceShow = document.getElementById('balance');
    balanceShow.innerHTML = "Your Balance is " + CurrentUser.balance;
}
//travel history
function TravelHistory() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        travelhistory.style.display = "block";
        let TravelList = yield fetchTravel();
        let table = document.getElementById("travel-history-table");
        table.innerHTML = "";
        let row1 = document.createElement("tr");
        row1.innerHTML = `
    <th>From Location</th>
    <th>To Location</th>
    <th>Travel Date</th>
    <th>Travel Fair</th>
    `;
        table.appendChild(row1);
        for (let i = 0; i < TravelList.length; i++) {
            if (TravelList[i].cardID == CurrentUser.cardID) {
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
    });
}
function LogOut() {
    displayNone();
    logout.style.display = "block";
}
function Yes() {
    displayNone();
    logout.style.display = "none";
    menubars.style.display = "none";
    homepage.style.display = "block";
}
function No() {
    logout.style.display = "none";
    displayNone();
    Home();
}
