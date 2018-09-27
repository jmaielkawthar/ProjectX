"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var file2_1 = require("./file2");
var City = /** @class */ (function () {
    function City() {
        this.City_Name = "";
        this.City_Adresse = new file2_1.Adresse();
    }
    City.prototype.Validate = function () {
        alert("this is where i live");
    };
    return City;
}());
//# sourceMappingURL=file3.js.map