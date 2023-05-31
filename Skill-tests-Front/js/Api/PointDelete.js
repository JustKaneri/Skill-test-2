
export function DeletePoint(id){
    return new Promise(function(resolve, reject) {
        $.ajax({
            type: "DELETE",
            url: "http://localhost:5136/api/v1/point/"+id,
            dataType: "json",
            success: function(data) {
                resolve(data);
            }
        });
    });
}