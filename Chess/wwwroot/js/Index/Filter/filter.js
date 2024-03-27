
function filter (type) {
    
    let cards
    let i;
    let count;

    cards   = document.getElementsByClassName("card");
    buttons = document.getElementsByClassName("year-btn");

    for (i = 0; i < cards.length; i++) {

        cards[i].style.display = 'none';

        if (cards[i].classList.contains(type)) {
            cards[i].style.display = 'block';
            count++;
        }
    };
}
