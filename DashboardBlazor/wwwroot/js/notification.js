window.ShowToastr = function (type, message) {
    //var options = {
    //    "closeButton": true,
    //    "debug": false,
    //    "newestOnTop": false,
    //    "progressBar": true,
    //    "positionClass": "toast-bottom-center",
    //    "preventDuplicates": false,
    //    "showDuration": "300",
    //    "hideDuration": "1000",
    //    "timeOut": "5000",
    //    "extendedTimeOut": "1000",
    //    "showEasing": "swing",
    //    "hideEasing": "linear",
    //    "showMethod": "fadeIn",
    //    "hideMethod": "fadeOut"
    //}

    //toastr.options.rtl = true;
    toastr.options.positionClass = "toast-top-left";

    if (type == "success") {
        toastr.success(message);
    }
    if (type == "warning") {
        toastr.warning(message);
    }
    if (type == "error") {
        toastr.error(message);
    }
    if (type == "info") {
        toastr.info(message);
    }
}