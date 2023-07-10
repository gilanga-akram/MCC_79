let getCol1 = document.getElementById('col-satu');
let getRow1 = document.getElementById('row-satu');
let getRow2 = document.getElementById('row-dua');
let getBtn1 = document.getElementById('btn-satu');
let getBtn2 = document.getElementById('btn-dua');
let getBtn3 = document.getElementById('btn-tiga');
let getBtnReset = document.getElementById('btn-reset');

getBtn1.addEventListener('click', () => {
    // Mengubah warna latar belakang kolom
    getCol1.style.backgroundColor = 'red';
    getRow1.style.backgroundColor = 'transparent';
    getRow2.style.backgroundColor = 'transparent';
});
getBtn2.addEventListener('click', () => {
    // Mengubah warna latar belakang kolom
    getCol1.style.backgroundColor = 'transparent';
    getRow1.style.backgroundColor = 'yellow';
    getRow2.style.backgroundColor = 'transparent';
});
getBtn3.addEventListener('click', () => {
    // Mengubah warna latar belakang kolom
    getCol1.style.backgroundColor = 'transparent';
    getRow1.style.backgroundColor = 'transparent';
    getRow2.style.backgroundColor = 'green';
});
getBtnReset.addEventListener('click', function () {
    // Mengubah warna latar belakang kolom
    getCol1.style.backgroundColor = 'transparent';
    getRow1.style.backgroundColor = 'transparent';
    getRow2.style.backgroundColor = 'transparent';
});