const tB_name = document.getElementById("name");
const tB_surname = document.getElementById("surname");
const btn_submit = document.getElementById("submit");
const form = document.getElementById("userForm");
const isEmpty = (str) => !str.trim().length;

// TextBox içini kontrol etme
document.onload = () => {
    form_control();
};
tB_name.onchange = () => {
    form_control();
};
tB_surname.onchange = () => {
    form_control();
};

function form_control() {
    if (isEmpty(tB_surname.value) || isEmpty(tB_name.value)) {
        btn_submit.disabled = "disabled";
    } else {
        btn_submit.disabled = "";
    }
}
//

form.onsubmit = (event) =>{
    event.preventDefault();
    const user = document.createElement("div");
    user.classList.add("alert","alert-success","text-center","anim");
    user.onclick = () =>{
        user.classList.replace("alert-success","alert-danger");
        user.innerHTML = "3 saniye içinde silinecek!"
        setTimeout(function(){
        user.remove();
        },3000);
       
    };
    user.innerHTML = `${tB_name.value} ${tB_surname.value}, buyurun içeri geçin! (Tıklayıncı silinir)`;
    document.getElementById("area").prepend(user);
}

