var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    }
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Customer = /** @class */ (function () {
    function Customer() {
        this.CustomerName = "";
    }
    Customer.prototype.Validate = function () {
        alert("First customer i'm here ");
    };
    return Customer;
}());
var Second_Customer = /** @class */ (function (_super) {
    __extends(Second_Customer, _super);
    function Second_Customer() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Second_Customer.prototype.Validate = function () {
        alert("Second customer i'm here ");
    };
    return Second_Customer;
}(Customer));
//# sourceMappingURL=file1.js.map