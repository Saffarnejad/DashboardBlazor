window.ShowSwal = function (title, text, icon) {
    return new Promise(resolve => {
        Swal.fire({
            title,
            text,
            icon,
            iconHtml: "؟",
            confirmButtonColor: "#d33",
            cancelButtonColor: "#6e7881",
            confirmButtonText: "بله",
            cancelButtonText: "خیر",
            showCancelButton: true
        }).then((result) => {
            resolve(result.isConfirmed);
        });
    });
}

window.ShowToast = function (title, icon) {
    const Toast = Swal.mixin({
        toast: true,
        position: "top-start",
        iconColor: 'white',
        customClass: {
            popup: 'colored-toast',
        },
        showConfirmButton: false,
        timer: 3000,
        timerProgressBar: false,
        didOpen: (toast) => {
            toast.onmouseenter = Swal.stopTimer;
            toast.onmouseleave = Swal.resumeTimer;
        }
    });
    Toast.fire({
        icon,
        title
    });
}