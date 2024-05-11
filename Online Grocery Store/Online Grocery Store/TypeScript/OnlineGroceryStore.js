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
//fetch UserDetails
function fetchUser() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5086/api/UserDetails';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch userdetails');
        }
        return yield response.json();
    });
}
//fetch ProductDetails
function fetchProduct() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5086/api/ProductDetails';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch ProductDetails');
        }
        return yield response.json();
    });
}
//fetch OrderDetails
function fetchOrder() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5086/api/OrderDetails';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch OrderDetails');
        }
        return yield response.json();
    });
}
//add BookingDetails
function addBooking(booking) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5086/api/BookingDetails', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(booking)
        });
        if (!response.ok) {
            throw new Error('failed to fetch Data');
        }
        return yield response.json();
    });
}
//add UserDetails
function addUser(user) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5086/api/UserDetails', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        });
        if (!response.ok) {
            throw new Error('Failed to add UserDetails');
        }
    });
}
//update UserBalance
function updateAmount(id, amt) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5086/api/UserDetails/${id}/${amt}`, {
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
//update UserDetails
function updateUser(id, user) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5086/api/UserDetails/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        });
        if (!response.ok) {
            throw new Error('Failed to update UserDetails');
        }
    });
}
//add ProductDetails
function addProduct(product) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5086/api/ProductDetails', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(product)
        });
        if (!response.ok) {
            throw new Error('Failed to add ProductDetails');
        }
        //
    });
}
//edit ProductDetails
function updateProduct(id, product) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5086/api/ProductDetails/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(product)
        });
        if (!response.ok) {
            throw new Error('Failed to update book');
        }
        //;
    });
}
//delete ProductDetails
function deleteProduct(id) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5086/api/ProductDetails/${id}`, {
            method: 'DELETE'
        });
        if (!response.ok) {
            throw new Error('Failed to delete ProductDetails');
        }
        //
    });
}
//add OrderDetails
function addOrder(order) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5086/api/OrderDetails', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(order)
        });
        if (!response.ok) {
            throw new Error('Failed to add OrderDetails');
        }
    });
}
//edit OrderDetails
function updateOrder(id, order) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5086/api/OrderDetails/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(order)
        });
        if (!response.ok) {
            throw new Error('Failed to update OrderDetails');
        }
        //
    });
}
//delete OrderDetails
function deleteOrder(id) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5086/api/OrderDetails/${id}`, {
            method: 'DELETE'
        });
        if (!response.ok) {
            throw new Error('Failed to delete OrderDetails');
        }
        //
    });
}
function updateProductCount(id, count) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5086/api/ProductDetails/${id}/${count}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        if (!response.ok) {
            throw new Error('failed to fetch Data');
        }
        // return await response.json();
    });
}
function fetchBooking() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5086/api/BookingDetails';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('failed to fetch Data');
        }
        return yield response.json();
    });
}
var homepage = document.getElementById('homepage');
var signup = document.getElementById('signup');
var signupinput = document.getElementById('sign-up');
var signin = document.getElementById('signin');
var signininput = document.getElementById('sign-in');
var menubars = document.getElementById('menubars');
var home = document.getElementById('home-tab');
var productDetails = document.getElementById('product-details-tab');
var purchase = document.getElementById('purchase-tab');
var cartItem = document.getElementById('cart-item-tab');
var orderHistory = document.getElementById('order-history-tab');
var recharge = document.getElementById('recharge-tab');
var showBalance = document.getElementById('show-balance-tab');
var logout = document.getElementById('logout-tab');
var addbutton = document.getElementById('add');
// var editbutton = document.getElementById('edit') as HTMLDivElement;
let rechargeAmount = document.getElementById('recharge-amount');
let rechargeButton = document.getElementById('rechargebutton');
signininput.style.display = "none";
menubars.style.display = "none";
home.style.display = "none";
productDetails.style.display = "none";
purchase.style.display = "none";
cartItem.style.display = "none";
orderHistory.style.display = "none";
recharge.style.display = "none";
showBalance.style.display = "none";
logout.style.display = "none";
addbutton.style.display = "none";
// editbutton.style.display = "none";
rechargeAmount.style.display = "none";
rechargeButton.style.display = "none";
function displayNone() {
    home.style.display = "none";
    productDetails.style.display = "none";
    purchase.style.display = "none";
    cartItem.style.display = "none";
    orderHistory.style.display = "none";
    recharge.style.display = "none";
    showBalance.style.display = "none";
    logout.style.display = "none";
}
//signup
function SignUp() {
    signupinput.style.display = "block";
    signininput.style.display = "none";
}
//Signin
function SignIn() {
    signupinput.style.display = "none";
    signininput.style.display = "block";
}
//SignInSubmit
function SignInSubmit() {
    return __awaiter(this, void 0, void 0, function* () {
        const UserList = yield fetchUser();
        let email = document.getElementById('email1');
        let password = document.getElementById('pwd1');
        let isFlag = true;
        for (var i = 0; i < UserList.length; i++) {
            if (UserList[i].userEmail == email.value && UserList[i].userPassword == password.value) {
                CurrentUser = UserList[i];
                isFlag = false;
                email.value = "";
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
function MenuBar() {
    return __awaiter(this, void 0, void 0, function* () {
        menubars.style.display = "block";
        homepage.style.display = "none";
    });
}
//Home
function Home() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        home.style.display = "block";
        // (document.getElementById('welcome') as HTMLHeadElement).innerHTML = "Welcome " + CurrentUser.userName
        const UserList = yield fetchUser();
        let Table = document.getElementById('home-table');
        Table.innerHTML = "";
        let headRow = document.createElement('tr');
        headRow.innerHTML =
            `
    <th>Welcome ${CurrentUser.userName}</th>`;
        Table.appendChild(headRow);
        for (var i = 0; i < UserList.length; i++) {
            if (CurrentUser) {
                let bodyRow = document.createElement('tr');
                bodyRow.innerHTML =
                    `
                <td><img id="image" src="${UserList[i].userImage[0]}"></td>
                `;
                Table.appendChild(bodyRow);
            }
        }
    });
}
//logout
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
//walletrecharge
function Recharge() {
    displayNone();
    recharge.style.display = "block";
    rechargeAmount.style.display = "block";
    rechargeButton.style.display = "block";
}
function Deposit() {
    CurrentUser.userBalance = Number(rechargeAmount.value) + CurrentUser.userBalance;
    alert("Recharged Sucessfully");
    updateAmount(CurrentUser.userID, Number(rechargeAmount.value));
    rechargeAmount.value = "";
}
//show balance
function ShowBalance() {
    displayNone();
    showBalance.style.display = "block";
    let balanceShow = document.getElementById('balance');
    balanceShow.innerHTML = "Your Balance is " + CurrentUser.userBalance;
}
let nameInput = document.getElementById('name');
let imageInput = document.getElementById('images');
let addressInput = document.getElementById('address');
let phoneInput = document.getElementById('phone');
let emailInput = document.getElementById('email');
let pwdInput = document.getElementById('pwd');
let balanceInput = document.getElementById('balance');
let form = document.getElementById('sign-up');
let base64String = "";
//SignUpSubmit
let editingID = null;
form.addEventListener("submit", (event) => {
    var _a;
    event.preventDefault();
    const name = nameInput.value.trim();
    const email = emailInput.value.trim();
    const password = pwdInput.value.trim();
    const phone = phoneInput.value.trim();
    var images = imageInput;
    const address = addressInput.value.trim();
    const file = (_a = images.files) === null || _a === void 0 ? void 0 : _a[0];
    const reader = new FileReader();
    if (file) {
        reader.onload = function (event) {
            var _a;
            base64String = (_a = event.target) === null || _a === void 0 ? void 0 : _a.result;
            console.log(base64String);
            if (editingID !== null) {
                const user = {
                    userID: editingID,
                    userName: name,
                    userEmail: email,
                    userPassword: password,
                    userPhone: phone,
                    userImage: [base64String],
                    userAddress: address,
                    userBalance: 0
                };
                updateUser(editingID, user);
            }
            else {
                const user = {
                    userID: undefined,
                    userName: name,
                    userEmail: email,
                    userPassword: password,
                    userPhone: phone,
                    userImage: [base64String],
                    userAddress: address,
                    userBalance: 0
                };
                addUser(user);
                alert("User Registered Successfully");
            }
            form.reset();
        };
        reader.readAsDataURL(file);
    }
});
function ProductDetails() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        const ProductDetails = yield fetchProduct();
        productDetails.style.display = "block";
        let Table = document.getElementById('product-table');
        Table.innerHTML = "";
        let headRow = document.createElement('tr');
        headRow.innerHTML =
            `
    <th>PRODUCT NAME</th>
    <th>PRODUCT QUANTITY</th>
    <th>PRODUCT PRICE</th>
    <th>PURCHASE DATE</th>
    <th>EXPIRY DATE</th>
    <th>IMAGE</th>
    <th>EDIT</th>
    <th>DELETE</th>`;
        Table.appendChild(headRow);
        for (var i = 0; i < ProductDetails.length; i++) {
            let bodyRow = document.createElement('tr');
            bodyRow.innerHTML =
                `
            <td>${ProductDetails[i].productName}</td>
            <td>${ProductDetails[i].productQuantity}</td>
            <td>${ProductDetails[i].productPrice}</td>
            <td>${ProductDetails[i].productPurchaseDate.toString().split('T')[0].split('-').reverse().join('/')}</td>
            <td>${ProductDetails[i].productExpiryDate.toString().split('T')[0].split('-').reverse().join('/')}</td>
            <td><img src="${ProductDetails[i].productImage}"></td>
            <td><button onclick="EditButton(${ProductDetails[i].productID})">EDIT</button></td>
            <td><button onclick="DeleteButton(${ProductDetails[i].productID})">DELETE</button></td>
            `;
            Table.appendChild(bodyRow);
        }
    });
}
//addbuttton
function AddButton() {
    addbutton.style.display = "block";
    // editbutton.style.display = "none";
}
let editingID1 = null;
function EditButton(count) {
    return __awaiter(this, void 0, void 0, function* () {
        // editbutton.style.display = "block"
        addbutton.style.display = "block";
        editingID1 = count;
        const ProductList = yield fetchProduct();
        for (var i = 0; i < ProductList.length; i++) {
            if (ProductList[i].productID == editingID1) {
                document.getElementById('product-name').value = ProductList[i].productName.toString();
                document.getElementById('product-quantity').value = ProductList[i].productQuantity.toString();
                document.getElementById('product-price').value = ProductList[i].productPrice.toString();
                document.getElementById('product-purchase-date').value = ProductList[i].productPurchaseDate.toString().split('T')[0];
                document.getElementById('product-expiry-date').value = ProductList[i].productExpiryDate.toString().split('T')[0];
            }
        }
    });
}
//delete
function DeleteButton(count) {
    deleteProduct(count);
}
function Purchase() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        const ProductDetails = yield fetchProduct();
        purchase.style.display = "block";
        let div = document.getElementById('purchase-tab');
        div.innerHTML = "";
        for (var i = 0; i < ProductDetails.length; i++) {
            let bodyRow = document.createElement('div');
            bodyRow.className = "div3";
            bodyRow.innerHTML =
                `
            <div class="div1">
            <td><img src="${ProductDetails[i].productImage}"></td>
            <div class = "div2">
            <td id="name">${ProductDetails[i].productName}</td>
            <td id="price">${ProductDetails[i].productQuantity}</td>
            </div>
            </div>
            <td><button onclick="AddToCart(${ProductDetails[i].productID},'${ProductDetails[i].productName}',${ProductDetails[i].productQuantity},${ProductDetails[i].productPrice})"  >Add To Cart</button></td>
            `;
            div.appendChild(bodyRow);
        }
    });
}
//add edit sumbit
let nameInputs = document.getElementById('product-name');
let quantityInputs = document.getElementById('product-quantity');
let priceInputs = document.getElementById('product-price');
let purchaseDateInputs = document.getElementById('product-purchase-date');
let expiryDateInputs = document.getElementById('product-expiry-date');
let imageInputs = document.getElementById('productimage');
let forms = document.getElementById('product-form');
let base64Strings = "";
forms.addEventListener("submit", (event) => {
    var _a;
    event.preventDefault();
    const name = nameInputs.value.trim();
    const quantity = quantityInputs.value.trim();
    const price = priceInputs.value.trim();
    const purchaseDate = new Date(purchaseDateInputs.value).toISOString();
    const expiryDate = new Date(expiryDateInputs.value).toISOString();
    const images = imageInputs;
    const file = (_a = images.files) === null || _a === void 0 ? void 0 : _a[0];
    const reader = new FileReader();
    if (file) {
        reader.onload = function (event) {
            var _a;
            base64Strings = (_a = event.target) === null || _a === void 0 ? void 0 : _a.result;
            console.log(base64Strings);
            if (editingID1 !== null) {
                const product = {
                    productID: editingID1,
                    productName: name,
                    productQuantity: +quantity,
                    productPrice: +price,
                    productPurchaseDate: purchaseDate,
                    productExpiryDate: expiryDate,
                    productImage: [base64Strings]
                };
                updateProduct(editingID1, product);
                alert("Product Edited Successfully");
                ProductDetails();
            }
            else {
                const product = {
                    productID: undefined,
                    productName: name,
                    productQuantity: +quantity,
                    productPrice: +price,
                    productPurchaseDate: purchaseDate,
                    productExpiryDate: expiryDate,
                    productImage: [base64Strings]
                };
                addProduct(product);
                ProductDetails();
                alert("Product Added Successfully");
            }
            forms.reset();
        };
        reader.readAsDataURL(file);
    }
});
var tempCart = new Array();
function AddToCart(a, b, c, d) {
    var count = Number(prompt("Enter Quantity"));
    if (count <= c) {
        tempCart.push({ id: tempCart.length, pid: a, productName: b, purchaseCount: count, priceOfOrder: count * d });
    }
    else {
        alert(`Entered Qunatity Not Available \n Available Count:${c}`);
    }
}
function ShowCart() {
    displayNone();
    cartItem.style.display = "block";
    var tbody = document.getElementById("cart-table-body");
    tbody.innerHTML = "";
    ;
    tempCart.forEach((element) => {
        var row = document.createElement("tr");
        row.innerHTML = `

      <td>${element.productName}</td>
      <td>${element.purchaseCount}</td>
      <td>${element.priceOfOrder}</td>
      <td>
      <button onclick="deleteID(${element.id})">Delete</button>
      </td>
      `;
        tbody.appendChild(row);
    });
}
function buy() {
    return __awaiter(this, void 0, void 0, function* () {
        var total = 0;
        tempCart.forEach((val) => {
            total += val.priceOfOrder;
        });
        if (total < CurrentUser.userBalance) {
            var book = yield addBooking({
                bookingID: undefined,
                customerID: CurrentUser.userID,
                totalPrice: total,
                dateOfBooking: new Date().toISOString(),
                bookingStatus: "Booked"
            });
            tempCart.forEach((data) => {
                addOrder({
                    orderID: undefined,
                    bookingID: book.bookingID,
                    productName: data.productName,
                    purchaseCount: data.purchaseCount,
                    productTotalPrice: data.priceOfOrder
                });
                updateProductCount(data.pid, data.purchaseCount);
                CurrentUser.userBalance = CurrentUser.userBalance - total;
                updateAmount(CurrentUser.userID, CurrentUser.userBalance);
            });
            tempCart.splice(0, tempCart.length);
            ShowCart();
        }
        else {
            alert("Insufficient Balance");
        }
    });
}
function OrderHistory() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        orderHistory.style.display = "block";
        orderHistory.innerHTML = "";
        const bookingList = yield fetchBooking();
        const orderList = yield fetchOrder();
        bookingList.forEach((bookID) => {
            if (bookID.customerID == CurrentUser.userID) {
                orderHistory.innerHTML += `
  
      <div id="tab">
            <h2>OrderDate:${bookID.dateOfBooking.split("T")[0].split("-").reverse().join("/")}</h2>
            <h2>Price:${bookID.totalPrice}</h2>
            <button onclick="exportData(${bookID.bookingID})">Export</button>
      </div>
  
      <table id="tb3">
        <thead>
            <tr>
                <th>OrderID</th>
                <th>Name</th>
                <th>Quantity</th>
                <th>Price</th>
            </tr>
        </thead>
        <tbody id="nr${bookID.bookingID}">
        </tbody>
      
  `;
                var d = document.getElementById(`nr${bookID.bookingID}`);
                var c = 0;
                orderList.forEach((element) => {
                    if (element.bookingID == bookID.bookingID) {
                        var row = document.createElement("tr");
                        if (c == 0) {
                            row.innerHTML = ` 
        <td rowspan="5">${element.bookingID}</td>
        <td>${element.productName}</td>
        <td>${element.purchaseCount}</td>
        <td>${element.productTotalPrice}</td>
        `;
                        }
                        else {
                            row.innerHTML = ` 
        <td>${element.productName}</td>
        <td>${element.purchaseCount}</td>
        <td>${element.productTotalPrice}</td>
        `;
                        }
                        c = 3;
                        d.appendChild(row);
                    }
                });
            }
        });
    });
}
function exportData(data) {
    return __awaiter(this, void 0, void 0, function* () {
        var bookingList = yield fetchBooking();
        var bookList = yield fetchOrder();
        var csvdata = "BookingID,ProduuctName,Purchasecount,Price\n";
        bookList.forEach((element) => {
            if (element.bookingID == data) {
                csvdata += `${element.bookingID},${element.productName},${element.purchaseCount},${element.productTotalPrice}\n`;
            }
        });
        var a = new Blob([csvdata], { type: 'text/csv' });
        var b = document.createElement('a');
        var url = URL.createObjectURL(a);
        b.href = url;
        b.download = "Bill";
        b.click();
    });
}
