function circleArea(r){
    let area = Math.PI * Math.sqrt(r)
    console.log("Alanı: " + area)
}

function circleCircumference(r){
    let circumference = 2 * Math.PI * r
    console.log("Çevresi: " + circumference)
}

module.exports = {
    circleArea,
    circleCircumference
}