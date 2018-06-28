angular
    .module('betcoins.shared.login', [])
    .controller('sharedLoginController', [
        '$scope', 'auth0Service',
        function ($scope, auth0Service) {
            //#region Init

            auth0Service.login();

            //#endregion
        }
    ]);