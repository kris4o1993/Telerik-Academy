(function () {
    var students = [
        {
            firstName: 'Doncho',
            lastName: 'Minkov',
            score: 78
        },
        {
            firstName: 'Pavel',
            lastName: 'Kolev',
            score: 80
        },
        {
            firstName: 'Ivaylo',
            lastName: 'Kenov',
            score: 100
        },
        {
            firstName: 'Nikolay',
            lastName: 'Kostov',
            score: 23
        }
    ];

    for (var i = 0; i < students.length; i++) {
        $('#the-table').append('<tr>' + generateData(students[i]) + '</tr>');


        function generateData(students) {
            var result = '';
            for (var studentsData in students) {
                result += '<td>' + students[studentsData] + '</td>';
            }
            return result
        }
    }


    applyStyles();

    function applyStyles() {
        $('td, th').css('border', '1px solid black');
        $('table').css({
            'border': '1px solid black',
            'border-collapse': 'collapse'
        });
    }

})();