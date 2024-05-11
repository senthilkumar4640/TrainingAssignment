interface UserDetails {
    userID: any;
    userName: string;
    gender: string;
    department: string;
    mobileNumber: string;
    mailID: string;
    password: string
    walletBalance: number;
}

interface BookDetails {
    bookID: any;
    bookName: string;
    authorName: string;
    bookCount: number;
    images: string[];

}

interface BorrowDetails {
    borrowID: any;
    bookID: number;
    userID: number;
    borrowedDate: Date;
    borrowBookCount: number;
    status: string;
    paidFineAmount: number;
}

//let CartItem : Array<UserDetails> = new Array<UserDetails>;

let CurrentUser: UserDetails;

//fetch UserDetails
async function fetchUser(): Promise<UserDetails[]> {
    const apiUrl = 'http://localhost:5172/api/UserDetails';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('Failed to fetch userdetails');
    }
    return await response.json();
}

//fetch BookDetails
async function fetchBook(): Promise<BookDetails[]> {
    const apiUrl = 'http://localhost:5172/api/BookDetails';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('Failed to fetch traveldetails');
    }
    return await response.json();
}

//fetch BorrowDetails
async function fetchBorrow(): Promise<BorrowDetails[]> {
    const apiUrl = 'http://localhost:5172/api/BorrowDetails';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('Failed to fetch ticketfairdetails');
    }
    return await response.json();
}

