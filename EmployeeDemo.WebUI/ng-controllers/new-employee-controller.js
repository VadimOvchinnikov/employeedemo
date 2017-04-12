var employeeModule = angular.module("newEmployeeModule", []);

employeeModule.controller("newEmployeeController", function ($scope, $http, $location) {
    $scope.create = function () {
        var data = JSON.stringify({
                Name: $scope.employee.firstName + " " + $scope.employee.lastName,
                EmploymentDate: $scope.employee.employmentDate,
                Rate: $scope.employee.rate,
                JobTitle: $scope.employee.jobTitle
        });

        $http.post("/api/Employees", data, {
                headers: { "Content-Type": "application/json" }
            }).then(function () {
                $location.path("/");
        });
    }
});