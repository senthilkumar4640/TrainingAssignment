let footerpage = document.getElementById('footer');
footerpage.innerHTML = "Copyrigth @" + new Date().getFullYear() + "- present Syncfusion";
let MainBar = document.getElementById('main-bar');
MainBar.style.display = "block"
let Details = document.getElementById('output-page');
Details.style.display = "none"


function TotalValidation() {
    category();
    AuthorEmail();
    Book();
    AuthorName();
    Published();

    let price = document.getElementById('price').value;

    function category() {
        document.getElementById('heading1').innerHTML = book + "Book Details";
        let category = document.getElementById('category').value;
        document.getElementById('category-out').innerHTML = category;

    }

    function Book() {
        let book = document.getElementById('book');
        var regex = /^([a-zA-Z]{5,50})$/;
        if (regex.test(book)) {
            document.getElementById('book-out').innerHTML = book.value;
            return true;
        }
        else {
           
            document.getElementById('validate-book').style.visibility = "visible";
            return false;
        }
    }


    function AuthorEmail() {
        let authoremail = document.getElementById('author-email').value;
        var regex = /^([a-zA-Z0-9\.-]+)@([a-zA-Z0-9-]+).([a-z]{2,20})$/;
        if (regex.test(authoremail)) {
            document.getElementById('email-out').innerHTML = book;
            return true;
        }
        else {
            document.getElementById('validate-mail').style.visibility = "visible";
            return false;
        }
    }

    function AuthorName() {
        let authorname = document.getElementById('author-name').value;
        var regex = /^([a-zA-Z]{5,50})$/;
        if (regex.test(authorname)) {
            document.getElementById('name-out').innerHTML = book;
            return true;
        }
        else {
            document.getElementById('validate-name').style.visibility = "visible";
            return false;
        }
    }

    function Published() {
        let published = document.getElementById('published').value;
        var regex = new Date.getFullYear();
        if (regex.test(authorname)) {
            return true;
        }
        else {
            document.getElementById('validate-published').style.visibility = "visible";
            return false;
        }
    }

}

function ShowHide() {
    let MainBar = document.getElementById('main-bar');
    let Details = document.getElementById('output-page');

    if (MainBar.style.display == "block") {
        MainBar.style.display = "none"
        Details.style.display = "block"
    }


}

function Back() {
    let MainBar = document.getElementById('main-bar');
    MainBar.style.display = "block"
    let Details = document.getElementById('output-page');
    Details.style.display = "none"
}
