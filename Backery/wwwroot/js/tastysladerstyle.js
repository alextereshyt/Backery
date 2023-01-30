document.addEventListener('DOMContentLoaded',ready);
var img1,img2,img3;
function ready() {
    let l = document.getElementById("leftButton");
    let r = document.getElementById("rightButton");
    l.addEventListener('click', (event) => {
        sortarr2();
        fillarr();
    });
    r.addEventListener('click', (event) => {
        sortarr();
        fillarr();
    });
     img1=document.getElementById("img1");
     img2=document.getElementById("img2");
     img3=document.getElementById("img3");
    fillarr();

}
let arr = [
    "/image/Ebene8.png",
    "/image/img9.png",
    "/image/img10.png"
];
console.log("123");

function rightclick() {

    sortarr();
    fillarr();

}
function leftclick() {

  
  
}
function sortarr() {

    let l = arr.shift();
    arr.push(l);

}
function sortarr2() {

    let l = arr.pop();
    arr.unshift(l);


}
function fillarr(){
  let obj ={p1:arr[0],p2:arr[1],p3:arr[2]}
img1.style.backgroundImage = `url(${obj.p1})`;
img2.style.backgroundImage = 'url('+arr[1]+')';
img3.style.backgroundImage = 'url('+arr[2]+')';
console.log(arr,obj);

console.log(img1,img2,img3);
}