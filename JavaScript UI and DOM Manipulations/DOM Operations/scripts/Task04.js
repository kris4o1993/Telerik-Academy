var tags = ["cms", "javascript", "js", "html", "ASP.NET MVC", ".net", ".net", "html", "css",
        "wordpress", "xaml", "js", "xaml", "css", "http", "ASP.NET MVC", "web", "ASP.NET MVC", "asp.net", "asp.net MVC", "ASP.NET MVC",
        "wp", "html", "javascript", "js", "cms", "html", "javascript", "javascript", "http", "http", "CMS",
        "javascript", "js", "javascript", "js", "js", "javascript", "css", "js"
    ],
    pairs = sortElements(tags);

//this function returns 2 arrays (looks like dictionary in C#)
function sortElements(tags) {
    var key = [],
        value = [],
        previousElement;

    //sorting and converting all to lower case
    var sortedTags = [];
    for (var i = 0; i < tags.length; i++) {
        sortedTags.push(tags[i].toLowerCase());
    }
    sortedTags.sort();

    for (i = 0; i < sortedTags.length; i++) {
        //check if current element is different than the previous one
        if (sortedTags[i] !== previousElement) {
            //adding it into new array
            key.push(sortedTags[i]);
            //make it's repetition value to 1
            value.push(1);
        } else {
            //if the element is the same as the previous one, increase it's counter by 1
            value[value.length - 1]++;
        }

        previousElement = sortedTags[i];
    }

    return [key, value];
}

function generateTagCloud(tags, minFont, maxFont) {
    var container = document.getElementById('container'),
        tagCloud = document.createDocumentFragment(),
        count = tags[0].length,
        itemsInBiggestTag = Math.max.apply(null, tags[1]);

    for (var i = 0; i < count; i++) {
        var item = document.createElement('span');
        item.innerHTML = tags[0][i] + ' ';

        //very complicated formula. DO NOT TOUCH!
        item.style.fontSize = Math.floor(((tags[1][i] / itemsInBiggestTag) * (maxFont - minFont)) + minFont) + 'px';

        tagCloud.appendChild(item);
    }
    container.appendChild(tagCloud);
}

generateTagCloud(pairs, 17, 42);