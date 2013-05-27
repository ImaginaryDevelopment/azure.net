var CalculatorViewModel = function () {
    var self = this;
    self.loaded = new Date();
    self.result = ko.observable(0);
    self.userinput = ko.observable();
    self.equals = function () {
        self.selectedOperation()();
    };
    self.add = function () {
        self.result(+self.result() + +self.userinput());
        self.userinput('');
    };
    self.subtract = function () {
        self.result(+self.result() - +self.userinput());
        self.userinput('');
    };
    self.multiply = function () {
        self.result(+self.result() * +self.userinput());
        self.userinput('');
    };
    self.divide = function () {
        self.result(+self.result() / +self.userinput());
        self.userinput('');
    };
    self.clear = function() {
        self.result(0);
    };
    self.operations = [{
        name: 'equals',
        key: '=',
        fn: self.equals
    }, {
        name: 'add',
        key: '+',
        fn: self.add
    }, {
        name: 'subtract',
        key: '-',
        fn: self.subtract
    }, {
        name: 'multiply',
        key: '*',
        fn: self.multiply
    }, {
        name: 'divide',
        key: '/',
        fn: self.divide
    }, {
        name: 'clear',
        key: 'esc', fn: self.clear
    }
    ];
    self.selectedOperation = ko.observable(self.operations[1]);
    self.checkkey = function (vm, e) {
        var found = ko.utils.arrayFirst(self.operations, function (item) {


            return item.key.charCodeAt(0) === e.which;
        });
        console.log('found?');
        console.log(found);
        if (found !== null) {
            console.log('found!');
            //e.preventDefault();
            found.fn();
        } else {
            return true;
        }
    };
};

ko.applyBindings(new CalculatorViewModel());