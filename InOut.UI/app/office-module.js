var officeModule = angular.module("officeModule", ['ngRoute', 'ngResource', 'uiSwitch'])
//    .directive('onload',function() {
//        return function(scope, element, attrs) {
//            setTimeout(function doWork() {
//                $(':checkbox').iphoneStyle({
//                    checkedLabel: 'In',
//                    uncheckedLabel: 'Out'
//                });
//            }, 0);
//        };
//    })
//    .config(function ($routeProvider, $locationProvider) {
//        $routeProvider.when('/Office/All', { templateUrl: '/templates/all.html', controller: 'OfficeController' });
//        $routeProvider.when('/Office/In', { templateUrl: '/templates/in.html', controller: 'OfficeController' });
//        $routeProvider.when('/Office/Out', { templateUrl: '/templates/out.html', controller: 'OfficeController' });
//        $locationProvider.html5Mode(true);
//    });