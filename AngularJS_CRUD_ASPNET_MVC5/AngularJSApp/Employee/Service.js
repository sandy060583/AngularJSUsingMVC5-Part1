//Service to get data from employee mvc controller 
myapp.service('employeeService', function ($http) {

    this.getAllEmployees = function () {

        return $http.get("/Employee/GetEmployee");
    }
});
