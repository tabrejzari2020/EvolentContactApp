var EditContact = function (contactId) {
    var url = "/Contact/EditContact?Id=" + contactId;

    $('#createPopUpBody1').load(url, function () {
        $('#createPopUp1').modal();
    })
}