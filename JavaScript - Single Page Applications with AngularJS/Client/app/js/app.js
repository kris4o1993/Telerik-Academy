'use strict';

var app = angular.module('myApp', ['ngRoute', 'ngResource', 'ngCookies']).
    config(['$routeProvider', function($routeProvider) {
        $routeProvider
            .when('/register', {
                templateUrl: 'views/partials/register.html',
                controller: 'SignUpController'
            })
            .when('/games', {
                templateUrl: 'views/partials/games-action.html',
                controller: 'GamesActionController'
            })
            .when('/play', {
                templateUrl: 'views/partials/play-game.html',
                controller: 'PlayGameController'
            })
            .otherwise({ redirectTo: '/games' });
    }])
    .value('toastr', toastr)
    .constant('baseServiceUrl', 'http://localhost:55713');