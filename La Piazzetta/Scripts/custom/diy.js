(function () {
    $('#bootstrap, #foundation').sortable({
        placeholder: 'placeholder',
        connectWith: '.widget-container',
        handle: '.widget-head',
        cursor: 'move'
    });
    
}).call(this);

$(document).ready(function () {

    var ingredientsIds = "";
    var click = true;
    $("#confirm-ingredients").on('click', function (e) {
        if (click === true) {

            var searchEles = document.getElementById("foundation").children;
            for (var i = 0; i < searchEles.length - 1; i++) {
                ingredientsIds += searchEles[i].querySelector("#ingId").firstChild.nodeValue + ",";
            }
            $("#SelectedIngredients")[0].value = ingredientsIds;
            document.getElementById('create-order').disabled = false;
            click = false;
        }
    });
})