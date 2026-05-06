function openModal(type, price) {
    document.getElementById("modalTitle").innerText = "Book " + type;
    document.getElementById("modalPrice").innerText = price;

    var modal = document.getElementById("bookingModal");
    modal.classList.add("show");
    modal.style.display = "block";
}

function closeModal() {
    var modal = document.getElementById("bookingModal");
    modal.classList.remove("show");
    modal.style.display = "none";
}

function confirmBooking() {
    document.getElementById("modalBody").innerHTML =
        `<div class="alert alert-success text-center fw-bold">
            ✅ Booking Successfully Done!
        </div>`;

    setTimeout(closeModal, 1500);
}
