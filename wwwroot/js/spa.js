let cart = [];
let currentService = "";
let currentPrice = 0;

function addToCart(name, price, date = "", time = "") {
    cart.push({ name, price, date, time });
    updateUI();
}

function confirmBooking() {
    let date = document.getElementById("date").value;
    let time = document.getElementById("time").value;

    if (!date || !time) {
        alert("⚠️ Please select date and time");
        return;
    }

    document.getElementById("spaBookingForm").submit();
}


function toggleBookings() {
    document.getElementById("bookingSection").classList.toggle("d-none");
}

function closeModal() {
    document.getElementById("spaModal").classList.add("d-none");
    document.getElementById("date").value = "";
    document.getElementById("time").value = "";
}

function updateUI() {
    let list = document.getElementById("bookingList");
    let total = 0;

    list.innerHTML = "";

    cart.forEach(item => {
        total += item.price;

        list.innerHTML += `
            <li class="list-group-item d-flex justify-content-between">
                <div>
                    <strong>${item.name}</strong><br/>
                    <small>📅 ${item.date} ⏰ ${item.time}</small>
                </div>
                <span>₹${item.price}</span>
            </li>`;
    });

    document.getElementById("cartCount").innerText = cart.length;
    document.getElementById("totalPrice").innerText = total;
}
