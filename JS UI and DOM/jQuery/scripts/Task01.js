(function() {
    var currentSlideIndex = 0,

        content = [
        '<img src="images/1.jpg" />',
        '<img src="images/2.jpg" />',
        '<img src="images/3.jpg" />'
        ];

    setSlide();

    function setSlide() {
        $('#current-slide').html(content[currentSlideIndex]);
    }

    $('#left-arrow').on('click', slideLeft);
    $('#right-arrow').on('click', slideRight);

    function slideLeft() {
        currentSlideIndex--;
        if (currentSlideIndex < 0) {
            currentSlideIndex = content.length - 1;
        }
        setSlide();
        resetTimer();
    }

    function slideRight() {
        currentSlideIndex++;
        if (currentSlideIndex === content.length) {
            currentSlideIndex = 0;
        }

        setSlide();
        resetTimer();
    }

    var autoSlideChanger = setInterval(slideRight, 2000);

    function resetTimer() {
        clearInterval(autoSlideChanger);
        autoSlideChanger = setInterval(slideRight, 2000);
    }



})();