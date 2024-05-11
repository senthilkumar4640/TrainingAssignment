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

enum Status {
    ordered = "ordered",
    Cancelled = "Cancelled"
}

class User {

    UserId: string;
    UserName: string;
    UserEmail: string;
    UserPassword: string;
    UserPhoneNumber: string;
    UserBalance: number = 0;

    constructor(paramUserName: string, paramUserEmail: string, paramUserPassword: string, paramUserPhoneNumber: string) {

        UserIdAutoIncrement++;

        this.UserId = "UI" + UserIdAutoIncrement;
        this.UserName = paramUserName;
        this.UserEmail = paramUserEmail;
        this.UserPassword = paramUserPassword;
        this.UserPhoneNumber = paramUserPhoneNumber;
    }

}

class MedicineInfo {

    MedicineId: string;
    MedicineName: string;
    MedicineCount: number;
    MedicinePrice: number;
    MedicineExpiryDate: Date;

    constructor(paramMedicineName: string, paramMedicineCount: number, paramMedicinePrice: number, paramedicineExpiryDate: Date) {
        MedicineIdAutoIncrement++;

        this.MedicineId = "MD" + MedicineIdAutoIncrement.toString();
        this.MedicineName = paramMedicineName;
        this.MedicineCount = paramMedicineCount;
        this.MedicinePrice = paramMedicinePrice;
        this.MedicineExpiryDate = paramedicineExpiryDate;
    }

}



class Order {
    OrderId: string;
    MedicineId: string;
    UserId: string;
    MedicineName: string;
    MedicineCount: number;
    TotalPrice: number;
    OrderDate: string;
    OrderStatus: Status;

