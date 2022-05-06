////import 'bootstrap.css';
////import '@grapecity/wijmo.styles/wijmo.css';
////import './styles.css';
//
//import * as input from './wijmo.input';
//var module = require('node_modules/systemjs/dist/system.src.js');
//var sistema = require('systemjs.config.js');
//var input = require('./wijmo.input');
//

//const { Control } = require("./wijmo");

//var input = require('@grapecity/wijmo.input');
//document.readyState === 'complete' ? init() : window.onload = init;

 function initComboBox(obj) {
    
     let myCombo = new wijmo.input.ComboBox('#theComboBox', {
         itemsSource: obj
     });
   
    
}
function initGrid(obj) {
   
    var data = [];
    for (var i = 0; i < obj.length; i++) {
        data.push({

            product: obj[i].productName,
            code: obj[i].code,
            price: obj[i].price
        });
    }
   
    var myGrid = new wijmo.grid.FlexGrid('#theGrid', {
        autoGenerateColumns: false,
        allowAddNew:true,
        columns: [
            { binding: 'product', header: 'Product Name', width: '2*' },
            { binding: 'code', header: 'Code', width: '*' },
            { binding: 'price', header: 'Price', width: '*', format: 'c2' }
        ],
        itemsSource: data
    });
    

}
