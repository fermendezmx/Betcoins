angular
    .module('betcoins.home.index', [])
    .controller('homeIndexController', [
        '$scope', 'commonService',
        function ($scope, commonService) {
            //#region Public Fields

            $scope.user = commonService.getBaseInfo();

            //#endregion
        }
    ]);