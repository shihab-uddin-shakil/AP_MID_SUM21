app.controller("products",function($scope,$http,ajax){
    ajax.get("https://localhost:44323/api/Department/GetAll",success,error);
    function success(response){
      $scope.department=response.data;
    }
    function error(error){

    }

});
