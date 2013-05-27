Number.prototype.formatMoney = function (c, d, t) {
    var n = this,
        c = isNaN(c = Math.abs(c)) ? 2 : c,
        d = d == undefined ? "." : d,
        t = t == undefined ? "," : t,
        s = n < 0 ? "-" : "",
        i = parseInt(n = Math.abs(+n || 0).toFixed(c)) + "",
        j = (j = i.length) > 3 ? j % 3 : 0;
    return s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
};

rivets.configure({
    adapter: {
        subscribe: function(obj, keypath, callback) {
            watch(obj, keypath, callback);
        },
        unsubscribe: function(obj, keypath, callback) {
            unwatch(obj, keypath, callback);
        },
        read: function(obj, keypath) {
            return obj[keypath];
        },
        publish: function(obj, keypath, value) {
            obj[keypath] = value;
        }
    }
});

rivets.binders.input = {
    publishes: true,
    routine: rivets.binders.value.routine,
    bind: function(el) {
        el.addEventListener('input', this.publish);
    },
    unbind: function(el) {
        el.removeEventListener('input', this.publish);
    }
};
rivets.formatters.debug = function(value) {
    console.log('debug formatter:' + value);
    return value.toString();
};
rivets.formatters.money = function(value) {
    if (!value)
        return '';
    return '$'+value.formatMoney(2, '.', ',');
};

var auction = { endingSoon: new Date(), currentBid: 1.00, remaining: 1 ,title:'oh hai!'};
var el = document.getElementById('rivetroot');
var RivetModel = {};

RivetModel.auction = auction;
RivetModel.image = { url: '' };
RivetModel.loaded = new Date().toString();

var calc = RivetModel.calc = {};
calc.userinput = null;
calc.result = 0;
calc.update = function (ev) {
    window.setTimeout(function() {
        $(ev.target).trigger('change');
    },100);
    
};
calc.lastoperation = function () {
};

var buildOp = function (text, op, func) {
    return {
        text: text, op: op, click: function () {
            console.log('clicked!' + text);
            calc.result = func(calc.result, +calc.userinput);
            calc.lastoperation = func;
            calc.lastinput = +calc.userinput;
            console.log('userinput:' + calc.userinput);
            calc.userinput = null;
            console.log('total:' + calc.result);
        }
    };
};

var operations = [
     {
         text: 'equals', op: '=', click: function () {
             calc.result = lastoperation(calc.result, +calc.lastinput);
         }
     },
        buildOp('add', '+', function (t, v) { return t + v; }),
        buildOp('subtract', '-', function (t, v) { return t - v; }),
        buildOp('multiply', '*', function (t, v) { return t * v; }),
        buildOp('divide', '/', function (t, v) { return t / v; }),
        {
            text: 'clear', op: 'esc', click: function () {
                calc.result = 0;
                calc.lastoperation = function () { };
                calc.userinput = null;
            }
        }
];
calc.operations = operations;
calc.checkkey = function (event,model) {
    var operation = $.grep(calc.operations, function (e, i) {
        return e.op.charCodeAt(0) === event.which;
    });
    var found = operation.length > 0 ? operation[0] : null;
    
    if (found !== null && found) {
        console.log('found!');
        event.preventDefault();
        found.click();
    } else {
        return true;
    }
};
var rivetModel = rivets.bind(el, RivetModel);
//rivetModel.publish();