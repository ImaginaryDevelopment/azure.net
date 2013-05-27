var CalculatorCtrl = function ($scope) {
    $scope.userinput = null;
    $scope.lastinput = 0;
    $scope.lastoperation = function () {
        return 0;
    };
    $scope.total = 0;
    $scope.loaded = new Date().toString();
    var buildOp = function (text, op, func) {
        return {
            text: text, op: op, click: function () {
                $scope.total = func($scope.total, +$scope.userinput);
                $scope.lastoperation = func;
                $scope.lastinput = +$scope.userinput;
                $scope.userinput = null;
            }
        };
    };
    $scope.operations = [
         {
             text: 'equals', op: '=', click: function () {
                 $scope.total = $scope.lastoperation($scope.total, +$scope.lastinput);
             }
         },
        buildOp('add', '+', function (t, v) { return t + v; }),
        buildOp('subtract', '-', function (t, v) { return t - v; }),
        buildOp('multiply', '*', function (t, v) { return t * v; }),
        buildOp('divide', '/', function (t, v) { return t / v; }),
        {
            text: 'clear', op: 'esc', click: function () {
                $scope.total = 0;
                $scope.lastoperation = function () { };
                $scope.userinput = null;
            }
        }
    ];
};