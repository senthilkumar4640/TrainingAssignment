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
//let CartItem : Array<UserDetails> = new Array<UserDetails>;
let CurrentUser;
//fetch UserDetails
function fetchUser() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5172/api/UserDetails';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch userdetails');
        }
        return yield response.json();
    });
}
//fetch BookDetails
function fetchBook() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5172/api/BookDetails';
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch traveldetails');
        }
        return yield response.json();
    });
}
//fetch BorrowDetails
function fetchBorrow() {
    return __awaiter(this, void 0, void 0, function* () {
        const apiUrl = 'http://localhost:5172/api/BorrowDetails';
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
        const response = yield fetch('http://localhost:5172/api/UserDetails', {
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
        const response = yield fetch(`http://localhost:5172/api/UserDetails/${id}/${amt}`, {
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
        const response = yield fetch(`http://localhost:5172/api/UserDetails/${id}`, {
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
//add book
function addBook(book) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5172/api/BookDetails', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(book)
        });
        if (!response.ok) {
            throw new Error('Failed to add book');
        }
        BookDetails();
    });
}
//edit book
function updateBook(id, book) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5172/api/BookDetails/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(book)
        });
        if (!response.ok) {
            throw new Error('Failed to update book');
        }
        BookDetails();
    });
}
//delete book
function deleteBook(id) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5172/api/BookDetails/${id}`, {
            method: 'DELETE'
        });
        if (!response.ok) {
            throw new Error('Failed to delete book');
        }
        BookDetails();
    });
}
//add borrow
function addBorrow(borrow) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('http://localhost:5172/api/BorrowDetails', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(borrow)
        });
        if (!response.ok) {
            throw new Error('Failed to add borrow');
        }
    });
}
//edit borrow
function updateBorrow(id, borrow) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5172/api/BorrowDetails/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(borrow)
        });
        if (!response.ok) {
            throw new Error('Failed to update tickborrowet');
        }
        //
    });
}
//delete book
function deleteBorrow(id) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5172/api/BorrowDetails/${id}`, {
            method: 'DELETE'
        });
        if (!response.ok) {
            throw new Error('Failed to delete borrow');
        }
        //
    });
}
var homepage = document.getElementById('homepage');
var signup = document.getElementById('signup');
var signupinput = document.getElementById('sign-up');
var signin = document.getElementById('signin');
var signininput = document.getElementById('sign-in');
var menubars = document.getElementById('menubars');
var home = document.getElementById('home-tab');
var bookDetails = document.getElementById('book-details-tab');
var borrowBook = document.getElementById('borrow-book-tab');
var borrowHistory = document.getElementById('borrow-history-tab');
var returnBooks = document.getElementById('return-books-tab');
var walletRecharge = document.getElementById('wallet-recharge-tab');
var showBalance = document.getElementById('show-balance-tab');
var logout = document.getElementById('logout-tab');
var addbutton = document.getElementById('add');
var editbutton = document.getElementById('edit');
let walletRechargeAmount = document.getElementById('wallet-recharge-amount');
let rechargeButton = document.getElementById('rechargebutton');
signininput.style.display = "none";
menubars.style.display = "none";
home.style.display = "none";
bookDetails.style.display = "none";
borrowBook.style.display = "none";
borrowHistory.style.display = "none";
returnBooks.style.display = "none";
walletRecharge.style.display = "none";
showBalance.style.display = "none";
logout.style.display = "none";
addbutton.style.display = "none";
editbutton.style.display = "none";
walletRechargeAmount.style.display = "none";
rechargeButton.style.display = "none";
function displayNone() {
    home.style.display = "none";
    bookDetails.style.display = "none";
    borrowBook.style.display = "none";
    borrowHistory.style.display = "none";
    returnBooks.style.display = "none";
    walletRecharge.style.display = "none";
    showBalance.style.display = "none";
    logout.style.display = "none";
}
//signup
function SignUp() {
    return __awaiter(this, void 0, void 0, function* () {
        signupinput.style.display = "block";
        signininput.style.display = "none";
    });
}
//Signin
function SignIn() {
    return __awaiter(this, void 0, void 0, function* () {
        signupinput.style.display = "none";
        signininput.style.display = "block";
    });
}
let nameInput = document.getElementById('name');
let genderInput = document.getElementById('gender');
let departmentInput = document.getElementById('department');
let mobileInput = document.getElementById('mobile');
let emailInput = document.getElementById('email');
let pwdInput = document.getElementById('pwd');
let cnfPwdInput = document.getElementById('cnfpwd');
// async function Photo() {
//     const file = images.files?.[0];
//     if (file) {
//         const reader = new FileReader();
//         reader.readAsDataURL(file);
//         const base64String = reader.result as string;
//         // Now you can use the base64String here
//     }
// }
let editingID = null;
//signupsubmit
function SignUpSubmit() {
    return __awaiter(this, void 0, void 0, function* () {
        const name = nameInput.value.trim();
        const gender = genderInput.value.trim();
        const department = departmentInput.value.trim();
        const mobile = mobileInput.value.trim();
        const email = emailInput.value.trim();
        const password = pwdInput.value.trim();
        if (editingID !== null) {
            const user = {
                userID: editingID,
                userName: name,
                gender: gender,
                department: department,
                mobileNumber: mobile,
                mailID: email,
                password: password,
                walletBalance: 0
            };
            updateUser(editingID, user);
        }
        else {
            const user = {
                userID: undefined,
                userName: name,
                gender: gender,
                department: department,
                mobileNumber: mobile,
                mailID: email,
                password: password,
                walletBalance: 0
            };
            addUser(user);
            alert("User Registered Successfully");
        }
        nameInput.value = "";
        genderInput.value = "";
        departmentInput.value = "";
        mobileInput.value = "";
        emailInput.value = "";
        pwdInput.value = "";
        cnfPwdInput.value = "";
        SignIn();
    });
}
//SignInSubmit
function SignInSubmit() {
    return __awaiter(this, void 0, void 0, function* () {
        const UserList = yield fetchUser();
        let email = document.getElementById('email1');
        let password = document.getElementById('pwd1');
        let isFlag = true;
        for (var i = 0; i < UserList.length; i++) {
            if (UserList[i].mailID == email.value && UserList[i].password == password.value) {
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
    displayNone();
    home.style.display = "block";
    document.getElementById('welcome').innerHTML = "Welcome " + CurrentUser.userName;
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
function WalletRecharge() {
    displayNone();
    walletRecharge.style.display = "block";
    walletRechargeAmount.style.display = "block";
    rechargeButton.style.display = "block";
}
function Deposit() {
    CurrentUser.walletBalance = Number(walletRechargeAmount.value) + CurrentUser.walletBalance;
    alert("Recharged Sucessfully");
    updateAmount(CurrentUser.userID, Number(walletRechargeAmount.value));
    walletRechargeAmount.value = "";
}
//show balance
function ShowBalance() {
    displayNone();
    showBalance.style.display = "block";
    let balanceShow = document.getElementById('balance');
    balanceShow.innerHTML = "Your Balance is " + CurrentUser.walletBalance;
}
//book details
function BookDetails() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        const BookDetailsList = yield fetchBook();
        bookDetails.style.display = "block";
        let Table = document.getElementById('book-table');
        Table.innerHTML = "";
        let headRow = document.createElement('tr');
        headRow.innerHTML =
            `
    <th>BOOK NAME</th>
    <th>AUTHOR NAME</th>
    <th>BOOK COUNT</th>
    <th>IMAGES</th>
    <th>EDIT</th>
    <th>DELETE</th>`;
        Table.appendChild(headRow);
        for (var i = 0; i < BookDetailsList.length; i++) {
            let bodyRow = document.createElement('tr');
            bodyRow.innerHTML =
                `
            <td>${BookDetailsList[i].bookName}</td>
            <td>${BookDetailsList[i].authorName}</td>
            <td>${BookDetailsList[i].bookCount}</td>
            <td><img src="${BookDetailsList[i].images[0]}"></td>
            <td><button onclick="EditButton(${i})">EDIT</button></td>
            <td><button onclick="DeleteButton(${BookDetailsList[i].bookID})">DELETE</button></td>
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
//submit in add books
// async function AddSubmit() {
let bookName = document.getElementById('book-name');
let authorName = document.getElementById('author-name');
let bookCount = document.getElementById('book-count');
let form = document.getElementById('form');
let images = document.getElementById('images');
let base64String = "";
form.addEventListener("submit", (event) => {
    var _a;
    event.preventDefault();
    const file = (_a = images.files) === null || _a === void 0 ? void 0 : _a[0];
    const reader = new FileReader();
    if (file) {
        reader.onload = function (event) {
            var _a;
            // `event.target.result` contains the base64 encoded string
            base64String = (_a = event.target) === null || _a === void 0 ? void 0 : _a.result;
            // Now you can use the base64String as needed
            console.log(base64String);
            const book = {
                bookID: undefined,
                bookName: bookName.value,
                authorName: authorName.value,
                bookCount: Number(bookCount.value),
                images: [base64String]
            };
            addBook(book);
            bookName.value = "";
            authorName.value = "";
            bookCount.value = "";
            BookDetails();
        };
        reader.readAsDataURL(file);
    }
});
// }
let bookIndex = 0;
//edit button in table
function EditButton(count) {
    return __awaiter(this, void 0, void 0, function* () {
        const BookDetailsList = yield fetchBook();
        editbutton.style.display = "block";
        addbutton.style.display = "none";
        bookIndex = count;
        for (var i = 0; i < BookDetailsList.length; i++) {
            if (i == bookIndex) {
                document.getElementById('book-name-edit').value = BookDetailsList[i].bookName.toString();
                document.getElementById('author-name-edit').value = BookDetailsList[i].authorName.toString();
                document.getElementById('book-count-edit').value = BookDetailsList[i].bookCount.toString();
            }
        }
    });
}
//submit in edit details
function EditSubmit() {
    return __awaiter(this, void 0, void 0, function* () {
        const BookDetailsList = yield fetchBook();
        for (var i = 0; i < BookDetailsList.length; i++) {
            if (i == bookIndex) {
                BookDetailsList[i].bookName = document.getElementById('book-name-edit').value;
                BookDetailsList[i].authorName = document.getElementById('author-name-edit').value;
                BookDetailsList[i].bookCount = Number(document.getElementById('book-count-edit').value);
                updateBook(BookDetailsList[i].bookID, BookDetailsList[i]);
                document.getElementById('ticket-from-edit').value = "";
                document.getElementById('ticket-to-edit').value = "";
                document.getElementById('ticket-fair-edit').value = "";
                BookDetails();
            }
        }
    });
}
//delete
function DeleteButton(count) {
    deleteBook(count);
    BookDetails();
}
//Borrobook
function BorrowBook() {
    return __awaiter(this, void 0, void 0, function* () {
        const BookDetailsList = yield fetchBook();
        displayNone();
        borrowBook.style.display = "block";
        let Table = document.getElementById('borrow-table');
        Table.innerHTML = "";
        let headRow = document.createElement('tr');
        headRow.innerHTML =
            `
    <th>BOOK NAME</th>
    <th>AUTHOR NAME</th>
    <th>BOOK COUNT</th>
    <th>BUY</th>`;
        Table.appendChild(headRow);
        for (var i = 0; i < BookDetailsList.length; i++) {
            let bodyRow = document.createElement('tr');
            bodyRow.innerHTML =
                `
            <td>${BookDetailsList[i].bookName}</td>
            <td>${BookDetailsList[i].authorName}</td>
            <td>${BookDetailsList[i].bookCount}</td>
            <td><button onclick="buy(${BookDetailsList[i].bookID})">BUY</button></td>
            `;
            Table.appendChild(bodyRow);
        }
    });
}
let result = 0;
let options;
function buy(id) {
    return __awaiter(this, void 0, void 0, function* () {
        const BookDetailsList = yield fetchBook();
        const BorrowDetailsList = yield fetchBorrow();
        options = prompt("Enter the Book Count");
        if (Number(options) <= 3) {
            for (var i = 0; i < BookDetailsList.length; i++) {
                if (BookDetailsList[i].bookID == id) {
                    if (BookDetailsList[i].bookCount >= Number(options)) {
                        for (var j = 0; j < BorrowDetailsList.length; j++) {
                            if (BorrowDetailsList[j].userID == CurrentUser.userID && BorrowDetailsList[j].status == "Borrowed") {
                                result += BorrowDetailsList[j].borrowBookCount;
                            }
                        }
                        if (result > 3) {
                            alert(`You can have maximum of 3 borrowed books. Your already borrowed books count is ${result} and requested count is ${Number(options)}, which exceeds 3`);
                        }
                        else {
                            let borrow = {
                                borrowID: undefined,
                                bookID: BookDetailsList[i].bookID,
                                userID: CurrentUser.userID,
                                borrowedDate: new Date(),
                                borrowBookCount: Number(options),
                                status: "Borrowed",
                                paidFineAmount: 0
                            };
                            addBorrow(borrow);
                            BookDetailsList[i].bookCount = BookDetailsList[i].bookCount - Number(options);
                            updateBook(BookDetailsList[i].bookID, BookDetailsList[i]);
                            alert("Borrowed Successfully");
                        }
                    }
                    else {
                        alert("Books are not available for the selected count");
                    }
                }
            }
        }
        else {
            alert("Your Maximum Limit is 3");
        }
    });
}
//borrow history
function BorrowHistory() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        borrowHistory.style.display = "block";
        let BorrowDetailsList = yield fetchBorrow();
        let table = document.getElementById("borrow-history-table");
        table.innerHTML = "";
        let row1 = document.createElement("tr");
        row1.innerHTML = `
    <th>BORROWED DATE</th>
    <th>BORROWED BOOK COUNT</th>
    <th>STATUS</th>
    <th>PAID FINE AMOUNT</th>
    `;
        table.appendChild(row1);
        for (let i = 0; i < BorrowDetailsList.length; i++) {
            if (BorrowDetailsList[i].userID == CurrentUser.userID) {
                let row = document.createElement("tr");
                row.innerHTML = `
            <td>${BorrowDetailsList[i].borrowedDate.toString().split('T')[0].split('-').reverse().join('/')}</td>
            <td>${BorrowDetailsList[i].borrowBookCount}</td>
            <td>${BorrowDetailsList[i].status}</td>
            <td>${BorrowDetailsList[i].paidFineAmount}</td>
            `;
                table.appendChild(row);
            }
        }
    });
}
//Export
function Export() {
    return __awaiter(this, void 0, void 0, function* () {
        const BorrowDetailsList = yield fetchBorrow();
        let a = document.createElement('a');
        let data = "BorrowID,BookID,UserIDBorrowedDate,BorrowedBookCount,Status,PaidFineAmount";
        for (var i = 0; i < BorrowDetailsList.length; i++) {
            data = data + "\n" + `${BorrowDetailsList[i].borrowID},${BorrowDetailsList[i].bookID},${BorrowDetailsList[i].userID},${BorrowDetailsList[i].borrowedDate},${BorrowDetailsList[i].borrowBookCount},${BorrowDetailsList[i].status},${BorrowDetailsList[i].paidFineAmount}\n`;
        }
        const blob = new Blob([data], { type: 'text/csv' });
        const url = URL.createObjectURL(blob);
        a.href = url;
        a.download = 'BorrowHistory.csv';
        a.click();
    });
}
//return books
function ReturnBooks() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        returnBooks.style.display = "block";
        let BorrowDetailsList = yield fetchBorrow();
        let table = document.getElementById("return-books-table");
        table.innerHTML = "";
        let row1 = document.createElement("tr");
        row1.innerHTML = `
    <th>BORROWED DATE</th>
    <th>BORROWED BOOK COUNT</th>
    <th>STATUS</th>
    <th>PAID FINE AMOUNT</th>
    <th>RETURN</th>
    `;
        table.appendChild(row1);
        for (let i = 0; i < BorrowDetailsList.length; i++) {
            if (BorrowDetailsList[i].userID == CurrentUser.userID && BorrowDetailsList[i].status == "Borrowed") {
                let row = document.createElement("tr");
                row.innerHTML = `
            <td>${BorrowDetailsList[i].borrowedDate.toString().split('T')[0].split('-').reverse().join('/')}</td>
            <td>${BorrowDetailsList[i].borrowBookCount}</td>
            <td>${BorrowDetailsList[i].status}</td>
            <td>${BorrowDetailsList[i].paidFineAmount}</td>
            <td><button onclick="Returns(${BorrowDetailsList[i].bookID})">RETURN</button></td>
            `;
                table.appendChild(row);
            }
        }
    });
}
let returnBookDate;
function Returns(id) {
    return __awaiter(this, void 0, void 0, function* () {
        let currentDate = new Date();
        const BorrowDetailsList = yield fetchBorrow();
        for (var i = 0; i < BorrowDetailsList.length; i++) {
            if (BorrowDetailsList[i].borrowID == id) {
                returnBookDate = (BorrowDetailsList[i].borrowedDate).toString().substring(0, 10);
            }
        }
        let difference = new Date(returnBookDate.substring(0, 10)).getTime() - currentDate.getTime();
        let days = Math.ceil(difference / (1000 * 3600 * 24));
        days = Math.abs(days);
        let fineAmount;
        for (var i = 0; i < BorrowDetailsList.length; i++) {
            if (BorrowDetailsList[i].borrowID == id) {
                if (days < 15) {
                    BorrowDetailsList[i].status == "Returned";
                    updateBorrow(BorrowDetailsList[i].borrowID, BorrowDetailsList[i]);
                    const BookDetailsList = yield fetchBook();
                    BookDetailsList[i].bookCount += Number(options);
                    updateBook(BookDetailsList[i].bookID, BookDetailsList[i]);
                }
                else if (days > 15) {
                    let day = days - 15;
                    fineAmount = day;
                    const UserDetailsList = yield fetchUser();
                    UserDetailsList[i].walletBalance - fineAmount;
                    updateAmount(CurrentUser.userID, UserDetailsList[i].walletBalance);
                    const BookDetailsList = yield fetchBook();
                    BookDetailsList[i].bookCount += Number(options);
                    updateBook(BookDetailsList[i].bookCount, BookDetailsList[i]);
                    BorrowDetailsList[i].paidFineAmount = fineAmount;
                    updateBorrow(BorrowDetailsList[i].borrowID, BorrowDetailsList[i]);
                }
                else {
                    alert("Insufficient Balance");
                }
            }
        }
    });
}
// async function photo() {
//     const file = images.files?.[0];
//     let base64String: any = "";
//     if (file) {
//         const reader = new FileReader();
//         reader.onload = function (event) {
//             // `event.target.result` contains the base64 encoded string
//             base64String = event.target?.result;
//             // Now you can use the base64String as needed
//             updateBook(base64String);
//             reader.readAsDataURL(file);
//         }
//     }
// }
