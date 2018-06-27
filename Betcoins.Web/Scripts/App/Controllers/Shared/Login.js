angular
    .module('betcoins.shared.login', [])
    .controller('sharedLoginController', [
        '$scope', '$rootScope', '$window', 'store',
        function ($scope, $rootScope, $window, store) {
            //#region Public Methods

            $scope.signin = function () {
                // NOP
            };

            //#endregion
        }
    ]);