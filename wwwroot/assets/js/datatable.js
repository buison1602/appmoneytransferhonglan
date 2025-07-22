let DT1;
function initReportDatatable(userId, apiURL, payload) {
    $(document).ready(function () {
      
       
      DT1 = $("#basic-datatable").DataTable({
          screenX: true,
         /* sScrollX: "100%",*/
      processing: true,
      serverSide: true,
      ajax: function (data, callback, settings) {
        payload.pageSize = data.length;
        payload.pageIndex = Math.floor((data.start + 1) / data.length) + 1;

        fetch(`${apiURL}/Report/GetGeneralDailyReport`, {
          method: "POST",
          headers: {
            "Content-Type": "application/json",
          },
          body: JSON.stringify(
            $.extend(
              {},
              data,
              payload
            )
          ),
        })
          .then((resp) => resp.json())
          .then((resp) => {
            callback({
              recordsTotal: resp.Content.Table2[0].NoofTran,
              // recordsFiltered: resp.Content.Table.length,
              recordsFiltered: resp.Content.Table2[0].NoofTran,
              data: resp.Content.Table,
            });
          });
          },
          columnDefs: [{
              orderable: false,
              className: 'select-checkbox',
              target: 0
          }],
        select: {
            style: 'multi',
            selector: 'td:nth-child(2)'
        },
      searching: false,
      aaSorting: [],
          columns: [
              {
                  data: null,
                  title: "",
                  orderable: false,
                  render: function (dt, type, row, meta) {
                      if (dt.Accept === false) {
                          return '<a class="edit-report" data-json="' + dt + '" href="javascript:void(0)"><i class="fas fa-edit"></i></a>';
                      }
                      return '';
                  }
              },
              {
                orderable: false,
                className: 'select-checkbox' },
            { data: "OrderNo1", title:"Mã Số Hồ Sơ 1",  orderable: false },
            { data: "OrderNo2", title:"Mã Số Hồ Sơ 2", orderable: false },
            { data: "OrderDate", title:"Ngày Hồ Sơ",  orderable: false },
            { data: "DateIssue", title: "Ngày Chi", orderable: false },
            { data: "CusID", title: "Đối Tác",  orderable: false },
            { data: "Sender", title: "Người Gửi", orderable: false },
            { data: "NguoiNhan", title: "Người Nhận", orderable: false },
            { data: "BenAddress", title: "Địa Chỉ Người Nhận", orderable: false },
            { data: "BenTelNo", title: "ĐT Người Nhận", orderable: false },
            { data: "IDCard", title: "CMND/Passport", orderable: false },
            { data: "CorrespLocName", title: "Chi nhánh", orderable: false },
            { data: "Amount", title: "Số tiền", orderable: false },
            { data: "Currency", title: "Loại tiền", orderable: false },
            { data: "CorrespLocName", title: "Đợt nhận", orderable: false },
            { data: "HinhThucChi", title: "Hình thức chi trả", orderable: false },
            { data: "Employee", title: "Nhân viên chi trả", orderable: false },
            { data: "Message", title: "Tin nhắn", orderable: false },
            { data: "Messageerror", title: "Ghi chú", orderable: false },
            { data: "StatusID", title: "Status", orderable: false },
            { data: "Issue", title: "Đã chi", orderable: false },
            { data: "Upload", title: "Upload", orderable: false },
            { data: "Cancel", title: "Hủy", orderable: false },            
        ],
      bDestroy: true,
      pageLength: 50,
        lengthMenu: [[10, 25, 50, 100, 200, 500, 1000, -1], [10, 25, 50, 100, 200, 500, 1000, "All"]],
        //dom: '<"top"f>rt<"bottom"<"inline-block mr-4"i><"inline-block"p><"inline-block float-right mt-1"l>><"clear">'
        dom: '<"row"f>rt<"row"<"col-sm-12 col-md-4"p><"col-sm-12 col-md-4"i><"col-sm-12 col-md-4 float-right"l>><"clear">'
    });
        DT1.on("click", "th.select-checkbox", function () {
          if ($("th.select-checkbox").hasClass("selected")) {
              DT1.rows().deselect();
              $("th.select-checkbox").removeClass("selected");
          } else {
              DT1.rows().select();
              $("th.select-checkbox").addClass("selected");
          }
      }).on("select deselect", function () {
          ("Some selection or deselection going on")
          if (DT1.rows({
              selected: true
          }).count() !== DT1.rows().count()) {
              $("th.select-checkbox").removeClass("selected");
          } else {
              $("th.select-checkbox").addClass("selected");
          }
      });
        
  });
}

function initDatatable(el, apiURL, apiResource, payload, columns, ajaxCallback) {
    $(el).DataTable({
        responsive: false,
        scrollX: true,
        sScrollX: "100%",
        bScrollCollapse: true,
        processing: true,
        serverSide: true,
        ajax: function (data, callback, settings) {
            payload.pageSize = data.length;
            payload.pageIndex = Math.floor((data.start + 1) / data.length) + 1;

            fetch(`${apiURL}/${apiResource}`, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(
                    $.extend(
                        {},
                        data,
                        payload
                    )
                ),
            })
                .then((resp) => resp.json())
                .then((resp) => {
                    callback(ajaxCallback(resp));
                });
        },
        searching: false,
        aaSorting: [],
        columns: columns,
        bDestroy: true,
        //dom: '<"top"f>rt<"bottom"ipl><"clear">'
        //dom: '<"top"f>rt<"bottom"<"inline-block mr-4"i><"inline-block"p><"inline-block float-right mt-1"l>><"clear">'
        lengthMenu: [[10, 25, 50, 100, 200, 500, 1000, -1], [10, 25, 50, 100, 200, 500, 1000, "All"]],
        dom: '<"row"f>rt<"row"<"col-sm-12 col-md-4"p><"col-sm-12 col-md-4"i><"col-sm-12 col-md-4 float-right"l>><"clear">'
    });
}

function initReportTable(el, apiURL, apiResource, payload, columns) {
    initDatatable(el, apiURL, apiResource, payload, columns, (resp) => {
        const content = resp.Content;
        const data = content ? content.Table : [];
        const total = content ? resp.Content.Table2[0].NoofTran : 0;
        return {
            recordsTotal: total,
            recordsFiltered: total,
            data: data,
        }
    });
}

function initEmployeeTable(el, apiURL, apiResource, payload, columns) {
    initDatatable(el, apiURL, apiResource, payload, columns, (resp) => {
        const content = resp.Content;
        const total = content ? content.length : 0;
        return {
            recordsTotal: total,
            recordsFiltered: total,
            data: content ?? [],
        }
    });
}

function initCompanyTable(el, apiURL, apiResource, payload, columns) {
    initDatatable(el, apiURL, apiResource, payload, columns, (resp) => {
        const content = resp.Content;
        const total = content ? content.length : 0;
        return {
            recordsTotal: total,
            recordsFiltered: total,
            data: content ?? [],
        }
    });
}

function initCustomerTable(el, apiURL, apiResource, payload, columns) {
    initDatatable(el, apiURL, apiResource, payload, columns, (resp) => {
        const content = resp.Content ? resp.Content.Table : [];
        const total = content ? content.length : 0;
        return {
            recordsTotal: total,
            recordsFiltered: total,
            data: content ?? [],
        }
    });
}
