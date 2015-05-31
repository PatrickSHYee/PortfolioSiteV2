/*
    Author:  Patrick Yee
    Description:  This Angular Controller is for the Home Controller and Index action.
*/

var LandingController = function ($scope) {
    $scope.models = {
        helloNG: "It's works!!"
    };
};

LandingController.$inject = ['$scope'];