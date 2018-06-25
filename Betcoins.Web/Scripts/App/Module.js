angular
    .module('betcoins', [
        'ngRoute',
        'socialLogin',
        'LocalStorageModule',
        'betcoins.home.init',
        'betcoins.home.index',
        'betcoins.shared.login',
        'betcoins.service.shared.common'
    ])
    .config([
        '$routeProvider',
        function ($routeProvider) {
            $routeProvider.when('/', {
                templateUrl: '/Home/Index',
                controller: 'homeIndexController',
                caseInsensitiveMatch: true
            });
            $routeProvider.otherwise({
                redirectTo: '/'
            });
        }
    ])
    .config([
        'socialProvider',
        function (socialProvider) {
            socialProvider.setFbKey({ appId: "164256900930430", apiVersion: "v2.4" });
        }
    ]);
