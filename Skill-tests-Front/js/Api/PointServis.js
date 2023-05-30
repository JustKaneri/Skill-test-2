export function GetData() {
    return new Promise(function(resolve, reject) {
        $.ajax({
            type: "GET",
            url: "http://localhost:5136/api/v1/points",
            dataType: "json",
            success: function(data) {
                resolve(data);
            }
        });
    });
}