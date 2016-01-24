app.factory('CustomerService', ['$http', function ($http) {



    var CustomerService = {};

    CustomerService.getCustomer = function () {

        return $http.get('/Customer/GetCustomer');

    };

    return CustomerService;



}]);
