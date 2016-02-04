function clearUsername()
{
    var userBox = document.getElementById("TextBoxUsername");

    if (userBox.value == "Username")
    {
        userBox.style.color = "black";
        userBox.value = "";
    }
}

function fillUsername()
{
    var userBox = document.getElementById("TextBoxUsername");

    if (userBox.value == "")
    {
        userBox.style.color = "silver";
        userBox.value = "Username";
    }
}

function clearPassword()
{
    var passBox = document.getElementById("TextBoxPassword");

    if (passBox.value == "Password")
    {
        passBox.style.color = "black";
        passBox.value = "";
        passBox.type = "password";
    }
}

function fillPassword()
{
    var passBox = document.getElementById("TextBoxPassword");

    if (passBox.value == "")
    {
        passBox.style.color = "silver";
        passBox.value = "Password";
        passBox.type = "";
    }
}