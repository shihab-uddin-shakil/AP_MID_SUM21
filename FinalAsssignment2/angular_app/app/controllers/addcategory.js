app.controller("addcategory",function($scope,ajax){

    $scope.addcategory = function(){
        //$scope.Name
        var c= {
          Id:0,
          Title:$scope.Title
        };
        ajax.post(API_ROOT+"api/Category/Add",c,
        function(response){

        },
        function(err){

        });
    };
});
