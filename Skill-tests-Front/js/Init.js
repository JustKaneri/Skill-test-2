import {GetData} from './Api/PointServis.js';
import { Canva } from './Canva.js';

GetData().then(function(data) {

    var canv = new Canva();
    
    data.map((value)=>{
      canv.createPoint(value);
      canv.craeteTable(value);
    });
});
