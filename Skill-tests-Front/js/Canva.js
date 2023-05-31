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

    craeteTable = (point) =>{
        var y = point.ycoordinate + point.radius + 10;
        
        point.comments.map((value)=>{

            var x = point.xcoordinate - 50;
            if(x < 0)
                x = 0;

            var text = new Konva.Text({
                x: x,
                y: y,
                text: value.content,
                fontSize: 14,
                fontFamily: 'Calibri',
                fill: 'green',
                width: 100,
                padding:5,
                align: 'center',
            });

            var rect = new Konva.Rect({
                x: x,
                y: y,
                stroke: 'black',
                strokeWidth: 1,
                fill: value.backColorHex,
                width: 100,
                height: text.height()
              });

            this.layer.add(rect);
            this.layer.add(text);

            y = y + text.height() + 2;
        });
    }
}