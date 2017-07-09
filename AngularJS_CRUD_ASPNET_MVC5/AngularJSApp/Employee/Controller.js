//employee controller 
myapp.controller('employee-controller', function ($scope, employeeService) {

    //Loads all Employee records when page loads
    loadEmployees();

    function loadEmployees() {

        var EmployeeRecords = employeeService.getAllEmployees();

        EmployeeRecords.then(function (d) {
            //success
            $scope.Employees = d.data;

        },
        function () {
            alert("Error occured while fetching employee list...");
        });
    }
});
