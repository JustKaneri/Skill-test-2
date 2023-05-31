import {GetData} from './Api/PointServis.js';
import { Canva } from './Canva.js';

GetData().then(function(data) {

    var canv = new Canva();
    
    data.map((value)=>{
      canv.createPoint(value);
    });
});

// 1) Получть данные +
// 2) Преобразовать в классы -
// 3) Нарисовать круги +
// 4) Нарисовать таблицы
// 5) Добавить обработчики событий +