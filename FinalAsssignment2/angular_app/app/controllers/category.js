app.controller("category",function($scope,ajax){
    ajax.get(API_ROOT+"api/Category/GetAll",function(response){
      $scope.category = response.data;
    },
    function(error){

    });
});
