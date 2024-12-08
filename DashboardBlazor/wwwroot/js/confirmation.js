window.ShowSwal = function (title, text, icon) {
    return new Promise(resolve => {
        Swal.fire({
            title,
            text,
            icon,
            showCancelButton: true,
            //confirmButtonColor: "#3085d6",
            //cancelButtonColor: "#d33",
            cancelButtonText: "خیر",
            confirmButtonText: "بله"
        }).then((result) => {
            resolve(result.isConfirmed);
        });
    });
}