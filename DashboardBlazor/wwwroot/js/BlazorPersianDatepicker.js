window.PersianDatepickerInit = function (startDate, endDate) {
    $(".bpdp").persianDatepicker({
        persianNumbers: true,
        formatDate: "YYYY/0M/0D",
        startDate,
        endDate,
        cellWidth: 40,
        cellHeight: 30,
        fontSize: 14
    });
}