function generateSlider() {
    var images = [{
        src: '<img src="images/1.jpg" width="400" />'
    },
    {
        src: '<img src="images/2.jpg" width="400" />'
    },
    {
        src: '<img src="images/3.jpg" width="400" />'
    },
    {
        src: '<img src="images/4.jpg" width="400" />'
    }];

    var slider = $('#slider');
    var index = 0;

    $('#previous').on('click', previousSlide);
    $('#next').on('click', nextSlide);

    var autoSlideChanger = setInterval(nextSlide, 3000);

    setSlide(index);

    function previousSlide() {
        index -= 1;
        if (index < 0) {
            index = images.length - 1;
        }

        clearInterval(autoSlideChanger);
        autoSlideChanger = setInterval(nextSlide, 3000);
        setSlide(index);
    }

    function nextSlide() {
        index += 1;
        if (index > images.length - 1) {
            index = 0;
        }

        clearInterval(autoSlideChanger);
        autoSlideChanger = setInterval(nextSlide, 3000);
        setSlide(index);
    }

    function setSlide(index) {
        slider.html(images[index].src);
    }
}