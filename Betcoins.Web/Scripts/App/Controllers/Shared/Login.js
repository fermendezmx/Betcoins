angular
    .module('betcoins.shared.login', [])
    .controller('sharedLoginController', [
        '$scope', 'auth0Service',
        function ($scope, auth0Service) {
            //#region Init

            if (!auth0Service.isAuthenticated()) {
                auth0Service.login();
            }

            //#endregion
        }
    ]);