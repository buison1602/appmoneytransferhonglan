$(document).ready(function () {
    $('body').on('click', '#btn-profile', function () {
        // do something
        $('#profileModal').modal('show');
    });
    ////Upload image
    //$('#FileStorageForm input[name=FileStorage]').change(function () {
    //    $('#FileStorageForm').submit();
    //});

    //$('#FileStorageForm').ajaxForm({
    //    beforeSubmit: function (formData, jqForm, options) {
    //        var $fileInput = $('#FileStorageForm input[name=FileStorage]');
    //        var files = $fileInput.get()[0].files;

    //        if (!files.length) {
    //            return false;
    //        }

    //        var file = files[0];

    //        //File type check
    //        var type = '|' + file.type.slice(file.type.lastIndexOf('/') + 1) + '|';
    //        if ('|jpg|jpeg|png|gif|'.indexOf(type) === -1) {
    //            abp.message.warn(app.localize('FileStorage_Warn_FileType'));
    //            return false;
    //        }



    //        var mimeType = _.filter(formData, { name: 'FileStorage' })[0].value.type;

    //        formData.push({ name: 'FileType', value: mimeType });
    //        formData.push({ name: 'FileName', value: file.name });
    //        formData.push({ name: 'FileToken', value: app.guid() });

    //        return true;
    //    },
    //    success: function (response) {
    //        if (response.success) {

    //            uploadedFileToken = response.result.fileToken;
    //            uploadedFileType = response.result.fileType;
    //            uploadedFileName = response.result.fileName;
    //        } else {
    //            abp.message.error(response.error.message);
    //        }
    //    }
    //});

});