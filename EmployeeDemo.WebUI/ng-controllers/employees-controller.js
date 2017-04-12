var employeeModule = angular.module("employeesModule", []);

employeeModule.controller("employeesController", function ($scope, $http) {
    $scope.refresh = function () {
        $http.get("/api/Employees")
            .then(function (response) {
                $scope.employees = response.data;
            });
    }

    $scope.refresh();

    $scope.delete = function (id) {
        $http.delete("/api/Employees/" + id)
            .then(function () {
                $scope.refresh();
            });
    }
});