
function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}
$(document).ready(function () {
    moment.locale('id');
    $('#myTable').DataTable({
        ajax: {
            url: "https://localhost:44362/Api/employees",
            dataType: "json",
            dataSrc: "data"
        },
        dom: 'Bfrtip',
        buttons: [
            'colvis', 'copy',
            {
                extend: 'excelHtml5',
                title: 'Excel',
                text: 'Export to excel',
                className: "btn-primary",
                //Columns to export
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6, 7]
                }
            },
            {
                extend: 'pdfHtml5',
                title: 'PDF',
                text: 'Export to PDF',
                //Columns to export
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6, 7]
                }
            },
            {
                extend: 'print',
                exportOptions: {
                    columns: ':visible'
                }
            }
        ],
        autoWidth: false,
        columns: [
            {
                data: 'no',
                render: function (data, type, row, meta) {
                    return meta.row + 1;
                }
            },
            { data: "nik" },
            {
                data: 'fullName',
                render: function (data, type, row) {
                    return row.firstName + ' ' + row.lastName;
                }
            },
            {
                data: "birthDate",
                render: function (data, type, row) {
                    return moment(data).format("DD MMMM YYYY");
                }
            },
            {
                data: "gender",
                render: function (data, type, row) {
                    if (data === 0) {
                        return "Female";
                    } else if (data === 1) {
                        return "Male";
                    } else {
                        return "";
                    }
                }
            },
            {
                data: "hiringDate",
                render: function (data, type, row) {
                    return moment(data).format("DD MMMM YYYY");
                }
            },
            { data: "email" },
            { data: "phoneNumber" },
            {
                data: 'action',
                render: function (data, type, row) {
                    return '<button onclick="detail(\'' + row.url + '\')" data-bs-toggle="modal" data-bs-target="#modal" class="btn btn-info">Detail</button>';
                }
            }
        ],
    });
});

/*$(document).ready(function () {
    moment.locale('id');
    $('#myTable').DataTable({
        ajax: {
            url: "https://localhost:44362/Api/employees",
            dataType: "JSON",
            dataSrc: "data" //data source -> butuh array of object
        },
        dom: 'Bfrtip',
        buttons: [
            'colvis', 'copy',
            {
                extend: 'excelHtml5',
                title: 'Excel',
                text: 'Export to excel',
                className: "btn-primary",
                //Columns to export
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6, 7]
                }
            },
            {
                extend: 'pdfHtml5',
                title: 'PDF',
                text: 'Export to PDF',
                //Columns to export
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6, 7]
                }
            },
            {
                extend: 'print',
                exportOptions: {
                    columns: ':visible'
                }
            }
        ],
        fixedColumns: {
            left: 0,
        },
        autoWidth: false,
        columns: [
            {
                data: null,
                render: function (data, type, row, meta) {
                    return meta.row + 1;
                }
            },
            { data: "nik", },
            { data: "firstName", },
            {
                data: "birthDate",
                render: function (data, type, row) {
                    return moment(data).format('DD MMMM YYYY');
                }
            },
            {
                data: "gender",
                render: function (data, type, row) {
                    if (data == 0) {
                        return 'Female';
                    }
                    return 'Male';
                }
            },
            {
                data: "hiringDate",
                render: function (data, type, row) {
                    return moment(data).format('DD MMMM YYYY');
                }
            },
            { data: "email", },
            { data: "phoneNumber", },
            
            {
                data: null,
                render: function (data, type, row) {
                    return `<button onclick="detail('${data.url}')" data-bs-toggle="modal" data-bs-target="#modalPKM" class="btn btn-primary">Detail</button>`;
                }
            }
        ]
    });
});*/