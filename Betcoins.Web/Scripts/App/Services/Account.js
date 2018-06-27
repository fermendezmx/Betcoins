angular
    .module('betcoins.service.account', [])
    .factory('accountservice', [
        '$http',
        function ($http) {
            return {
                get: function (id) {
                    return $http({
                        method: 'GET',
                        url: '/api/account/get/' + id
                    });
                },
                post: function (data) {
                    return $http({
                        method: 'POST',
                        url: '/api/account/post',
                        data: data
                    });
                }
            };
        }
    ]);