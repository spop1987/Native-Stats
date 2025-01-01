function scrollCarousel(direction, leagueId) {
    const carousel = document.getElementById(`carousel-${leagueId}`);
    if (!carousel) return;

    const scrollAmount = carousel.offsetWidth * 0.8; // Scroll 80% of the visible width
    carousel.scrollBy({
        left: direction * scrollAmount,
        behavior: "smooth"
    });
}

function filterMatches(status) {
    // Get all match cards
    const matchCards = document.querySelectorAll('.match-card');
    
    // Filter match cards based on status
    matchCards.forEach(card => {
        if (card.getAttribute('data-status') === status) {
            card.style.display = 'block'; // Show matching cards
        } else {
            card.style.display = 'none'; // Hide non-matching cards
        }
    });

    // Update button states
    document.getElementById('recent').classList.toggle('active', status === 'FINISHED');
    document.getElementById('upcoming').classList.toggle('active', status === 'SCHEDULED');
}