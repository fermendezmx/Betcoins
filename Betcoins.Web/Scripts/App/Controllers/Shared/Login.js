angular
    .module('betcoins.shared.login', [])
    .controller('sharedLoginController', [
        '$scope', '$rootScope', '$window', 'localStorageService',
        function ($scope, $rootScope, $window, localStorageService) {
            //#region Public Methods

            $rootScope.$on('event:social-sign-in-success',
                function (event, user) {
                    localStorageService.set('baseInfo', {
                        FullName: user.name,
                        Email: user.email,
                        ImageUrl: user.imageUrl,
                        UID: user.uid
                    });

                    localStorageService.set('token', user.token);
                    $window.location.href = '/';
                }
            );

            $scope.signin = function () {
                // NOP
            };

            //#endregion
        }
    ]);