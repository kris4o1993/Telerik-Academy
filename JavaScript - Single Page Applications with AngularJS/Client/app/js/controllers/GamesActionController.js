'use strict';

app.controller('GamesActionController', ['$scope', 'notifier', 'game', 'baseServiceUrl',
     function($scope, notifier, game, baseServiceUrl) {
        $scope.createGame = function () {
            game.create()
            .then(function (data) {
                    notifier.success('Game created successfully!');
                    
                
                    window.location = '#/play?gameId=' + data.Id;
                },
                function (error) {
                    if (error.status === '401') {
                        notifier.error('You must be logged in to create a game!');
                    }
                    else if (error.data.Message) {
                        notifier.error(error.data.Message);
                    }
                    else {
                        notifier.error('Sorry! Could not create a game! Try again later!');
                    }
                });
        }

        $scope.joinGame = function () {
            game.join()
            .then(function (data) {
                notifier.success('You are joined to play with: ' + data.FirstPlayerName);
                
                window.location = '#/play?gameId=' + data.Id;
            }, function (error) {
                notifier.error(error);
            });
        }
}]);