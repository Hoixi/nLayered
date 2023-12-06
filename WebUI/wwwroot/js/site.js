

$(document).ready(function () {

    getList(); 
});
function getList() {
    $.ajax({
        type: 'GET',
        url: 'http://localhost:5115/api/Course/GetList',
        dataType: 'json',
        success: function (response) {
            if (response) {

                console.log(response);
                var main = document.getElementById("main");
                var temp = '';
                for (let i = 0; i < response.items.length; i++) {

                    temp += '<div class="col">' +
                        '<div class="card" style="width: 18rem;">' +
                        '<img src="' + response.items[i].img + '" class="card-img-top" alt="...">' +
                        '<div class="card-body">' +
                        '<h5 class="card-title">' + response.items[i].courseName + '</h5>' +
                        '<h6 class="card-subtitle mb-2 text-body-secondary">' + response.items[i].categoryName + '</h6>' +
                        '<p class="card-text">' + response.items[i].description + '</p>' +
                        '<a href="#" class="card-link">' + response.items[i].ownerName + ' ' + response.items[i].ownerSurname + '</a>' +
                        '</div >' +
                        '</div > '+
                    '</div > ';
                }

                main.innerHTML = temp;
            }

        },
    });
}
