$.validator.methods.range = function (value, element, param) {
    console.log("Metodo range");
    var globalizedValue = value.replace(".", "");
    console.log(globalizedValue);
    globalizedValue = globalizedValue.replace(",", ".");
    return this.optional(element) ||
        (globalizedValue >= param[0] &&
            globalizedValue <= param[1]);
};

$.validator.methods.number = function (value, element) {
    console.log("Metodo number");
    return this.optional(element) ||
        /^-?(?:\d+|\d{1,3}(?:[\s\.,]\d{3})+)(?:[\.,]\d+)?$/
            .test(value);
};