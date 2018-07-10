angular
    .module('betcoins.home.index', [])
    .controller('homeIndexController', [
        '$scope', '$location', '$http', 'commonService',
        function ($scope, $location, $http, commonService) {
            //#region Init

            $http.defaults.headers.common['AntiXsrfToken'] = commonService.getAntiXsrf();

            //#endregion
        }
    ]);