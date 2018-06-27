angular
    .module('betcoins.shared.login', [])
    .controller('sharedLoginController', [
        '$scope', '$rootScope', '$window', 'store',
        function ($scope, $rootScope, $window, store) {
            //#region Public Methods

            $rootScope.$on('event:social-sign-in-success',
                function (event, user) {
                    store.set('baseInfo', {
                        FullName: user.name,
                        Email: user.email,
                        ImageUrl: user.imageUrl,
                        UID: user.uid
                    });

                    store.set('token', user.token);
                    $window.location.href = '/';
                }
            );

            $scope.signin = function () {
                // NOP
            };

            //#endregion
        }
    ]);