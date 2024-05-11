interface UserDetails {
    userID: any;
    userName: string;
    userEmail: string;
    userPassword: string;
    userPhone: string;
    userImage: string[];
    userAddress: string;
    userBalance: number;
}

interface ProductDetails {
    productID: any;
    productName: string;
    productQuantity: number;
    productPrice: number;
    productPurchaseDate: string;
    productExpiryDate: string;
    productImage: string[];
}

interface OrderDetails {
    orderID: any;
    bookingID: number;
    productName: string;
    purchaseCount: number;
    productTotalPrice: number;
}

interface BookingDetails {
    bookingID: any,
    customerID: number,
    totalPrice: number,
    dateOfBooking: string,
    bookingStatus: string
}

let CurrentUser: UserDetails;


//fetch UserDetails
async function fetchUser(): Promise<UserDetails[]> {
    const apiUrl = 'http://localhost:5086/api/UserDetails';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('Failed to fetch userdetails');
    }
    return await response.json();
}

//fetch ProductDetails
async function fetchProduct(): Promise<ProductDetails[]> {
    const apiUrl = 'http://localhost:5086/api/ProductDetails';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('Failed to fetch ProductDetails');
    }
    return await response.json();
}

//fetch OrderDetails
async function fetchOrder(): Promise<OrderDetails[]> {
    const apiUrl = 'http://localhost:5086/api/OrderDetails';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('Failed to fetch OrderDetails');
    }
    return await response.json();
}

//add BookingDetails
async function addBooking(booking: BookingDetails): Promise<BookingDetails> {
    const response = await fetch('http://localhost:5086/api/BookingDetails', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(booking)
    });
    if (!response.ok) {
        throw new Error('failed to fetch Data');
    }
    return await response.json();

}

//add UserDetails
async function addUser(user: UserDetails): Promise<void> {
    const response = await fetch('http://localhost:5086/api/UserDetails', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(user)

    });
    if (!response.ok) {
        throw new Error('Failed to add UserDetails');
    }
}

