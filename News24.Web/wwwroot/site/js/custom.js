function OnDocumentInit() {
    jQuery('[data-toggle="tooltip"]').tooltip();

    jQuery('.main-slider').owlCarousel({
        rtl: true,
        loop: true,
        margin: 8,
        nav: true,
        autoplay: true,
        autoplayTimeout: 5000,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            1000: {
                items: 1
            }
        }
    });
}


window.ShowToastr = (type, message) => {
    if (type === 'success') {
        toastr.success(message, 'عملیات مورد نظر با موفقیت انجام شد');
    }

    if (type === 'error') {
        toastr.error(message, 'عملیات با شکست مواجه شد');
    }
}

window.ShowSwal = (type, message) => {
    if (type === 'success') {
        Swal.fire(
            'اعلان موفقیت !!!',
            message,
            'success'
        );
    }

    if (type === 'error') {
        Swal.fire(
            'اعلان خطا !!!',
            message,
            'error'
        );
    }
}

function showConfirmationModal() {
    $('#confirmationModal').modal('show');
}

function hideConfirmationModal() {
    $('#confirmationModal').modal('hide');
}

function DataTables() {

    $("#table").dataTable({
        retrieve: true,
        paging: false,
        searching: false,
        showing: false
    });
}