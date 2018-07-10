angular
    .module('betcoins.account.detail', [])
    .controller('accountDetailController', [
        '$scope', 'commonService',
        function ($scope, commonService) {
            //#region Public Fields

            $scope.user = commonService.getBaseInfo();

            //#endregion
        }
    ]);