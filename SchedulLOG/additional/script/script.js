$(document).ready(function () {
    $('#cbPass').click(function () {
        if ($(this).is(':checked')) {
            $('#tbPass').atrr('type', 'text');
            $('#tbPassConf').atrr('type', 'text');
        }
        else {
            $('#tbPass').atrr('type', 'password');
            $('#tbPassConf').atrr('type', 'password');
        }
    })
})