app.controller("neworder",function($scope,ajax,$location){

  ajax.get(API_ROOT+"api/Category/GetAll",
  function(resp){
    $scope.category = resp.data;
  },
  function(err){

  });
  ajax.get("https://localhost:44335/api/Product/GetAll",success,error);
  function success(response){
    $scope.product=response.data;
  }
  function error(error){

  }

  $scope.neworder = function(p){
    var p= {
      Id:0,
      Type:$scope.Type,
        Name:$scope.Name,
        Price:$scope.Price,
        Quantity:$scope.Quantity,
        User_Id:8,
        Date:$scope.Date
    };
    ajax.post(API_ROOT+"api/Order/Add",p,
    function(response){

    },
    function(err){

    });
  };
});
