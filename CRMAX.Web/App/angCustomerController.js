
app.controller("angCustomerController", function ($scope, CustomerService) {



    getCustomer();

    function getCustomer() {

        CustomerService.getCustomer()

            .success(function (cust) {

                $scope.customer = cust;

                console.log($scope.customer);

            })

            .error(function (error) {

                $scope.status = 'Unable to load customer data: ' + error.message;

                console.log($scope.status);

            });

    }




});
