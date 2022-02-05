let uname = prompt("Adınız Nedir?");
uname = uname.trim().length <= 0 ? "Misafir" : uname;

document.getElementById("myName").innerText = uname;

function showTime() {
  let date = new Date();
  let day = date.toLocaleDateString("tr-TR", "weekday: 'long'");
  let h = date.getHours();
  let m = date.getMinutes();
  let s = date.getSeconds();
  let time = h + ":" + m + ":" + s + " " + day;
  document.getElementById("myClock").innerText = time;
  setTimeout(showTime, 1000);
}

showTime();
