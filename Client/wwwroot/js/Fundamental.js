let arrayMhsObj = [
    { nama: "budi", nim: "a112015", umur: 20, isActive: true, fakultas: { name: "komputer" } },
    { nama: "joko", nim: "a112035", umur: 22, isActive: false, fakultas: { name: "ekonomi" } },
    { nama: "herul", nim: "a112020", umur: 21, isActive: true, fakultas: { name: "komputer" } },
    { nama: "herul", nim: "a112032", umur: 25, isActive: true, fakultas: { name: "ekonomi" } },
    { nama: "herul", nim: "a112040", umur: 21, isActive: true, fakultas: { name: "komputer" } },
];
console.log(arrayMhsObj)

//1.buat sebuah variable 'fakultasKomputer' => yang didalamnya hanya berisi object dengan fakultas komputer.
let fakultasKomputer = arrayMhsObj.filter((mhs) => mhs.fakultas.name === "komputer");

console.log(fakultasKomputer);

//2.jika 2 angka di nim terakhir adalah lebih dari >= 30, maka buat isactive == false.
let updatedArrayMhsObj = arrayMhsObj.map((mhs) => {
    if (parseInt(mhs.nim.slice(-2)) >= 30) {
        return { ...mhs, isActive: false };
    } else {
        return mhs;
    }
});

console.log(updatedArrayMhsObj);