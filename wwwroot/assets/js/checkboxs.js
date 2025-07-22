function checkboxs() {
    var selectAllItems = "#select-all";
    var checkboxItem = ":checkbox";

    $(selectAllItems).click(function () {

        if (this.checked) {
            $(checkboxItem).each(function () {
                this.checked = true;
            });
        } else {
            $(checkboxItem).each(function () {
                this.checked = false;
            });
        }

    });
}

function getChecked() {
    let checked = [];
    $("input:checkbox:checked").each(function () {
        checked.push($(this).val());
    });
    return checked;
}