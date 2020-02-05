function validate() {
    var username = document.getElementById('username').value;
    var password = document.getElementById('password').value;
    var passed = true;

    if (username == '') {
        document.getElementById('usernameerror').style.visibility = 'visible';
        passed = false;
    }

    if (password == '') {
        document.getElementById('passworderror').style.visibility = 'visible';
        passed = false;
    }
    return passed;    
}

function initializeLoginPage() {
    document.getElementById('usernameerror').style.visibility='hidden';
    document.getElementById('passworderror').style.visibility='hidden';

}