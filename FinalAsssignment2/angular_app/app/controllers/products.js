app.controller("products",function($scope,$http,ajax){
    ajax.get("https://localhost:44335/api/Product/GetAll",success,error);
    function success(response){
      $scope.products=response.data;
    }
    function error(error){

    }

});
