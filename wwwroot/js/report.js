////function alert() {
////    console.log('Hello');
////}
$(document).ready(function () {
//    var inputs = $(':input').keypress(function (e) {
//        if (e.which == 13) {
//            e.preventDefault();
//            var nextInput = inputs.get(inputs.index(this) + 1);
//            if (nextInput) {
//                nextInput.focus();
//            }
//        }
//    });

//    $("#selectallReport").click(function () {
//        alert('a');
//        $('.checkOrderNo1Report').attr('checked', this.checked);
//    });
//    // if all checkbox are selected, check the selectall checkbox  also        

//    $(".checkOrderNo1Report").click(function () {
//        if ($(".checkOrderNo1Report").length == $(".checkOrderNo1Report:checked").length) {
//            $("#selectallReport").attr("checked", "checked");
//        }
//        else {
//            $("#selectallReport").removeAttr("checked");
//        }
//    });

//})

    $(document).on("keypress", ".NumberOnly", function (e) {
        return (e.charCode != 8 && e.charCode == 0 || (e.charCode >= 48 && e.charCode <= 57));
    });
    $(document).on("keypress", ".AlphaOnly", function (e) {
        return (e.charCode != 46 && e.charCode > 31
            && (e.charCode < 48 || e.charCode > 57));
    });
    
   $("input.masknum").each((i,ele)=>{
            let clone=$(ele).clone(false)
        clone.attr("type","text")
        let ele1=$(ele)
        clone.val(Number(ele1.val()).toLocaleString("en"))
        $(ele).after(clone)
        $(ele).hide()
    clone.mouseenter(()=>{

            ele1.show()
      clone.hide()
    })
    setInterval(()=>{
            let newv=Number(ele1.val()).toLocaleString("en")
        if(clone.val()!=newv){
            clone.val(newv)
        }
    },10)

    $(ele).mouseleave(()=>{
            $(clone).show()
      $(ele1).hide()
    })
    

  })
   

});