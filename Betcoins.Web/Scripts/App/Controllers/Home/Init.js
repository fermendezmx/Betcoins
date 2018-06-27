angular
    .module('betcoins.home.init', [])
    .controller('homeInitController', [
        '$rootScope', 'auth0Service',
        function ($rootScope, auth0Service) {
            //#region Init

            if (!auth0Service.isAuthenticated()) {
                auth0Service.login();
            }

            //#endregion
        }
    ]);