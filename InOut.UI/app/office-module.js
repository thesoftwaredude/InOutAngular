var officeModule = angular.module("officeModule", ['ngRoute', 'ngResource', 'uiSwitch']);
(function() {


    $(function() {
        $.connection.hub.logging = true;
        $.connection.hub.start();

    });

    $.connection.hub.error(function(err) {
        console.log('An error occurredL ' + err);
    });

    //officeModule.value('chat', $.connection.chat);
    //angular('officeModule').value('chat', $.connection.chat);

});



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