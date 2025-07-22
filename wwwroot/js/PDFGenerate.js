//function DownloadPdf(filename, byteBase64) {
//    var link= document.createElement('a');
//    link.download = filename;
//    link.href = "data:application/octet-stream;base64," + byteBase64;
//    document.body.appendChild(link);
//    link.click();
//    document.body.removeChild(link);
//}

function ViewPdf(iframeId, byteBase64) {  
    document.getElementById(iframeId).innerHTML = "";
    var ifrm = document.createElement('iframe');
    ifrm.setAttribute("src", "data:application/pdf;base64," + byteBase64);
    ifrm.style.width = "100%";
    ifrm.style.height = "830px";
    document.getElementById(iframeId).appendChild(ifrm);
}
