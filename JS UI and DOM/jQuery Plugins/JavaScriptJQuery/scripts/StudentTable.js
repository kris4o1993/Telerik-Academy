function generateTable() {
    var students = [{
        firstName: 'Peter',
        lastName: 'Ivanov',
        grade: 3
    },
    {
        firstName: 'Milena',
        lastName: 'Grigorova',
        grade: 6
    },
    {
        firstName: 'Gergana',
        lastName: 'Borisova',
        grade: 12
    },
    {
        firstName: 'Boyko',
        lastName: 'Petrov',
        grade: 7
    }];

    var wrapper = $('#wrapper');
    var table = '';

    table += '<table><thead><tr><th>First name</th><th>Last name</th><th>Result</th></tr></thead><tbody>';
    for (var i = 0; i < students.length; i++) {
        table += '<tr><td>' + students[i].firstName + '</td>' + '<td>' + students[i].lastName + '</td>' + '<td>' + students[i].grade + '</td></tr>'
    }

    table += '</tbody></table>';
    wrapper.append(table);

    var tableElements = $('table, th, th, tr, td');
    tableElements.css('border', '1px solid black');
    tableElements.css('border-collapse', 'collapse');
}