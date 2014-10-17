(function() {
    var $insert = $('#btnInsert');
    $insert.on('click', addContent);


    function addContent() {
        addBefore();
        addAfter();
    }

    function addBefore() {
        $('<p>BEFORE</p>').insertBefore($insert);
    }

    function addAfter() {
        $('<p>AFTER</p>').insertAfter($insert);
    }
})();