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
let signin = document.getElementById('sign-in');
let signup = document.getElementById('form');
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
    return __awaiter(this, void 0, void 0, function* () {
        const UserList = yield fetchUser();
        let email = document.getElementById('email1');
        let password = document.getElementById('pwd1');
        let isFlag = true;
        for (var i = 0; i < UserList.length; i++) {
            if (UserList[i].userEmail == email.value && UserList[i].userPassword == password.value) {
                CurrentUser = UserList[i];
                isFlag = false;
            }
        }
        if (isFlag) {
            alert("Invalid Email or Password");
        }
        else {
            alert("Signed In Successfully");
            MenuBar();
        }
    });
}
let editingId = null;
const form = document.getElementById("form");
const nameInput1 = document.getElementById("name");
const emailInput1 = document.getElementById("email");
const pwdInput1 = document.getElementById("pwd");
const cnfpwdInput1 = document.getElementById("cnfpwd");
form.addEventListener("submit", (event) => {
    event.preventDefault();
    const name = nameInput1.value.trim();
    const email = emailInput1.value.trim();
    const pwd = pwdInput1.value.trim();
    const cnfpwd = cnfpwdInput1.value.trim();
    if (editingId !== null) {
        const user = {
            userID: editingId,
            userName: name,
            userEmail: email,
            userPassword: pwd,
            userBalance: 0
        };
        updateUser(editingId, user);
    }
    else {
        const user = {
            userID: 0,
            userName: name,
            userEmail: email,
            userPassword: pwd,
            userBalance: 0,
        };
        addUser(user);
        alert("User Registered Successfully");
    }
    form.reset();
});
const form1 = document.getElementById("formsignin");
const nameInput2 = document.getElementById("name1");
const emailInput2 = document.getElementById("email1");
function addUser(user) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5072/api/User', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        });
        if (!response.ok) {
            throw new Error('Failed to add contact');
        }
        // renderContacts();
    });
}
function addMedicine(medicine) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5072/api/MedicalInfo', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(medicine)
        });
        if (!response.ok) {
            throw new Error('Failed to add contact');
        }
        // renderContacts();
        MedicineDetails();
    });
}
function editUser(id) {
    return __awaiter(this, void 0, void 0, function* () {
        editingId = id;
        const user = yield fetchUser();
        const users = user.find(user => user.userID === id);
        if (users) {
            nameInput1.value = users.userName;
            emailInput1.value = users.userEmail;
            phnInput.value = users.userPassword;
        }
    });
}
const medName = document.getElementById("med-name");
const medprice = document.getElementById("med-price");
const medQuantity = document.getElementById("med-quantity");
const medExpDate = document.getElementById("med-exp-date");
function editMedicine(id) {
    return __awaiter(this, void 0, void 0, function* () {
        editingId = id;
        const medicine = yield fetchMedicine();
        const medicines = medicine.find(medicine => medicine.medicineID === id);
        if (medicines) {
            medName.value = medicines.medicineName;
            medprice.value = medicines.medicinePrice.toString();
            medQuantity.value = medicines.medicineCount.toString();
            medExpDate.value = medicines.medicineExpiryDate.toString();
        }
    });
}
function deleteMedicine(id) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5072/api/MedicalInfo/${id}`, {
            method: 'DELETE'
        });
        if (!response.ok) {
            throw new Error('Failed to delete contact');
        }
        MedicineDetails();
        // renderContacts();
    });
}
function updateUser(id, user) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5072/api/User/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        });
        if (!response.ok) {
            throw new Error('Failed to update user');
        }
        // renderContacts();
    });
}
function updateMedicine(id, medicine) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5072/api/MedicalInfo/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(medicine)
        });
        if (!response.ok) {
            throw new Error('Failed to update contact');
        }
        MedicineDetails();
        // renderContacts();
    });
}
function updateMedicineCancel(id, medicine) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5072/api/MedicalInfo/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(medicine)
        });
        if (!response.ok) {
            throw new Error('Failed to update contact');
        }
        // renderContacts();
    });
}
function updateMedicinePurchase(id, medicine) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5072/api/MedicalInfo/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(medicine)
        });
        if (!response.ok) {
            throw new Error('Failed to update contact');
        }
        Purchase();
        // renderContacts();
    });
}
function fetchUser() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5072/api/User';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch contacts');
        }
        return yield response.json();
    });
}
function fetchMedicine() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5072/api/MedicalInfo';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch contacts');
        }
        return yield response.json();
    });
}
function fetchOrder() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5072/api/Order';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch contacts');
        }
        return yield response.json();
    });
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
var logout = document.getElementById('logout-tab');
logout.style.display = "none";
MedicineDetailsBar.style.display = "none";
purchaseBar.style.display = "none";
cancelBar.style.display = "none";
topup.style.display = "none";
topupbutton.style.display = "none";
orderHistoryBar.style.display = "none";
addbutton.style.display = "none";
editbutton.style.display = "none";
homeBar.style.display = "none";
showBalanceBar.style.display = "none";
topUpBar.style.display = "none";
topupbutton.style.display = "none";
function displayNone() {
    homeBar.style.display = "none";
    MedicineDetailsBar.style.display = "none";
    purchaseBar.style.display = "none";
    cancelBar.style.display = "none";
    topUpBar.style.display = "none";
    showBalanceBar.style.display = "none";
    orderHistoryBar.style.display = "none";
    logout.style.display = "none";
}
function Home() {
    displayNone();
    let homeTab = document.getElementById('welcome');
    homeBar.style.display = "block";
    //menu.style.display="block"; 
    homeTab.innerHTML = "Welcome " + CurrentUser.userName;
}
function MedicineDetails() {
    return __awaiter(this, void 0, void 0, function* () {
        const MedicineList = yield fetchMedicine();
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
            <td>${MedicineList[i].medicineName}</td>
            <td>${MedicineList[i].medicinePrice}</td>
            <td>${MedicineList[i].medicineCount}</td>
            <td>${MedicineList[i].medicineExpiryDate.split('T')[0].split('-').reverse().join('/')}</td>
            <td><button onclick="edit(${i})">Edit</button><button onclick="del(${MedicineList[i].medicineID})">Delete</button></td>
            `;
            Table.appendChild(bodyRow);
        }
    });
}
function addOrder(order) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5072/api/Order', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(order)
        });
        Purchase();
        if (!response.ok) {
            throw new Error('Failed to add UserInfo');
        }
    });
}
function updateOrder(id, order) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5072/api/Order/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(order)
        });
        if (!response.ok) {
            throw new Error('Failed to update contact');
        }
        Cancel();
    });
}
function Purchase() {
    return __awaiter(this, void 0, void 0, function* () {
        const MedicineList = yield fetchMedicine();
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
            <td>${MedicineList[i].medicineName}</td>
            <td>${MedicineList[i].medicinePrice}</td>
            <td>${MedicineList[i].medicineCount}</td>
            <td>${MedicineList[i].medicineExpiryDate.split('T')[0].split('-').reverse().join('/')}</td>
            <td><button onclick="buy(${i})">Buy</button></td>
            `;
            Table.appendChild(bodyRow);
        }
    });
}
function buy(count) {
    return __awaiter(this, void 0, void 0, function* () {
        let MedicineList = yield fetchMedicine();
        for (let i = 0; i < MedicineList.length; i++) {
            if (i == count) {
                let option = prompt("enter the count");
                let option1 = Number(option);
                if (option1 < MedicineList[i].medicineCount) {
                    if (CurrentUser.userBalance >= MedicineList[i].medicinePrice * option1) {
                        CurrentUser.userBalance -= MedicineList[i].medicinePrice * option1;
                        MedicineList[i].medicineCount -= option1;
                        let order = {
                            orderID: 0,
                            medicineID: MedicineList[i].medicineID,
                            userID: CurrentUser.userID,
                            medicineName: MedicineList[i].medicineName,
                            medicineCount: option1,
                            orderStatus: "ordered"
                        };
                        addOrder(order);
                        updateMedicinePurchase(MedicineList[i].medicineID, MedicineList[i]);
                        // OrderList.push(new Order(MedicineList[i].MedicineId,CurrentUser.userId,MedicineList[i].MedicineName,option1,Status.Orderer));
                        alert("ordered successfull");
                        Purchase();
                    }
                    else {
                        alert("insufficent balance");
                    }
                }
                else {
                    alert(`Invalid Count`);
                }
            }
        }
    });
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
    const medicine = {
        medicineID: 0,
        medicineName: medName.value,
        medicinePrice: Number(medPrice.value),
        medicineCount: Number(medQuantity.value),
        medicineExpiryDate: medExpDate.value
    };
    addMedicine(medicine);
    medName.value = "";
    medPrice.value = "";
    medQuantity.value = "";
    medExpDate.value = "";
    MedicineDetails();
}
let medIndex = 0;
function edit(count) {
    return __awaiter(this, void 0, void 0, function* () {
        const MedicineList = yield fetchMedicine();
        editbutton.style.display = "block";
        addbutton.style.display = "none";
        medIndex = count;
        for (var i = 0; i < MedicineList.length; i++) {
            if (i == medIndex) {
                document.getElementById('edit-name').value = MedicineList[i].medicineName.toString();
                document.getElementById('edit-price').value = MedicineList[i].medicinePrice.toString();
                document.getElementById('edit-quantity').value = MedicineList[i].medicineCount.toString();
                document.getElementById("edit-exp-date").value = MedicineList[i].medicineExpiryDate.split('T')[0];
            }
        }
    });
}
function ShowEdit() {
    return __awaiter(this, void 0, void 0, function* () {
        const MedicineList = yield fetchMedicine();
        for (var i = 0; i < MedicineList.length; i++) {
            if (i == medIndex) {
                MedicineList[i].medicineName = document.getElementById('edit-name').value;
                MedicineList[i].medicinePrice = Number(document.getElementById('edit-price').value);
                MedicineList[i].medicineCount = Number(document.getElementById('edit-quantity').value);
                MedicineList[i].medicineExpiryDate = document.getElementById('edit-exp-date').value;
                updateMedicine(MedicineList[i].medicineID, MedicineList[i]);
                document.getElementById('edit-name').value = "";
                document.getElementById('edit-price').value = "";
                document.getElementById('edit-quantity').value = "";
                document.getElementById('edit-exp-date').value = "";
                MedicineDetails();
            }
        }
    });
}
function del(count) {
    deleteMedicine(count);
    MedicineDetails();
}
function Cancel() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        const OrderList = yield fetchOrder();
        cancelBar.style.display = "block";
        let Table = document.getElementById('cancel-table');
        Table.innerHTML = "";
        let headRow = document.createElement('tr');
        headRow.innerHTML =
            `<th>Order ID</th>
    <th>User ID</th>
    <th>Medicine Name</th>
    <th>Total Count</th>
    <th>Order Status</th>
    <th>Cancel</th>`;
        Table.appendChild(headRow);
        for (var i = 0; i < OrderList.length; i++) {
            if (OrderList[i].orderStatus == "ordered" && CurrentUser.userID == OrderList[i].userID) {
                let bodyRow = document.createElement('tr');
                bodyRow.innerHTML =
                    `
                    <td>${OrderList[i].orderID}</td>
                    <td>${OrderList[i].userID}</td>
                    <td>${OrderList[i].medicineName}</td>
                    <td>${OrderList[i].medicineCount}</td>
                    <td>${OrderList[i].orderStatus}</td>
                    <td><button onclick="can(${i})">Cancel</button></td>
                    `;
                Table.appendChild(bodyRow);
            }
        }
    });
}
function can(count) {
    return __awaiter(this, void 0, void 0, function* () {
        const OrderList = yield fetchOrder();
        const MedicineList = yield fetchMedicine();
        for (var i = 0; i < OrderList.length; i++) {
            if (i == count) {
                OrderList[i].orderStatus = "cancelled";
                let price = 0;
                for (var j = 0; j < MedicineList.length; j++) {
                    if (MedicineList[j].medicineID == OrderList[i].medicineID) {
                        MedicineList[j].medicineCount += OrderList[i].medicineCount;
                        price = MedicineList[j].medicinePrice * OrderList[i].medicineCount;
                        updateMedicineCancel(MedicineList[j].medicineID, MedicineList[j]);
                        break;
                    }
                }
                CurrentUser.userBalance += price;
                updateUser(CurrentUser.userID, CurrentUser);
                alert("Ordered Cancelled");
                updateOrder(OrderList[i].orderID, OrderList[i]);
                Cancel();
            }
        }
    });
}
function ShowBalance() {
    displayNone();
    showBalanceBar.style.display = "block";
    let balanceShow = document.getElementById('balance');
    balanceShow.innerHTML = "Your Balance is " + CurrentUser.userBalance;
}
function TopUp() {
    displayNone();
    topUpBar.style.display = "block";
    let topup = document.getElementById('topup');
    topup.style.display = "block";
    let topupbutton = document.getElementById('topupbutton');
    topupbutton.style.display = "block";
}
function updateamount(id, amt) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5072/api/User/${id}/${amt}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(amt)
        });
        if (!response.ok) {
            throw new Error('Failed to update contact');
        }
        // renderContacts();
    });
}
function Deposit() {
    let topup = document.getElementById('topup');
    CurrentUser.userBalance = Number(topup.value) + CurrentUser.userBalance;
    alert("RecrentUser.userharged Sucessfully");
    updateamount(CurrentUser.userID, Number(topup.value));
    topup.value = "";
}
function OrderHistory() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        orderHistoryBar.style.display = "block";
        let OrderList = yield fetchOrder();
        let table = document.getElementById("order-history-table");
        table.innerHTML = "";
        let row1 = document.createElement("tr");
        row1.innerHTML = `
    <th>OrderID
    <th>UserID</th>
    <th>MedicineID</th>
    <th>MedicineName</th>
    <th>MedicineCount</th>
    <th>OrderStatus</th>
    `;
        table.appendChild(row1);
        for (let i = 0; i < OrderList.length; i++) {
            if (OrderList[i].userID == CurrentUser.userID) {
                let row = document.createElement("tr");
                row.innerHTML = `
            <td>${OrderList[i].orderID}</td>
            <td>${OrderList[i].medicineID}</td>
            <td>${OrderList[i].userID}</td>
            <td>${OrderList[i].medicineName}</td>
            <td>${OrderList[i].medicineCount}</td>
            <td>${OrderList[i].orderStatus}</td>
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
    menu.style.display = "none";
    homepage.style.display = "block";
}
function No() {
    logout.style.display = "none";
    displayNone();
    Home();
}
