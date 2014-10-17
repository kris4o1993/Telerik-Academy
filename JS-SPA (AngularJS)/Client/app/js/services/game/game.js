'use strict';

app.factory('game', ['$http', '$q', 'authorization', 'baseServiceUrl', 
    function ($http, $q, authorization, baseServiceUrl) {
        var createGameUrl = baseServiceUrl + '/api/game/create';
        var joinGameUrl = baseServiceUrl + '/api/game/join';
        var gameStatusUrl = baseServiceUrl + '/api/game/status';
        var playGameUrl = baseServiceUrl + '/api/game/play';
    
        return {
            create: function createGame () {
                var deffered = $q.defer();
                var authHeader = authorization.getAuthorizationHeader();
                
                $http.post(createGameUrl, null, {headers: authHeader})
                    .then(function (data, status, headers, config) {
                        deffered.resolve(data.data);
                    }, function (error) {
                        deffered.reject(error);
                    });
                
                return deffered.promise;
            },
            join: function joinGame () {
                var deffered = $q.defer();
                var authHeader = authorization.getAuthorizationHeader();
                
                $http.post(joinGameUrl, null, {headers: authHeader})
                    .then(function (data, status, headers, config) {
                        deffered.resolve(data.data);
                    }, function (error) {
                        deffered.reject(error);
                    });
                
                return deffered.promise;    
            },
            play: function playGame (move, gameId) {
                move.column = parseInt(move.column);
                move.row = parseInt(move.row);
                console.log('Playing game from service...', move, gameId);
                
                var deffered = $q.defer();
                var authHeader = authorization.getAuthorizationHeader();
                
                $http.post(playGameUrl + "?GameId=" + gameId + "&Row=" + parseInt(move.row) + "&Col=" + parseInt(move.column), 
                           null, {headers: authHeader})
                    .then(function (data, status, headers, config) {
                        deffered.resolve(data.data);
                    }, function (error) {
                        deffered.reject(error);
                    });
                
                return deffered.promise;
            },
            status: function gameStatus (id) {
                var deffered = $q.defer();
                var authHeader = authorization.getAuthorizationHeader();
                
                $http.get(gameStatusUrl + '?gameId=' + id, {headers: authHeader})
                .then(function (data, status, headers, config) {
                    deffered.resolve(data.data);
                }, function (error) {
                    deffered.reject(error);
                });
                
                return deffered.promise;
            }
        }
    }]);