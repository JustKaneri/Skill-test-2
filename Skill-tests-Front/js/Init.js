import {GetData} from './Api/PointServis.js';

GetData().then(function(data) {
    // Run this when your request was successful
    console.log(data)
});

var width = window.innerWidth;
var height = window.innerHeight;

var stage = new Konva.Stage({
        container: 'canvas',
        width: width,
        height: height,
      });

      var layer = new Konva.Layer();

stage.add(layer);



// 1) Получть данные 
// 2) Преобразовать в классы
// 3) Нарисовать круги 
// 4) Нарисовать таблицы
// 5) Добавить обработчики событий