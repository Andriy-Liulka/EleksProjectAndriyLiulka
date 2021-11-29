﻿
var token = localStorage.getItem('jwtToken');
axios.get("https://localhost:5001/api/User/GetUserData", {
    headers: { Authorization: `Bearer ${token}` }
})
    .then((responce) => {
        var getResponse = responce.status;
        if (getResponse == 200 && responce.data.role =="Admin") {
            console.log("Authorized successfully");
        }
        else {
            console.log(getResponse);
            SignOut();
        }

    }).catch((error) => {
        console.log(error);
        window.location = "../../../html/SignIn.html";
    });