var app = angular.module("myApp", ["ngRoute", "employeesModule", "newEmployeeModule"]);
app.config(
    function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "/ng-views/employees.html",
                controller: 'employeesController'
            })
            .when("/new", {
                templateUrl: "/ng-views/new-employee.html",
                controller: 'newEmployeeController'
            })
            .otherwise({
                redirectTo: "/"
            });

        $locationProvider.html5Mode(true);
    });
