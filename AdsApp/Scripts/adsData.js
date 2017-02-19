$(document).ready(function () {
 
    $.when($.ajax({
        url: "/api/AdsData/GetImage",
        type: "GET",
        cache: false,
        contentType: "application/octet-stream",
        success: function (data) {
          //  console.log(data);
        },
        error: function (jqXHR) {
            console.log("found error");
            console.log(jqXHR);
        }
    }
           ), $.ajax({
               url: "/api/AdsData/GetQuestion",
               type: "GET",
               cache: false,
               contentType: "application/json",
               success: function (data) {
                  // console.log(data);
               },
               error: function (jqXHR) {
                   console.log("found error");
                   console.log(jqXHR);
               }
           }
            ),$.ajax({
                url: "/api/AdsData/GetData",
                type: "GET",
                cache: false,
                contentType: "application/json",
                success: function (data) {
                    // console.log(data);
                },
                error: function (jqXHR) {
                    console.log("found error");
                    console.log(jqXHR);
                }
            })        
            
            
            
            ).done(function (image, text,data) {
                $("#adimg").attr("src", "data:image/png;base64," + data[0].Image);
                $("#adquest").text(data[0].Question);
        console.log(data);
    });
}

);

