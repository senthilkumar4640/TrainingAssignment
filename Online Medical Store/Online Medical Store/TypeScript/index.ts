let UserIdAutoIncrement = 1000;
let MedicineIdAutoIncrement = 10;
let OrderIdAutoIncrement = 100;
let CurrentUser: User;
let CurrentUserId: string;
let CurrentUserName: string;

// let NewUserNameStatus = false;
// let NewUserAgeStatus = false;
// let NewUserPhoneNumberStatus = false;
let nameInput = document.getElementById('name') as HTMLInputElement;
let emailInput = document.getElementById('email') as HTMLInputElement;
let pwdInput = document.getElementById('pwd') as HTMLInputElement;
let phnInput = document.getElementById('phn') as HTMLInputElement;

interface User {

  userID: number;
  userName: string;
  userEmail: string;
  userPassword: string;
  userBalance: number;
}

interface MedicineInfo {

  medicineID: number;
  medicineName: string;
  medicineCount: number;
  medicinePrice: number;
  medicineExpiryDate: String;
}


interface Order {
  orderID: number;
  medicineID: number;
  userID: number;
  medicineName: string;
  medicineCount: number;
  orderStatus: string;
}




let signin = document.getElementById('sign-in') as HTMLDivElement;
let signup = document.getElementById('form') as HTMLFormElement;
let homepage = document.getElementById('homepage') as HTMLDivElement;

//homepage.style.display = "none"
let menu = document.getElementById('menubar') as HTMLDivElement;
signup.style.display = "none"
menu.style.display = "none"
//signup function
function SignInPage() {

  signin.style.display = "block"
  signup.style.display = "none"
}

function SignUpPage() {
  signin.style.display = "none"
  signup.style.display = "block"
}

function MenuBar() {
  menu.style.display = "block"
  homepage.style.display = "none"
}



async function SignIn() {
  const UserList = await fetchUser();
  let email = document.getElementById('email1') as HTMLInputElement;
  let password = document.getElementById('pwd1') as HTMLInputElement;
  let isFlag: boolean = true

  for (var i = 0; i < UserList.length; i++) {
    if (UserList[i].userEmail == email.value && UserList[i].userPassword == password.value) {
      CurrentUser = UserList[i];
      isFlag = false;
    }
  }
  if (isFlag) {
    alert("Invalid Email or Password")
  }

  else {
    alert("Signed In Successfully");

    MenuBar();
  }

}



let editingId: number | null = null;
const form = document.getElementById("form") as HTMLFormElement;
const nameInput1 = document.getElementById("name") as HTMLInputElement;
const emailInput1 = document.getElementById("email") as HTMLInputElement;
const pwdInput1 = document.getElementById("pwd") as HTMLInputElement;
const cnfpwdInput1 = document.getElementById("cnfpwd") as HTMLInputElement;