    constructor(paramUserId: string, paramMedicineId: string, paramMedicineName: string, paramMedicineCount: number, paramTotalPrice: number, paramOrderDate: string, paramOrderStatus: Status) {
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



let UserArrayList: Array<User> = new Array<User>();

UserArrayList.push(new User("Hemanth", "hemanth@gmail.com", "Hemanth@123", "9789011226"));
UserArrayList.push(new User("Harish", "Harish@gmail.com", "Harish@123", "9445153060"));

let MedicineList: Array<MedicineInfo> = new Array<MedicineInfo>();

MedicineList.push(new MedicineInfo("Paracetomol", 5, 50, new Date(2024, 2, 8)));
MedicineList.push(new MedicineInfo("Colpal", 5, 60, new Date(2024, 2, 12)));
MedicineList.push(new MedicineInfo("Stepsil", 5, 70, new Date(2026, 9, 3)));
MedicineList.push(new MedicineInfo("Iodex", 5, 80, new Date(2025, 1, 9)));
MedicineList.push(new MedicineInfo("Acetherol", 5, 100, new Date(2028, 5, 20)));

let OrderList: Array<Order> = new Array<Order>();//Array only created



let signin = document.getElementById('sign-in') as HTMLDivElement;
let signup = document.getElementById('sign-up') as HTMLDivElement;
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

function SignIn(): void {
    let email = document.getElementById('email1') as HTMLInputElement;
    let password = document.getElementById('pwd1') as HTMLInputElement;
    var isflag: boolean = true;
    for (var i = 0; i < UserArrayList.length; i++) {
        if (UserArrayList[i].UserEmail.toLowerCase() == email.value.toLowerCase() && UserArrayList[i].UserPassword == password.value) {
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

function SignUp(): void {
    let email = document.getElementById('email') as HTMLInputElement;
    var isflag: boolean = true;
    for (var i = 0; i < UserArrayList.length; i++) {
        if (UserArrayList[i].UserEmail == email.value) {
            isflag = false;
            break
        }
    }
    if (isflag == true) {
        let user: User = new User(nameInput.value, emailInput.value, pwdInput.value, phnInput.value);
        UserArrayList.push(user);
        CurrentUser = user;
        MenuBar();

    }
    if (isflag == false) {
        let User:User={
            userName: name,
            userEmail: email,
            userPassword: pwd1,
            userPhoneNumber: phone,
            userBalance:0,
        }
        addUser(User);
        alert("Sccussfully created");
        SignIn();
    }
    else {
        alert("mailid is already in used");
    }
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

MedicineDetailsBar.style.display = "none";
purchaseBar.style.display = "none";
cancelBar.style.display = "none";
topup.style.display = "none";
topupbutton.style.display = "none";
orderHistoryBar.style.display = "none";
addbutton.style.display = "none"
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
    let homeTab = document.getElementById('welcome') as HTMLDivElement;
    homeBar.style.display = "block";
    //menu.style.display="block"; 
    homeTab.innerHTML = "Welcome" + CurrentUser.UserName;
}


function MedicineDetails() {
    displayNone()
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
            <td>${MedicineList[i].MedicineName}</td>
            <td>${MedicineList[i].MedicinePrice}</td>
            <td>${MedicineList[i].MedicineCount}</td>
            <td>${MedicineList[i].MedicineExpiryDate.toLocaleDateString()}</td>
            <td><button onclick="buy(${i})">Buy</button></td>
            `;
        Table.appendChild(bodyRow);
    }
}

function buy(count: number) {
    for (var i = 0; i < MedicineList.length; i++) {
        if (i == count) {
            var option: number = Number(prompt("Enter the count"));
            if (option !< 0 && option != 0 && option != null) {
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

    let medName = document.getElementById('med-name') as HTMLInputElement;
    let medPrice = document.getElementById('med-price') as HTMLInputElement;
    let medQuantity = document.getElementById('med-quantity') as HTMLInputElement;
    let medExpDate = document.getElementById('med-exp-date') as HTMLInputElement;
    let str = medExpDate.value;
    const strArray: string[] = str.split("-");
    let medDate = new Date(Number(strArray[0]), (Number(strArray[1]) - 1), Number(strArray[2]));

    MedicineList.push(new MedicineInfo(medName.value, Number(medPrice.value), Number(medQuantity.value), medDate));
    MedicineDetails();
}

let medIndex: number = 0;
function edit(count: number) {
    editbutton.style.display = "block"
    addbutton.style.display = "none"
    medIndex = count;
    for (var i = 0; i < MedicineList.length; i++) {
        if (i == medIndex) {
            (document.getElementById('edit-name') as HTMLInputElement).value = MedicineList[i].MedicineName.toString();
            (document.getElementById('edit-price') as HTMLInputElement).value = MedicineList[i].MedicinePrice.toString();
            (document.getElementById('edit-quantity') as HTMLInputElement).value = MedicineList[i].MedicineCount.toString();
            let date: string | number = MedicineList[i].MedicineExpiryDate.getDate();
            let month: string | number = MedicineList[i].MedicineExpiryDate.getMonth() + 1;
            if (date < 10) {
                date = "0" + date;
            }
            if (month < 10) {
                month = "0" + month;
            }
            let year: string | number = MedicineList[i].MedicineExpiryDate.getFullYear();
            (document.getElementById('edit-exp-date') as HTMLInputElement).value = `${year}-${month}-${date}`;

        }
    }
}

function ShowEdit() {
    for (var i = 0; i < MedicineList.length; i++) {
        if (i == medIndex) {
            MedicineList[i].MedicineName = (document.getElementById('edit-name') as HTMLInputElement).value;
            MedicineList[i].MedicinePrice = Number((document.getElementById('edit-price') as HTMLInputElement).value);
            MedicineList[i].MedicineCount = Number((document.getElementById('edit-quantity') as HTMLInputElement).value);
            let str: string = (document.getElementById('edit-exp-date') as HTMLInputElement).value;
            let strArray1: string[] = str.split("-");
            let medDate = new Date(Number(strArray1[0]), (Number(strArray1[1]) - 1), Number(strArray1[2]));
            MedicineList[i].MedicineExpiryDate = medDate;
            MedicineDetails();

        }
    }
}

function del(count: number) {
    MedicineList = MedicineList.filter(remove => MedicineList.indexOf(remove) != count);
    MedicineDetails();
}



function Cancel() {
    displayNone()
    cancelBar.style.display = "block";
    let Table = document.getElementById('cancel-table') as HTMLTableElement
    Table.innerHTML = "";
    let headRow = document.createElement('tr');
    headRow.innerHTML =
        `<th>Order ID</th>
    <th>User ID</th>
    <th>Medicine Name</th>
    <th>Total Price</th>
    <th>Order Status</th>
    <th>Modify</th>`
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

function can(count: number) {
    for (var i = 0; i < OrderList.length; i++) {
        if (i == count) {
            OrderList[i].OrderStatus = Status.Cancelled;
            let price: number = 0;
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
    let balanceShow = document.getElementById('balance') as HTMLDivElement;
    balanceShow.innerHTML = "Your Balance is " + CurrentUser.UserBalance;
}


function TopUp() {
    displayNone();
    topUpBar.style.display = "block";
    let topup = document.getElementById('topup') as HTMLInputElement;
    topup.style.display = "block";
    let topupbutton = document.getElementById('topupbutton') as HTMLInputElement;
    topupbutton.style.display = "block";
}

function Deposit() {
    let topup = document.getElementById('topup') as HTMLInputElement;
    CurrentUser.UserBalance = Number(topup.value) + CurrentUser.UserBalance;
    alert("Recharged Sucessfully");
    topup.value = "";
}


function OrderHistory() {
    displayNone();
    orderHistoryBar.style.display = "block";
    let Table = document.getElementById('order-history-table') as HTMLTableElement
    Table.innerHTML = "";
    let headRow = document.createElement('tr');
    headRow.innerHTML =
        `<th>Order ID</th>
    <th>User ID</th>
    <th>Medicine Name</th>
    <th>Total Price</th>
    <th>Order Status</th>`
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
