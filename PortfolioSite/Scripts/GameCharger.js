
var app = angular.module('GameChanger', []);

app.controller('ProjectController', function () {
    this.section = 'default';
    console.log("crtl");

    $scope.setSection = function (newSection) {
        console.log("setting");
        this.section = newSection;
    };

    $scope.isSection = function (sectionName) {
        return this.section === sectionName;
    }
});