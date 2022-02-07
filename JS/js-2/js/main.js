const tB_task = document.getElementById("task");
const btn_liveToastBtn = document.getElementById("liveToastBtn");
const ul_list = document.getElementById("list");
const isEmpty = (str) => !str.trim().length;

let TODO_LIST = JSON.parse(localStorage.getItem("TODO_LIST"));

function update() {
  TODO_LIST.forEach((item, index) => {
    updateElement(item, index);
  });
  control();
}

tB_task.onkeyup = (event) => {
  if (event.keyCode === 13) {
    btn_liveToastBtn.click();
  }
};

function newElement(item) {
  if (isEmpty(tB_task.value) && item == null) {
    $(".toast.error").toast("show");
    tB_task.value = "";
  } else {
    TODO_LIST.push({ text: `${tB_task.value}`, isChecked: false, date: "" });
    // ------------------ Tarih -------------------
    let today = new Date();
    let date =
      ("0" + today.getDate()).slice(-2) +
      "." +
      ("0" + (today.getMonth() + 1)).slice(-2) +
      "." +
      today.getFullYear();
    TODO_LIST[TODO_LIST.length - 1].date = date;
    // --------------------------------------------
    tB_task.value = "";
    updateElement(TODO_LIST[TODO_LIST.length - 1], TODO_LIST.length - 1);
    localStorage.setItem("TODO_LIST", JSON.stringify(TODO_LIST));
  }
}

function updateElement(item, id) {
  let add = document.createElement("li");
  add.innerHTML = item.text;
  // ------------------ Tarih -------------------
  let addDate = document.createElement("span");
  addDate.classList.add("date");
  addDate.innerHTML = item.date;
  add.append(addDate);
  // --------------------------------------------
  // -------------- Listeden silme---------------
  let close = document.createElement("span");
  close.innerHTML = "&times;";
  close.classList.add("close");
  close.onclick = () => {
    add.remove();
    TODO_LIST.splice(id, 1);
    localStorage.setItem("TODO_LIST", JSON.stringify(TODO_LIST));
    control();
  };
  add.append(close);
  // --------------------------------------------
  // ---------------- İşaretleme ----------------
  add.onclick = () => {
    if (add.classList.value == "checked") {
      add.classList.remove("checked");
      TODO_LIST[id].isChecked = false;
    } else {
      add.classList.add("checked");
      TODO_LIST[id].isChecked = true;
    }
    localStorage.setItem("TODO_LIST", JSON.stringify(TODO_LIST));
  };
  if (item.isChecked == true) add.classList.add("checked");
  // --------------------------------------------
  ul_list.prepend(add);
  control();
}

const ul_li = document.querySelector("ul#list");
const btn_yesModal = document.getElementById("yesModal");
const btn_clean = document.getElementById("clean");

btn_yesModal.onclick = () => {
  $("#cleanModal").modal("hide");
  TODO_LIST = [];
  localStorage.setItem("TODO_LIST", JSON.stringify(TODO_LIST));
  ul_li.innerHTML = "";
  control();
};

function control() {
  if (TODO_LIST == 0) clean.disabled = true;
  else clean.disabled = false;
}