//update UserBalance
async function updateAmount(id: number, amt: number): Promise<void> {
    const response = await fetch(`http://localhost:5086/api/UserDetails/${id}/${amt}`, {
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

//update UserDetails
async function updateUser(id: number, user: UserDetails): Promise<void> {
    const response = await fetch(`http://localhost:5086/api/UserDetails/${id}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(user)
    });
    if (!response.ok) {
        throw new Error('Failed to update UserDetails');
    }
}


//add ProductDetails
async function addProduct(product: ProductDetails): Promise<void> {
    const response = await fetch('http://localhost:5086/api/ProductDetails', {
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
}

//edit ProductDetails
async function updateProduct(id: number, product: ProductDetails): Promise<void> {
    const response = await fetch(`http://localhost:5086/api/ProductDetails/${id}`, {
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
}

//delete ProductDetails
async function deleteProduct(id: number): Promise<void> {
    const response = await fetch(`http://localhost:5086/api/ProductDetails/${id}`, {
        method: 'DELETE'
    });
    if (!response.ok) {
        throw new Error('Failed to delete ProductDetails');
    }
    //
}

//add OrderDetails
async function addOrder(order: OrderDetails): Promise<void> {
    const response = await fetch('http://localhost:5086/api/OrderDetails', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(order)

    });
    if (!response.ok) {
        throw new Error('Failed to add OrderDetails');
    }
}

//edit OrderDetails
async function updateOrder(id: number, order: OrderDetails): Promise<void> {
    const response = await fetch(`http://localhost:5086/api/OrderDetails/${id}`, {
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
}

//delete OrderDetails
async function deleteOrder(id: number): Promise<void> {
    const response = await fetch(`http://localhost:5086/api/OrderDetails/${id}`, {
        method: 'DELETE'
    });
    if (!response.ok) {
        throw new Error('Failed to delete OrderDetails');
    }
    //
}

async function updateProductCount(id: number, count: number): Promise<void> {
    const response = await fetch(`http://localhost:5086/api/ProductDetails/${id}/${count}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        }
    });
    if (!response.ok) {
        throw new Error('failed to fetch Data');
    }
    // return await response.json();
}

async function fetchBooking(): Promise<BookingDetails[]> {
    const apiUrl = 'http://localhost:5086/api/BookingDetails';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('failed to fetch Data');
    }
    return await response.json();
}

var homepage = document.getElementById('homepage') as HTMLDivElement;
var signup = document.getElementById('signup') as HTMLDivElement;
var signupinput = document.getElementById('sign-up') as HTMLFormElement;
var signin = document.getElementById('signin') as HTMLDivElement;
var signininput = document.getElementById('sign-in') as HTMLDivElement;

var menubars = document.getElementById('menubars') as HTMLDivElement;

var home = document.getElementById('home-tab') as HTMLDivElement;
var productDetails = document.getElementById('product-details-tab') as HTMLDivElement;
var purchase = document.getElementById('purchase-tab') as HTMLDivElement;
var cartItem = document.getElementById('cart-item-tab') as HTMLDivElement;
var orderHistory = document.getElementById('order-history-tab') as HTMLDivElement;
var recharge = document.getElementById('recharge-tab') as HTMLDivElement;
var showBalance = document.getElementById('show-balance-tab') as HTMLDivElement;
var logout = document.getElementById('logout-tab') as HTMLDivElement;

var addbutton = document.getElementById('add') as HTMLDivElement;
// var editbutton = document.getElementById('edit') as HTMLDivElement;

let rechargeAmount = document.getElementById('recharge-amount') as HTMLInputElement;
let rechargeButton = document.getElementById('rechargebutton') as HTMLInputElement;

signininput.style.display = "none";

menubars.style.display = "none";

home.style.display = "none";
productDetails.style.display = "none"
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
    productDetails.style.display = "none"
    purchase.style.display = "none";
    cartItem.style.display = "none";
    orderHistory.style.display = "none";
    recharge.style.display = "none";
    showBalance.style.display = "none";
    logout.style.display = "none"
}

//signup
function SignUp() {
    signupinput.style.display = "block"
    signininput.style.display = "none"
}

//Signin
function SignIn() {
    signupinput.style.display = "none"
    signininput.style.display = "block"
}

//SignInSubmit
async function SignInSubmit() {
    const UserList = await fetchUser();
    let email = document.getElementById('email1') as HTMLInputElement;
    let password = document.getElementById('pwd1') as HTMLInputElement;
    let isFlag: boolean = true

    for (var i = 0; i < UserList.length; i++) {
        if (UserList[i].userEmail == email.value && UserList[i].userPassword == password.value) {
            CurrentUser = UserList[i];
            isFlag = false;
            email.value = "";
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

async function MenuBar() {
    menubars.style.display = "block"
    homepage.style.display = "none"
}

//Home
async function Home() {
    displayNone();
    home.style.display = "block";
    // (document.getElementById('welcome') as HTMLHeadElement).innerHTML = "Welcome " + CurrentUser.userName
    const UserList = await fetchUser();
    let Table = document.getElementById('home-table') as HTMLTableElement
    Table.innerHTML = "";
    let headRow = document.createElement('tr');
    headRow.innerHTML =
        `
    <th>Welcome ${CurrentUser.userName}</th>`
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
    updateAmount(CurrentUser.userID, Number(rechargeAmount.value))
    rechargeAmount.value = "";
}

//show balance
function ShowBalance() {
    displayNone();
    showBalance.style.display = "block";
    let balanceShow = document.getElementById('balance') as HTMLDivElement;
    balanceShow.innerHTML = "Your Balance is " + CurrentUser.userBalance;
}

let nameInput = document.getElementById('name') as HTMLInputElement
let imageInput = document.getElementById('images') as HTMLInputElement
let addressInput = document.getElementById('address') as HTMLInputElement
let phoneInput = document.getElementById('phone') as HTMLInputElement
let emailInput = document.getElementById('email') as HTMLInputElement
let pwdInput = document.getElementById('pwd') as HTMLInputElement
let balanceInput = document.getElementById('balance') as HTMLInputElement
let form = document.getElementById('sign-up') as HTMLFormElement
let base64String: any = "";
//SignUpSubmit
let editingID: number | null = null;
form.addEventListener("submit", (event) => {
    event.preventDefault();
    const name = nameInput.value.trim();
    const email = emailInput.value.trim();
    const password = pwdInput.value.trim();
    const phone = phoneInput.value.trim();
    var images = imageInput
    const address = addressInput.value.trim();

    const file = images.files?.[0];
    const reader = new FileReader();
    if (file) {
        reader.onload = function (event) {
            base64String = event.target?.result as string;
            console.log(base64String);
            if (editingID !== null) {
                const user: UserDetails = {
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
                const user: UserDetails = {
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
                alert("User Registered Successfully")
            }
            form.reset();
        }
        reader.readAsDataURL(file);
    }

});


async function ProductDetails() {
    displayNone();
    const ProductDetails = await fetchProduct();
    productDetails.style.display = "block";
    let Table = document.getElementById('product-table') as HTMLTableElement
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
    <th>DELETE</th>`
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

}
//addbuttton
function AddButton() {
    addbutton.style.display = "block";
    // editbutton.style.display = "none";
}

let editingID1: number | null = null;
async function EditButton(count: number) {
    // editbutton.style.display = "block"
    addbutton.style.display = "block"

    editingID1 = count;
    const ProductList = await fetchProduct();
    for (var i = 0; i < ProductList.length; i++) {
        if (ProductList[i].productID == editingID1) {
            (document.getElementById('product-name') as HTMLInputElement).value = ProductList[i].productName.toString();
            (document.getElementById('product-quantity') as HTMLInputElement).value = ProductList[i].productQuantity.toString();
            (document.getElementById('product-price') as HTMLInputElement).value = ProductList[i].productPrice.toString();
            (document.getElementById('product-purchase-date') as HTMLInputElement).value = ProductList[i].productPurchaseDate.toString().split('T')[0];
            (document.getElementById('product-expiry-date') as HTMLInputElement).value = ProductList[i].productExpiryDate.toString().split('T')[0];

        }
    }
}

//delete
function DeleteButton(count: number) {
    deleteProduct(count);
}

async function Purchase() {
    displayNone();
    const ProductDetails = await fetchProduct();
    purchase.style.display = "block";
    let div = document.getElementById('purchase-tab') as HTMLDivElement
    div.innerHTML = ""

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
}

//add edit sumbit
let nameInputs = document.getElementById('product-name') as HTMLInputElement
let quantityInputs = document.getElementById('product-quantity') as HTMLInputElement
let priceInputs = document.getElementById('product-price') as HTMLInputElement
let purchaseDateInputs = document.getElementById('product-purchase-date') as HTMLInputElement
let expiryDateInputs = document.getElementById('product-expiry-date') as HTMLInputElement
let imageInputs = document.getElementById('productimage') as HTMLInputElement
let forms = document.getElementById('product-form') as HTMLFormElement
let base64Strings: any = "";

forms.addEventListener("submit", (event) => {
    event.preventDefault();
    const name = nameInputs.value.trim();
    const quantity = quantityInputs.value.trim();
    const price = priceInputs.value.trim();
    const purchaseDate = new Date(purchaseDateInputs.value).toISOString();
    const expiryDate = new Date(expiryDateInputs.value).toISOString();
    const images = imageInputs

    const file = images.files?.[0];
    const reader = new FileReader();
    if (file) {
        reader.onload = function (event) {
            base64Strings = event.target?.result as string;
            console.log(base64Strings);
            if (editingID1 !== null) {
                const product: ProductDetails = {
                    productID: editingID1,
                    productName: name,
                    productQuantity: +quantity,
                    productPrice: +price,
                    productPurchaseDate: purchaseDate,
                    productExpiryDate: expiryDate,
                    productImage: [base64Strings]

                };
                updateProduct(editingID1, product);
                alert("Product Edited Successfully")
                ProductDetails();
            }
            else {
                const product: ProductDetails = {
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
                alert("Product Added Successfully")
            }
            forms.reset();
        }
        reader.readAsDataURL(file);
    }

});

var tempCart: Array<{ id: number, pid: number, productName: string, purchaseCount: number, priceOfOrder: number }> = new Array<{ id: number, pid: number, productName: string, purchaseCount: number, priceOfOrder: number }>();

function AddToCart(a: number, b: string, c: number, d: number) {
    var count: number = Number(prompt("Enter Quantity"));
    if (count <= c) {
        tempCart.push({ id: tempCart.length, pid: a, productName: b, purchaseCount: count, priceOfOrder: count * d });
    } else {
        alert(`Entered Qunatity Not Available \n Available Count:${c}`)
    }
}

function ShowCart() {
    displayNone();
    cartItem.style.display = "block";
    var tbody = document.getElementById("cart-table-body") as HTMLTableSectionElement;
    tbody.innerHTML = "";;
    tempCart.forEach((element) => {

        var row = document.createElement("tr");
        row.innerHTML = `

      <td>${element.productName}</td>
      <td>${element.purchaseCount}</td>
      <td>${element.priceOfOrder}</td>
      <td>
      <button onclick="deleteID(${element.id})">Delete</button>
      </td>
      `
        tbody.appendChild(row);
    }

    );
}

async function buy() {
    var total = 0;
    tempCart.forEach((val) => {
        total += val.priceOfOrder;
    })

    if (total < CurrentUser.userBalance) {
        var book: BookingDetails = await addBooking({
            bookingID: undefined,
            customerID: CurrentUser.userID,
            totalPrice: total,
            dateOfBooking: new Date().toISOString(),
            bookingStatus: "Booked"
        })
        tempCart.forEach((data) => {
            addOrder(
                {
                    orderID: undefined,
                    bookingID: book.bookingID,
                    productName: data.productName,
                    purchaseCount: data.purchaseCount,
                    productTotalPrice: data.priceOfOrder
                })
            updateProductCount(data.pid, data.purchaseCount);
            CurrentUser.userBalance =  CurrentUser.userBalance - total;
            updateAmount(CurrentUser.userID, CurrentUser.userBalance);
        })

        tempCart.splice(0, tempCart.length);
        ShowCart();
    } else {
        alert("Insufficient Balance");
    }
}

async function OrderHistory() {
    displayNone();
    orderHistory.style.display = "block";
    orderHistory.innerHTML = "";
    const bookingList: BookingDetails[] = await fetchBooking();
    const orderList = await fetchOrder();
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
            var d = document.getElementById(`nr${bookID.bookingID}`) as HTMLTableSectionElement;


            var c: number = 0
            orderList.forEach((element) => {
                if (element.bookingID == bookID.bookingID) {

                    var row = document.createElement("tr");
                    if (c == 0) {
                        row.innerHTML = ` 
        <td rowspan="5">${element.bookingID}</td>
        <td>${element.productName}</td>
        <td>${element.purchaseCount}</td>
        <td>${element.productTotalPrice}</td>
        `
                    } else {
                        row.innerHTML = ` 
        <td>${element.productName}</td>
        <td>${element.purchaseCount}</td>
        <td>${element.productTotalPrice}</td>
        `
                    }
                    c = 3;
                    d.appendChild(row);
                }
            }
            );
        }
    })
}
async function exportData(data: number) {
    var bookingList: BookingDetails[] = await fetchBooking();
    var bookList = await fetchOrder();
    var csvdata = "BookingID,ProduuctName,Purchasecount,Price\n";
    bookList.forEach((element) => {
        if (element.bookingID == data) {
            csvdata += `${element.bookingID},${element.productName},${element.purchaseCount},${element.productTotalPrice}\n`;
        }
    }
    )

    var a = new Blob([csvdata], { type: 'text/csv' });
    var b = document.createElement('a');
    var url = URL.createObjectURL(a);
    b.href = url;
    b.download = "Bill"
    b.click();
}