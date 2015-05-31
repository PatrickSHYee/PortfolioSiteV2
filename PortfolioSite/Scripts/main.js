/*
    Author:  Patrick S. Yee
    Description:  Javascript that are using AJAX, AngularJS, and other javascript framework.
*/

/* JavaScript module: Start */
$(document).ready(function () {
    //  For mobile and smaller window sizes
    $('span.menu').click(function () {
        $('.navigate').slideToggle('slow', function () { });
    });
});

/* Angular module: Start */
angular.module('mainApp', [
    'mainApp.ctrl.home',
    'mainApp.crtl.projects,'
]).config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.when('/', {
        templateUrl: '/Home/Home',
        controller: 'LandingController',
    });
    $routeProvider.when('/Projects', {
        templateUrl: '/Home/Projects',
        controller: 'ProjectsController',
    });
    $routeProvider.otherwise({ redirectto: '/' });

    // specify HTML5 mode or HashBang syntax
    //$locationProvider.html5Mode(false).hashPrefix('!');
}])