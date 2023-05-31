import { DeletePoint } from "./Api/PointDelete.js";

export class Canva{
    constructor(){
        var width = window.innerWidth;
        var height = window.innerHeight;

        this.stage = new Konva.Stage({
            container: 'canvas',
            width: width,
            height: height,
        });

        this.layer = new Konva.Layer();
    }

    createPoint = (point) => {
        var circle = new Konva.Circle({
            x: point.xcoordinate,
            y: point.ycoordinate,
            radius: point.radius,
            fill: point.colorHex
          });
          
        circle.on('dblclick', function () {

            DeletePoint(point.id).then(function() {
                location.reload();
            });
            
        });

        this.layer.add(circle);

        this.stage.add(this.layer);
    };
}