function addTask() {
    var orderedList = document.getElementById('toDoList');
    var taskToAdd = document.getElementById('taskToAdd').value;
    var liToAppend = document.createElement('li');
    liToAppend.innerHTML = taskToAdd;
    orderedList.appendChild(liToAppend);
}

function removeTask() {
    var orderedList = document.getElementById('toDoList');
    var taskToRemove = document.getElementById('taskToRemove').value;
    var liElements = orderedList.getElementsByTagName('li');
    for (var i = 0; i < liElements.length; i++) {
        if (liElements[i].innerHTML === taskToRemove) {
            orderedList.removeChild(liElements[i]);
        }
    }
}

function showAll() {
	var orderedList = document.getElementById('toDoList');
	orderedList.style.display = 'block';
}

function hideAll() {
	var orderedList = document.getElementById('toDoList');
	orderedList.style.display = 'none';
}