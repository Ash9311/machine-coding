const appDiv = document.getElementById('app');

let circle = document.querySelector(".circle");
let active = false;
circle.addEventListener('click',()=>{
  active = !active;
  if(!active){
    circle.classList.remove('move-right')
  circle.classList.add('move-left')
  }
  else{
    circle.classList.remove('move-left')
    circle.classList.add('move-right')
  }
})