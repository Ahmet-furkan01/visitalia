function selectCity() {
    var cityId = document.getElementById('citySelect').value;
    if (cityId !== "0") {
        window.location.href = '/Home/TourInfo/' + cityId;
    } else {
        alert('Please select a city.');
    }
}