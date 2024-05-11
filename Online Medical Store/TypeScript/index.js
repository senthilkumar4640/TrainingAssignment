"use strict";
let UserIdAutoIncrement = 1000;
let MedicineIdAutoIncrement = 10;
let OrderIdAutoIncrement = 100;
let CurrentUser;
let CurrentUserId;
let CurrentUserName;
// let NewUserNameStatus = false;
// let NewUserAgeStatus = false;
// let NewUserPhoneNumberStatus = false;
let nameInput = document.getElementById('name');
let emailInput = document.getElementById('email');
let pwdInput = document.getElementById('pwd');
let phnInput = document.getElementById('phn');
var Status;
(function (Status) {
    Status["ordered"] = "ordered";
    Status["Cancelled"] = "Cancelled";
})(Status || (Status = {}));
class User {
    constructor(paramUserName, paramUserEmail, paramUserPassword, paramUserPhoneNumber) {
        this.UserBalance = 0;
        UserIdAutoIncrement++;
        this.UserId = "UI" + UserIdAutoIncrement.toString();
        this.UserName = paramUserName;
        this.UserEmail = paramUserEmail;
        this.UserPassword = paramUserPassword;
        this.UserPhoneNumber = paramUserPhoneNumber;
    }
}
class MedicineInfo {
    constructor(paramMedicineName, paramMedicineCount, paramMedicinePrice, paramedicineExpiryDate) {
        MedicineIdAutoIncrement++;
        this.MedicineId = "MD" + MedicineIdAutoIncrement.toString();
        this.MedicineName = paramMedicineName;
        this.MedicineCount = paramMedicineCount;
        this.MedicinePrice = paramMedicinePrice;
        this.MedicineExpiryDate = paramedicineExpiryDate;
    }
}
class Order {
    constructor(paramUserId, paramMedicineId, paramMedicineName, paramMedicineCount, paramTotalPrice, paramOrderDate, paramOrderStatus) {
        OrderIdAutoIncrement++;
        this.OrderId = "OI" + OrderIdAutoIncrement.toString();
        this.UserId = paramUserId;
        this.MedicineId = paramMedicineId;
        this.MedicineName = paramMedicineName;
        this.MedicineCount = paramMedicineCount;
        this.TotalPrice = paramTotalPrice;
        this.OrderDate = paramOrderDate;
        this.OrderStatus = paramOrderStatus;
    }
}
let UserArrayList = new Array();
UserArrayList.push(new User("Hemanth", "hemanth@gmail.com", "Hemanth@123", "9789011226"));
UserArrayList.push(new User("Harish", "Harish@gmail.com", "Harish@123", "9445153060"));
let MedicineList = new Array();
MedicineList.push(new MedicineInfo("Paracetomol", 5, 50, new Date(2024, 2, 8)));
MedicineList.push(new MedicineInfo("Colpal", 5, 60, new Date(2024, 2, 12)));
MedicineList.push(new MedicineInfo("Stepsil", 5, 70, new Date(2026, 9, 3)));
MedicineList.push(new MedicineInfo("Iodex", 5, 80, new Date(2025, 1, 9)));
MedicineList.push(new MedicineInfo("Acetherol", 5, 100, new Date(2028, 5, 20)));
let OrderList = new Array(); //Array only created
let signin = document.getElementById('sign-in');
let signup = document.getElementById('sign-up');
let homepage = document.getElementById('homepage');
//homepage.style.display = "none"
let menu = document.getElementById('menubar');
signup.style.display = "none";
menu.style.display = "none";
//signup function
function SignInPage() {
    signin.style.display = "block";
    signup.style.display = "none";
}
function SignUpPage() {
    signin.style.display = "none";
    signup.style.display = "block";
}
function MenuBar() {
    menu.style.display = "block";
    homepage.style.display = "none";
}
function SignIn() {
    let email = document.getElementById('email1');
    let password = document.getElementById('pwd1');
    var isflag = true;
    for (var i = 0; i < UserArrayList.length; i++) {
        if (UserArrayList[i].UserEmail.toLowerCase() == email.value.toLowerCase() && UserArrayList[i].UserPassword == password.value) {
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
    let email = document.getElementById('email');
    var isflag = true;
    for (var i = 0; i < UserArrayList.length; i++) {
        if (UserArrayList[i].UserEmail == email.value) {
            isflag = false;
            break;
        }
    }
    if (isflag == true) {
        let user = new User(nameInput.value, emailInput.value, pwdInput.value, phnInput.value);
        UserArrayList.push(user);
        CurrentUser = user;
        MenuBar();
    }
    if (isflag == false) {
        alert("User Exists");
    }
}
let topup = document.getElementById('topup');
let topupbutton = document.getElementById('topupbutton');
let addbutton = document.getElementById('add');
var editbutton = document.getElementById('edit');
var homeBar = document.getElementById('home-tab');
var MedicineDetailsBar = document.getElementById('medicine-details-tab');
var purchaseBar = document.getElementById('purchase-tab');
var cancelBar = document.getElementById('cancel-tab');
var showBalanceBar = document.getElementById('show-balance-tab');
var topUpBar = document.getElementById('top-up-tab');
var orderHistoryBar = document.getElementById('order-history-tab');
MedicineDetailsBar.style.display = "none";
purchaseBar.style.display = "none";
cancelBar.style.display = "none";
topup.style.display = "none";
topupbutton.style.display = "none";
orderHistoryBar.style.display = "none";
addbutton.style.display = "none";
editbutton.style.display = "none";
function displayNone() {
    homeBar.style.display = "none";
    MedicineDetailsBar.style.display = "none";
    purchaseBar.style.display = "none";
    cancelBar.style.display = "none";
    topUpBar.style.display = "none";
    showBalanceBar.style.display = "none";
    orderHistoryBar.style.display = "none";
}
function Home() {
    displayNone();
    let homeTab = document.getElementById('welcome');
    homeBar.style.display = "block";
    //menu.style.display="block"; 
    homeTab.innerHTML = "Welcome" + CurrentUser.UserName;
}
function MedicineDetails() {
    displayNone();
    MedicineDetailsBar.style.display = "block";
    let Table = document.getElementById('medicine-table');
    Table.innerHTML = "";
    let headRow = document.createElement('tr');
    headRow.innerHTML =
        `<th>Medicine Name</th>
    <th>Medicine Price </th>
    <th>Quantity</th>
    <th>Expiry Date</th>
    <th>Modify</th>`;
    Table.appendChild(headRow);
    for (var i = 0; i < MedicineList.length; i++) {
        let bodyRow = document.createElement('tr');
        bodyRow.innerHTML =
            `
            <td>${MedicineList[i].MedicineName}</td>
            <td>${MedicineList[i].MedicinePrice}</td>
            <td>${MedicineList[i].MedicineCount}</td>
            <td>${MedicineList[i].MedicineExpiryDate.toLocaleDateString()}</td>
            <td><button onclick="edit(${i})">Edit</button><button onclick="del(${i})">Delete</button></td>
            `;
        Table.appendChild(bodyRow);
    }
}
function Purchase() {
    displayNone();
    purchaseBar.style.display = "block";
    let Table = document.getElementById('purchase-table');
    Table.innerHTML = "";
    let headRow = document.createElement('tr');
    headRow.innerHTML =
        `<th>Medicine Name</th>
    <th>Medicine Price </th>
    <th>Quantity</th>
    <th>Expiry Date</th>
    <th>Action</th>`;
    Table.appendChild(headRow);
    for (var i = 0; i < MedicineList.length; i++) {
        let bodyRow = document.createElement('tr');
        bodyRow.innerHTML =
            `
            <td>${MedicineList[i].MedicineName}</td>
            <td>${MedicineList[i].MedicinePrice}</td>
            <td>${MedicineList[i].MedicineCount}</td>
            <td>${MedicineList[i].MedicineExpiryDate.toLocaleDateString()}</td>
            <td><button onclick="buy(${i})">Buy</button></td>
            `;
        Table.appendChild(bodyRow);
    }
}
function buy(count) {
    for (var i = 0; i < MedicineList.length; i++) {
        if (i == count) {
            var option = Number(prompt("Enter the count"));
            if (option < 0 && option != 0 && option != null) {
                if (option <= MedicineList[i].MedicineCount) {
                    if (CurrentUser.UserBalance >= MedicineList[i].MedicinePrice) {
                        if (MedicineList[i].MedicineExpiryDate > new Date()) {
                            MedicineList[i].MedicineCount -= option;
                            CurrentUser.UserBalance -= (MedicineList[i].MedicinePrice) * option;
                            OrderList.push(new Order(CurrentUser.UserId, MedicineList[i].MedicineId, MedicineList[i].MedicineName, option, MedicineList[i].MedicinePrice * option, (new Date).toLocaleDateString(), Status.ordered));
                            alert("Order Placed Successfully");
                            Purchase();
                        }
                        else {
                            alert("Medicine is Expired");
                        }
                    }
                    else {
                        alert("Insufficient Balance");
                    }
                }
                else {
                    alert(`I have only ${MedicineList[i].MedicineCount}`);
                }
            }
        }
    }
}
function Add() {
    addbutton.style.display = "block";
    editbutton.style.display = "none";
}
function ShowAdd() {
    let medName = document.getElementById('med-name');
    let medPrice = document.getElementById('med-price');
    let medQuantity = document.getElementById('med-quantity');
    let medExpDate = document.getElementById('med-exp-date');
    let str = medExpDate.value;
    const strArray = str.split("-");
    let medDate = new Date(Number(strArray[0]), (Number(strArray[1]) - 1), Number(strArray[2]));
    MedicineList.push(new MedicineInfo(medName.value, Number(medPrice.value), Number(medQuantity.value), medDate));
    MedicineDetails();
}
let medIndex = 0;
function edit(count) {
    editbutton.style.display = "block";
    addbutton.style.display = "none";
    medIndex = count;
    for (var i = 0; i < MedicineList.length; i++) {
        if (i == medIndex) {
            document.getElementById('edit-name').value = MedicineList[i].MedicineName.toString();
            document.getElementById('edit-price').value = MedicineList[i].MedicinePrice.toString();
            document.getElementById('edit-quantity').value = MedicineList[i].MedicineCount.toString();
            let date = MedicineList[i].MedicineExpiryDate.getDate();
            let month = MedicineList[i].MedicineExpiryDate.getMonth() + 1;
            if (date < 10) {
                date = "0" + date;
            }
            if (month < 10) {
                month = "0" + month;
            }
            let year = MedicineList[i].MedicineExpiryDate.getFullYear();
            document.getElementById('edit-exp-date').value = `${year}-${month}-${date}`;
        }
    }
}
function ShowEdit() {
    for (var i = 0; i < MedicineList.length; i++) {
        if (i == medIndex) {
            MedicineList[i].MedicineName = document.getElementById('edit-name').value;
            MedicineList[i].MedicinePrice = Number(document.getElementById('edit-price').value);
            MedicineList[i].MedicineCount = Number(document.getElementById('edit-quantity').value);
            let str = document.getElementById('edit-exp-date').value;
            let strArray1 = str.split("-");
            let medDate = new Date(Number(strArray1[0]), (Number(strArray1[1]) - 1), Number(strArray1[2]));
            MedicineList[i].MedicineExpiryDate = medDate;
            MedicineDetails();
        }
    }
}
function del(count) {
    MedicineList = MedicineList.filter(remove => MedicineList.indexOf(remove) != count);
    MedicineDetails();
}
function Cancel() {
    displayNone();
    cancelBar.style.display = "block";
    let Table = document.getElementById('cancel-table');
    Table.innerHTML = "";
    let headRow = document.createElement('tr');
    headRow.innerHTML =
        `<th>Order ID</th>
    <th>User ID</th>
    <th>Medicine Name</th>
    <th>Total Price</th>
    <th>Order Status</th>
    <th>Modify</th>`;
    Table.appendChild(headRow);
    for (var i = 0; i < OrderList.length; i++) {
        if (OrderList[i].OrderStatus == Status.ordered && CurrentUser.UserId == OrderList[i].UserId) {
            let bodyRow = document.createElement('tr');
            bodyRow.innerHTML =
                `
                    <td>${OrderList[i].OrderId}</td>
                    <td>${OrderList[i].UserId}</td>
                    <td>${OrderList[i].MedicineName}</td>
                    <td>${OrderList[i].TotalPrice}</td>
                    <td>${OrderList[i].OrderStatus}</td>
                    <td><button onclick="can(${i})">Cancel</button></td>
                    `;
            Table.appendChild(bodyRow);
        }
    }
}
function can(count) {
    for (var i = 0; i < OrderList.length; i++) {
        if (i == count) {
            OrderList[i].OrderStatus = Status.Cancelled;
            let price = 0;
            for (var j = 0; j < MedicineList.length; j++) {
                if (MedicineList[j].MedicineId == OrderList[i].MedicineId) {
                    MedicineList[j].MedicineCount += OrderList[i].MedicineCount;
                    price = MedicineList[j].MedicinePrice * OrderList[i].MedicineCount;
                }
            }
            CurrentUser.UserBalance += price;
            alert("Ordered Cancelled");
            Cancel();
        }
    }
}
function ShowBalance() {
    displayNone();
    showBalanceBar.style.display = "block";
    let balanceShow = document.getElementById('balance');
    balanceShow.innerHTML = "Your Balance is " + CurrentUser.UserBalance;
}
function TopUp() {
    displayNone();
    topUpBar.style.display = "block";
    let topup = document.getElementById('topup');
    topup.style.display = "block";
    let topupbutton = document.getElementById('topupbutton');
    topupbutton.style.display = "block";
}
function Deposit() {
    let topup = document.getElementById('topup');
    CurrentUser.UserBalance = Number(topup.value) + CurrentUser.UserBalance;
    alert("Recharged Sucessfully");
    topup.value = "";
}
function OrderHistory() {
    displayNone();
    orderHistoryBar.style.display = "block";
    let Table = document.getElementById('order-history-table');
    Table.innerHTML = "";
    let headRow = document.createElement('tr');
    headRow.innerHTML =
        `<th>Order ID</th>
    <th>User ID</th>
    <th>Medicine Name</th>
    <th>Total Price</th>
    <th>Order Status</th>`;
    Table.appendChild(headRow);
    for (var i = 0; i < OrderList.length; i++) {
        if (CurrentUser.UserId == OrderList[i].UserId) {
            let bodyRow = document.createElement('tr');
            bodyRow.innerHTML =
                `
                    <td>${OrderList[i].OrderId}</td>
                    <td>${OrderList[i].UserId}</td>
                    <td>${OrderList[i].MedicineName}</td>
                    <td>${OrderList[i].TotalPrice}</td>
                    <td>${OrderList[i].OrderStatus}</td>
                    `;
            Table.appendChild(bodyRow);
        }
    }
}
