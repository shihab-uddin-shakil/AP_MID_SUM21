app.controller("orderdetail",function($scope,$http,ajax){
    ajax.get("https://localhost:44335/api/Order/GetAll",success,error);
    function success(response){
      $scope.order=response.data;
    }
    function error(error){

    }

});
