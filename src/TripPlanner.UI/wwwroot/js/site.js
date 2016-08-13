// Write your Javascript code.
//Start the Self Referencing Function First
(function () {

    var app = angular.module('tripPlannerApp', []);

    //add controller(use ctrl + d to formmat), define scope

    app.controller('TripController', ['$scope', function (sc, ht) {

        //Some controller Logic Here (promise?) to talk to the service


    }]);
})();