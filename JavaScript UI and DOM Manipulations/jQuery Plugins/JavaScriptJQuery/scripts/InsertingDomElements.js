function insert() {
    var initial = $('#initial');
    $('<div>This is the before div element!</div>').insertBefore(initial);
    $('<div>This is the after div element!</div>').insertAfter(initial);
}
