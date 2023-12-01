//// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
//// for details on configuring this project to bundle and minify static web assets.

//// Write your JavaScript code.

function sayHello() {
    var currentTimeElement = document.getElementById("currentTime");
    setInterval(function () {
        fetch('/Tasks/ShopTime')
            .then(response => response.json())
            .then(newTime => {
                currentTimeElement.innerText = newTime;
            })
            .catch(error => console.error('Error fetching time:', error));
    });
}

// Викликати функцію при завантаженні сторінки
window.onload = function () {
    sayHello();
};
