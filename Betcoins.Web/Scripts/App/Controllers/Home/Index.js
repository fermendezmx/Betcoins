angular
    .module('betcoins.home.index', [])
    .controller('homeIndexController', [
        '$scope', '$http', 'commonService', '$location',
        function ($scope, $http, commonService, $location) {
            //#region Public Fields

            $scope.user = commonService.getBaseInfo();
            $http.defaults.headers.common['AntiXsrfToken'] = commonService.getAntiXsrf();

            //#endregion

            $scope.redirect = function () {
                $location.path('/Test');
            };
        }
    ]);