form.addEventListener("submit", (event) => {
  event.preventDefault();
  const name = nameInput1.value.trim();
  const email = emailInput1.value.trim();
  const pwd = pwdInput1.value.trim();
  const cnfpwd = cnfpwdInput1.value.trim();
  if (editingId !== null) {
    const user: User = {
      userID: editingId,
      userName: name,
      userEmail: email,
      userPassword: pwd,
      userBalance: 0
    };
    updateUser(editingId, user);
  }
  else {
    const user: User = {
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

const form1 = document.getElementById("formsignin") as HTMLFormElement;
const nameInput2 = document.getElementById("name1") as HTMLInputElement;
const emailInput2 = document.getElementById("email1") as HTMLInputElement;



async function addUser(user: User): Promise<void> {
  const response = await fetch('http://localhost:5072/api/User', {
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
}

async function addMedicine(medicine: MedicineInfo): Promise<void> {
  const response = await fetch('http://localhost:5072/api/MedicalInfo', {
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
}



async function editUser(id: number) {
  editingId = id;
  const user = await fetchUser();
  const users = user.find(user => user.userID === id);
  if (users) {
    nameInput1.value = users.userName;
    emailInput1.value = users.userEmail;
    phnInput.value = users.userPassword
  }
}

const medName = document.getElementById("med-name") as HTMLInputElement;
const medprice = document.getElementById("med-price") as HTMLInputElement;
const medQuantity = document.getElementById("med-quantity") as HTMLInputElement;
const medExpDate = document.getElementById("med-exp-date") as HTMLInputElement;

async function editMedicine(id: number) {
  editingId = id;
  const medicine = await fetchMedicine();
  const medicines = medicine.find(medicine => medicine.medicineID === id);
  if (medicines) {
    medName.value = medicines.medicineName;
    medprice.value = medicines.medicinePrice.toString();
    medQuantity.value = medicines.medicineCount.toString();
    medExpDate.value = medicines.medicineExpiryDate.toString();
  }
}

async function deleteMedicine(id: number): Promise<void> {
  const response = await fetch(`http://localhost:5072/api/MedicalInfo/${id}`, {
    method: 'DELETE'
  });
  if (!response.ok) {
    throw new Error('Failed to delete contact');
  }
  MedicineDetails();
  // renderContacts();
}

async function updateUser(id: number, user: User): Promise<void> {
  const response = await fetch(`http://localhost:5072/api/User/${id}`, {
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
}




async function updateMedicine(id: number, medicine: MedicineInfo): Promise<void> {
  const response = await fetch(`http://localhost:5072/api/MedicalInfo/${id}`, {
    method: 'PUT',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(medicine)
  });
  if (!response.ok) {
    throw new Error('Failed to update contact');
  }
  MedicineDetails()
  // renderContacts();
}


async function updateMedicineCancel(id: number, medicine: MedicineInfo): Promise<void> {
  const response = await fetch(`http://localhost:5072/api/MedicalInfo/${id}`, {
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
}

async function updateMedicinePurchase(id: number, medicine: MedicineInfo): Promise<void> {
  const response = await fetch(`http://localhost:5072/api/MedicalInfo/${id}`, {
    method: 'PUT',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(medicine)
  });
  if (!response.ok) {
    throw new Error('Failed to update contact');
  }
  Purchase()
  // renderContacts();
}
async function fetchUser(): Promise<User[]> {
  const apiUrl = 'http://localhost:5072/api/User';
  const response = await fetch(apiUrl);
  if (!response.ok) {
    throw new Error('Failed to fetch contacts');
  }
  return await response.json();
}


async function fetchMedicine(): Promise<MedicineInfo[]> {
  const apiUrl = 'http://localhost:5072/api/MedicalInfo';
  const response = await fetch(apiUrl);
  if (!response.ok) {
    throw new Error('Failed to fetch contacts');
  }
  return await response.json();
}

async function fetchOrder(): Promise<Order[]> {
  const apiUrl = 'http://localhost:5072/api/Order';
  const response = await fetch(apiUrl);
  if (!response.ok) {
    throw new Error('Failed to fetch contacts');
  }
  return await response.json();
}

let topup = document.getElementById('topup') as HTMLInputElement;
let topupbutton = document.getElementById('topupbutton') as HTMLInputElement;
let addbutton = document.getElementById('add') as HTMLDivElement;
var editbutton = document.getElementById('edit') as HTMLDivElement;
var homeBar = document.getElementById('home-tab') as HTMLDivElement;
var MedicineDetailsBar = document.getElementById('medicine-details-tab') as HTMLDivElement;
var purchaseBar = document.getElementById('purchase-tab') as HTMLDivElement;
var cancelBar = document.getElementById('cancel-tab') as HTMLDivElement;
var showBalanceBar = document.getElementById('show-balance-tab') as HTMLDivElement;
var topUpBar = document.getElementById('top-up-tab') as HTMLDivElement;
var orderHistoryBar = document.getElementById('order-history-tab') as HTMLDivElement;
var logout = document.getElementById('logout-tab') as HTMLDivElement;

logout.style.display = "none";
MedicineDetailsBar.style.display = "none";
purchaseBar.style.display = "none";
cancelBar.style.display = "none";
topup.style.display = "none";
topupbutton.style.display = "none";
orderHistoryBar.style.display = "none";
addbutton.style.display = "none"
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
  let homeTab = document.getElementById('welcome') as HTMLDivElement;
  homeBar.style.display = "block";
  //menu.style.display="block"; 
  homeTab.innerHTML = "Welcome " + CurrentUser.userName;
}


async function MedicineDetails() {
  const MedicineList = await fetchMedicine();
  displayNone();
  MedicineDetailsBar.style.display = "block";
  let Table = document.getElementById('medicine-table') as HTMLTableElement
  Table.innerHTML = "";
  let headRow = document.createElement('tr');
  headRow.innerHTML =
    `<th>Medicine Name</th>
    <th>Medicine Price </th>
    <th>Quantity</th>
    <th>Expiry Date</th>
    <th>Modify</th>`
  Table.appendChild(headRow);

  for (var i = 0; i < MedicineList.length; i++) {
    let bodyRow = document.createElement('tr');
    bodyRow.innerHTML =
      `
            <td>${MedicineList[i].medicineName}</td>
            <td>${MedicineList[i].medicinePrice}</td>
            <td>${MedicineList[i].medicineCount}</td>
            <td>${MedicineList[i].medicineExpiryDate.split('T')[0].split('-').reverse().join('/')
      }</td>
            <td><button onclick="edit(${i})">Edit</button><button onclick="del(${MedicineList[i].medicineID})">Delete</button></td>
            `;
    Table.appendChild(bodyRow);
  }
}

async function addOrder(order: Order): Promise<void> {
  const response = await fetch('http://localhost:5072/api/Order', {
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
}

async function updateOrder(id: number, order: Order): Promise<void> {
  const response = await fetch(`http://localhost:5072/api/Order/${id}`, {
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
}


async function Purchase() {
  const MedicineList = await fetchMedicine();
  displayNone()
  purchaseBar.style.display = "block";
  let Table = document.getElementById('purchase-table') as HTMLTableElement
  Table.innerHTML = "";
  let headRow = document.createElement('tr');
  headRow.innerHTML =
    `<th>Medicine Name</th>
    <th>Medicine Price </th>
    <th>Quantity</th>
    <th>Expiry Date</th>
    <th>Action</th>`
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
}

async function buy(count: number) {
  let MedicineList = await fetchMedicine();
  for (let i = 0; i < MedicineList.length; i++) {
    if (i == count) {
      let option = prompt("enter the count");
      let option1: number = Number(option)

      if (option1 < MedicineList[i].medicineCount) {
        if (CurrentUser.userBalance >= MedicineList[i].medicinePrice * option1) {
          CurrentUser.userBalance -= MedicineList[i].medicinePrice * option1;
          MedicineList[i].medicineCount -= option1;
          let order: Order = {
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
}


function Add() {
  addbutton.style.display = "block";
  editbutton.style.display = "none";
}
function ShowAdd() {

  let medName = document.getElementById('med-name') as HTMLInputElement;
  let medPrice = document.getElementById('med-price') as HTMLInputElement;
  let medQuantity = document.getElementById('med-quantity') as HTMLInputElement;
  let medExpDate = document.getElementById('med-exp-date') as HTMLInputElement;
  const medicine: MedicineInfo = {
    medicineID: 0,
    medicineName: medName.value,
    medicinePrice: Number(medPrice.value),
    medicineCount: Number(medQuantity.value),
    medicineExpiryDate: medExpDate.value
  }
  addMedicine(medicine);
  medName.value = "";
  medPrice.value = "";
  medQuantity.value = "";
  medExpDate.value = "";
  MedicineDetails();
}

let medIndex: number = 0;
async function edit(count: number) {
  const MedicineList = await fetchMedicine();
  editbutton.style.display = "block"
  addbutton.style.display = "none"
  medIndex = count;
  for (var i = 0; i < MedicineList.length; i++) {
    if (i == medIndex) {
      (document.getElementById('edit-name') as HTMLInputElement).value = MedicineList[i].medicineName.toString();
      (document.getElementById('edit-price') as HTMLInputElement).value = MedicineList[i].medicinePrice.toString();
      (document.getElementById('edit-quantity') as HTMLInputElement).value = MedicineList[i].medicineCount.toString();
      (document.getElementById("edit-exp-date") as HTMLInputElement).value = MedicineList[i].medicineExpiryDate.split('T')[0];

    }
  }
}

async function ShowEdit() {
  const MedicineList = await fetchMedicine();
  for (var i = 0; i < MedicineList.length; i++) {
    if (i == medIndex) {
      MedicineList[i].medicineName = (document.getElementById('edit-name') as HTMLInputElement).value;
      MedicineList[i].medicinePrice = Number((document.getElementById('edit-price') as HTMLInputElement).value);
      MedicineList[i].medicineCount = Number((document.getElementById('edit-quantity') as HTMLInputElement).value);
      MedicineList[i].medicineExpiryDate = (document.getElementById('edit-exp-date') as HTMLInputElement).value;

      updateMedicine(MedicineList[i].medicineID, MedicineList[i]);
      (document.getElementById('edit-name') as HTMLInputElement).value = "";
      (document.getElementById('edit-price') as HTMLInputElement).value = "";
      (document.getElementById('edit-quantity') as HTMLInputElement).value = "";
      (document.getElementById('edit-exp-date') as HTMLInputElement).value = "";
      MedicineDetails();

    }
  }
}

function del(count: number) {
  deleteMedicine(count);
  MedicineDetails();
}



async function Cancel() {
  displayNone()
  const OrderList = await fetchOrder();
  cancelBar.style.display = "block";
  let Table = document.getElementById('cancel-table') as HTMLTableElement
  Table.innerHTML = "";
  let headRow = document.createElement('tr');
  headRow.innerHTML =
    `<th>Order ID</th>
    <th>User ID</th>
    <th>Medicine Name</th>
    <th>Total Count</th>
    <th>Order Status</th>
    <th>Cancel</th>`
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
}

async function can(count: number) {
  const OrderList = await fetchOrder();
  const MedicineList = await fetchMedicine();
  for (var i = 0; i < OrderList.length; i++) {
    if (i == count) {
      OrderList[i].orderStatus = "cancelled";
      let price: number = 0;
      for (var j = 0; j < MedicineList.length; j++) {
        if (MedicineList[j].medicineID == OrderList[i].medicineID) {
          MedicineList[j].medicineCount += OrderList[i].medicineCount;
          price = MedicineList[j].medicinePrice * OrderList[i].medicineCount;
          updateMedicineCancel(MedicineList[j].medicineID, MedicineList[j])
          break;
        }
      }
      CurrentUser.userBalance += price;
      updateUser(CurrentUser.userID, CurrentUser)
      alert("Ordered Cancelled");
      updateOrder(OrderList[i].orderID, OrderList[i]);
      Cancel();
    }
  }
}

function ShowBalance() {
  displayNone();
  showBalanceBar.style.display = "block";
  let balanceShow = document.getElementById('balance') as HTMLDivElement;
  balanceShow.innerHTML = "Your Balance is " + CurrentUser.userBalance;
}


function TopUp() {
  displayNone();
  topUpBar.style.display = "block";
  let topup = document.getElementById('topup') as HTMLInputElement;
  topup.style.display = "block";
  let topupbutton = document.getElementById('topupbutton') as HTMLInputElement;
  topupbutton.style.display = "block";
}
async function updateamount(id: number, amt: number): Promise<void> {
  const response = await fetch(`http://localhost:5072/api/User/${id}/${amt}`, {
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
}


function Deposit() {
  let topup = document.getElementById('topup') as HTMLInputElement;
  CurrentUser.userBalance = Number(topup.value) + CurrentUser.userBalance;
  alert("RecrentUser.userharged Sucessfully");
  updateamount(CurrentUser.userID, Number(topup.value))
  topup.value = "";
}


async function OrderHistory() {
  displayNone();
  orderHistoryBar.style.display = "block";
  let OrderList = await fetchOrder();
  let table = document.getElementById("order-history-table") as HTMLTableElement
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
