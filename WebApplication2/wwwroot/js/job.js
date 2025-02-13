function showFields(type) {
    document.getElementById('hbl-fields').style.display = (type === 'hbl') ? 'block' : 'none';
    document.getElementById('mbl-fields').style.display = (type === 'mbl') ? 'block' : 'none';
}

// Hiển thị mặc định HBL khi tải trang
document.addEventListener("DOMContentLoaded", function () {
    showFields('hbl');
});