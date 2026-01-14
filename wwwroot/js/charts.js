window.renderNewUsersChart = (labels, data) => {
    const canvas = document.getElementById("newUsersChart");
    if (!canvas) return;

    if (typeof Chart === "undefined") return;

    if (window._newUsersChart) window._newUsersChart.destroy();

    window._newUsersChart = new Chart(canvas, {
        type: "line",
        data: {
            labels: labels,
            datasets: [{
                label: "New Users",
                data: data,
                borderColor: "#38BDF8",          
                backgroundColor: "#38BDF833",
                fill: true,
                borderWidth: 3,
                tension: 0.4
            }]

        },
        options: {
            responsive: true,
            maintainAspectRatio:false,
            scales: {
                x: { ticks: { color: "white" } },
                y: { ticks: { color: "white" }, beginAtZero: true }
            },
            plugins: {
                legend: { labels: { color: "white" } }
            }
        }

    });
};

window.renderRestaurantsChart = (labels, data) => {
    const canvas = document.getElementById("restaurantsChart");
    if (!canvas) return;

    if (window._restaurantsChart) window._restaurantsChart.destroy();

    window._restaurantsChart = new Chart(canvas, {
        type: "line",
        data: {
            labels: labels,
            datasets: [{
                label: "New Restaurants",
                data: data,
                borderColor: "#22C55E",
                backgroundColor: "#22C55E33",
                fill: true,
                borderWidth: 2,
                tension: 0.35
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            scales: {
                x: { ticks: { color: "white" } },
                y: { ticks: { color: "white" }, beginAtZero: true }
            },
            plugins: {
                legend: { labels: { color: "white" } }
            }
        }
    });
};

