'use strict';

app.controller('PlayGameController', ['$scope', '$http', '$routeParams', 'notifier', 'baseServiceUrl', 'game', 
    function ($scope, $http, $routeParams, notifier, baseServiceUrl, game) {
        var gameId = $routeParams.gameId;
        
        $scope.play = function (move) {
            game.play(move, gameId)
            .then(function (data) {
                $scope.gameState = data.State;
                $scope.board = data.Board;
            }, function (error) {
                notifier.error(error);
            });
        }

        game.status(gameId)
        .then(function (data) {
            $scope.firstPlayerName = data.FirstPlayerName;
            $scope.secondPlayerName = data.SecondPlayerName;
            $scope.gameState = data.State;
            $scope.board = data.Board;
        }, function (error) {
            notifier.error(error);
        });
    }]);