//add user
async function addUser(user: UserDetails): Promise<void> {
    const response = await fetch('http://localhost:5172/api/UserDetails', {
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
    const response = await fetch(`http://localhost:5172/api/UserDetails/${id}/${amt}`, {
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
    const response = await fetch(`http://localhost:5172/api/UserDetails/${id}`, {
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

//add book
async function addBook(book: BookDetails): Promise<void> {
    const response = await fetch('http://localhost:5172/api/BookDetails', {
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
}

//edit book
async function updateBook(id: number, book: BookDetails): Promise<void> {
    const response = await fetch(`http://localhost:5172/api/BookDetails/${id}`, {
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
}

//delete book
async function deleteBook(id: number): Promise<void> {
    const response = await fetch(`http://localhost:5172/api/BookDetails/${id}`, {
        method: 'DELETE'
    });
    if (!response.ok) {
        throw new Error('Failed to delete book');
    }
    BookDetails();
}

//add borrow
async function addBorrow(borrow: BorrowDetails): Promise<void> {
    const response = await fetch('http://localhost:5172/api/BorrowDetails', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(borrow)

    });
    if (!response.ok) {
        throw new Error('Failed to add borrow');
    }
}

//edit borrow
async function updateBorrow(id: number, borrow: BorrowDetails): Promise<void> {
    const response = await fetch(`http://localhost:5172/api/BorrowDetails/${id}`, {
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
}

//delete book
async function deleteBorrow(id: number): Promise<void> {
    const response = await fetch(`http://localhost:5172/api/BorrowDetails/${id}`, {
        method: 'DELETE'
    });
    if (!response.ok) {
        throw new Error('Failed to delete borrow');
    }
    //
}


var homepage = document.getElementById('homepage') as HTMLDivElement;
var signup = document.getElementById('signup') as HTMLDivElement;
var signupinput = document.getElementById('sign-up') as HTMLDivElement;
var signin = document.getElementById('signin') as HTMLDivElement;
var signininput = document.getElementById('sign-in') as HTMLDivElement;


var menubars = document.getElementById('menubars') as HTMLDivElement;


var home = document.getElementById('home-tab') as HTMLDivElement;
var bookDetails = document.getElementById('book-details-tab') as HTMLDivElement;
var borrowBook = document.getElementById('borrow-book-tab') as HTMLDivElement;
var borrowHistory = document.getElementById('borrow-history-tab') as HTMLDivElement;
var returnBooks = document.getElementById('return-books-tab') as HTMLDivElement;
var walletRecharge = document.getElementById('wallet-recharge-tab') as HTMLDivElement;
var showBalance = document.getElementById('show-balance-tab') as HTMLDivElement;
var logout = document.getElementById('logout-tab') as HTMLDivElement;


var addbutton = document.getElementById('add') as HTMLDivElement;
var editbutton = document.getElementById('edit') as HTMLDivElement;


let walletRechargeAmount = document.getElementById('wallet-recharge-amount') as HTMLInputElement;
let rechargeButton = document.getElementById('rechargebutton') as HTMLInputElement;


signininput.style.display = "none";

menubars.style.display = "none";

home.style.display = "none";
bookDetails.style.display = "none"
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
    bookDetails.style.display = "none"
    borrowBook.style.display = "none";
    borrowHistory.style.display = "none";
    returnBooks.style.display = "none";
    walletRecharge.style.display = "none";
    showBalance.style.display = "none";
    logout.style.display = "none";
}

//signup
async function SignUp() {
    signupinput.style.display = "block"
    signininput.style.display = "none"
}

//Signin
async function SignIn() {
    signupinput.style.display = "none"
    signininput.style.display = "block"
}

let nameInput = document.getElementById('name') as HTMLInputElement
let genderInput = document.getElementById('gender') as HTMLInputElement
let departmentInput = document.getElementById('department') as HTMLInputElement
let mobileInput = document.getElementById('mobile') as HTMLInputElement
let emailInput = document.getElementById('email') as HTMLInputElement
let pwdInput = document.getElementById('pwd') as HTMLInputElement
let cnfPwdInput = document.getElementById('cnfpwd') as HTMLInputElement





// async function Photo() {
//     const file = images.files?.[0];
//     if (file) {
//         const reader = new FileReader();
//         reader.readAsDataURL(file);
//         const base64String = reader.result as string;
//         // Now you can use the base64String here
//     }
// }

let editingID: number | null = null;
//signupsubmit
async function SignUpSubmit() {
    const name = nameInput.value.trim();
    const gender = genderInput.value.trim();
    const department = departmentInput.value.trim();
    const mobile = mobileInput.value.trim();
    const email = emailInput.value.trim();
    const password = pwdInput.value.trim();


    if (editingID !== null) {
        const user: UserDetails = {
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
        const user: UserDetails = {
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

}

//SignInSubmit
async function SignInSubmit() {
    const UserList = await fetchUser();
    let email = document.getElementById('email1') as HTMLInputElement;
    let password = document.getElementById('pwd1') as HTMLInputElement;
    let isFlag: boolean = true

    for (var i = 0; i < UserList.length; i++) {
        if (UserList[i].mailID == email.value && UserList[i].password == password.value) {
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
function Home() {
    displayNone();
    home.style.display = "block";
    (document.getElementById('welcome') as HTMLHeadElement).innerHTML = "Welcome " + CurrentUser.userName
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
    updateAmount(CurrentUser.userID, Number(walletRechargeAmount.value))
    walletRechargeAmount.value = "";
}

//show balance
function ShowBalance() {
    displayNone();
    showBalance.style.display = "block";
    let balanceShow = document.getElementById('balance') as HTMLDivElement;
    balanceShow.innerHTML = "Your Balance is " + CurrentUser.walletBalance;
}

//book details
async function BookDetails() {
    displayNone();
    const BookDetailsList = await fetchBook();
    bookDetails.style.display = "block";
    let Table = document.getElementById('book-table') as HTMLTableElement
    Table.innerHTML = "";
    let headRow = document.createElement('tr');
    headRow.innerHTML =
        `
    <th>BOOK NAME</th>
    <th>AUTHOR NAME</th>
    <th>BOOK COUNT</th>
    <th>IMAGES</th>
    <th>EDIT</th>
    <th>DELETE</th>`
    Table.appendChild(headRow);

    for (var i = 0; i < BookDetailsList.length; i++) {
        let bodyRow = document.createElement('tr');
        bodyRow.innerHTML =
            `
            <td>${BookDetailsList[i].bookName}</td>
            <td>${BookDetailsList[i].authorName}</td>
            <td>${BookDetailsList[i].bookCount}</td>
            <td ><img id="img" src="${BookDetailsList[i].images[0]}"></td>
            <td><button onclick="EditButton(${BookDetailsList[i].bookID})">EDIT</button></td>
            <td><button onclick="DeleteButton(${BookDetailsList[i].bookID})">DELETE</button></td>
            `;
        Table.appendChild(bodyRow);
    }
}

//addbuttton
function AddButton() {
    addbutton.style.display = "block";
    editbutton.style.display = "none";
}

//submit in add books
// async function AddSubmit() {
    let bookName = document.getElementById('book-name') as HTMLInputElement;
    let authorName = document.getElementById('author-name') as HTMLInputElement;
    let bookCount = document.getElementById('book-count') as HTMLInputElement;
    let form = document.getElementById('form') as HTMLFormElement
    let images = document.getElementById('images') as HTMLInputElement
    let base64String: any = "";

    form.addEventListener("submit", (event) => {
        event.preventDefault();
        const file = images.files?.[0];
        const reader = new FileReader();
        if (file) {
            
            reader.onload = function (event) {
               
                base64String = event.target?.result as string;

                console.log(base64String);
                const book: BookDetails = {
                    bookID: undefined,
                    bookName: bookName.value,
                    authorName: authorName.value,
                    bookCount: Number(bookCount.value),
                    images: [base64String]
                }
                addBook(book);
                bookName.value = "";
                authorName.value = "";
                bookCount.value = "";
                BookDetails();
            }
            reader.readAsDataURL(file);
        }
   
});
// }

let bookIndex: number = 0;
//edit button in table
async function EditButton(count: number) {
    const BookDetailsList = await fetchBook();
    editbutton.style.display = "block"
    addbutton.style.display = "none"
    bookIndex = count;
    for (var i = 0; i < BookDetailsList.length; i++) {
        if (i == bookIndex) {
            (document.getElementById('book-name-edit') as HTMLInputElement).value = BookDetailsList[i].bookName.toString();
            (document.getElementById('author-name-edit') as HTMLInputElement).value = BookDetailsList[i].authorName.toString();
            (document.getElementById('book-count-edit') as HTMLInputElement).value = BookDetailsList[i].bookCount.toString();
        }
    }
}

//submit in edit details
async function EditSubmit() {
    const BookDetailsList = await fetchBook();
    for (var i = 0; i < BookDetailsList.length; i++) {
        if (i == bookIndex) {
            BookDetailsList[i].bookName = (document.getElementById('book-name-edit') as HTMLInputElement).value;
            BookDetailsList[i].authorName = (document.getElementById('author-name-edit') as HTMLInputElement).value;
            BookDetailsList[i].bookCount = Number((document.getElementById('book-count-edit') as HTMLInputElement).value);

            updateBook(BookDetailsList[i].bookID, BookDetailsList[i]);
            (document.getElementById('ticket-from-edit') as HTMLInputElement).value = "";
            (document.getElementById('ticket-to-edit') as HTMLInputElement).value = "";
            (document.getElementById('ticket-fair-edit') as HTMLInputElement).value = "";
            BookDetails();
        }
    }

}

//delete
function DeleteButton(count: number) {
    deleteBook(count);
    BookDetails();
}

//Borrobook
async function BorrowBook() {
    const BookDetailsList = await fetchBook();
    displayNone();
    borrowBook.style.display = "block";
    let Table = document.getElementById('borrow-table') as HTMLTableElement
    Table.innerHTML = "";
    let headRow = document.createElement('tr');
    headRow.innerHTML =
        `
    <th>BOOK NAME</th>
    <th>AUTHOR NAME</th>
    <th>BOOK COUNT</th>
    <th>BUY</th>`
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
}

let result: number = 0;
let options: any;
async function buy(id: number) {
    const BookDetailsList = await fetchBook();
    const BorrowDetailsList = await fetchBorrow();
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
                        let borrow: BorrowDetails = {
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
        alert("Your Maximum Limit is 3")
    }

}

//borrow history
async function BorrowHistory() {
    displayNone();
    borrowHistory.style.display = "block";
    let BorrowDetailsList = await fetchBorrow();
    let table = document.getElementById("borrow-history-table") as HTMLTableElement
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
}

//Export
async function Export() {
    const BorrowDetailsList = await fetchBorrow();
    let a = document.createElement('a');
    let data = "BorrowID,BookID,UserIDBorrowedDate,BorrowedBookCount,Status,PaidFineAmount"
    for (var i = 0; i < BorrowDetailsList.length; i++) {
        data = data + "\n" + `${BorrowDetailsList[i].borrowID},${BorrowDetailsList[i].bookID},${BorrowDetailsList[i].userID},${BorrowDetailsList[i].borrowedDate},${BorrowDetailsList[i].borrowBookCount},${BorrowDetailsList[i].status},${BorrowDetailsList[i].paidFineAmount}\n`
    }
    const blob = new Blob([data], { type: 'text/csv' });
    const url = URL.createObjectURL(blob);
    a.href = url;
    a.download = 'BorrowHistory.csv';
    a.click();
}

//return books
async function ReturnBooks() {
    displayNone();
    returnBooks.style.display = "block";
    let BorrowDetailsList = await fetchBorrow();
    let table = document.getElementById("return-books-table") as HTMLTableElement
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

}


let returnBookDate: string;
async function Returns(id: number) {
    let currentDate = new Date();
    const BorrowDetailsList = await fetchBorrow();
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

                const BookDetailsList = await fetchBook();
                BookDetailsList[i].bookCount += Number(options);
                updateBook(BookDetailsList[i].bookID, BookDetailsList[i]);


            }
            else if (days > 15) {
                let day = days - 15;
                fineAmount = day;
                const UserDetailsList = await fetchUser();
                UserDetailsList[i].walletBalance - fineAmount;
                updateAmount(CurrentUser.userID, UserDetailsList[i].walletBalance);

                const BookDetailsList = await fetchBook();
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