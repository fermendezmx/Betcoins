angular
    .module('betcoins', [
        'ngRoute',
        'auth0',
        'socialLogin',
        'LocalStorageModule',
        'angular-jwt',
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
        'authProvider',
        function (authProvider) {
            authProvider.init({
                domain: 'betcoins-dev.auth0.com',
                clientID: 'Q9L35ZyZqu3CdYsjw9rMUwgA6dxonBZ6',
                loginUrl: '/login'
            });
        }
    ])
    .run([
        'auth',
        function (auth) {
            auth.hookEvents();
        }
    ])
    .config([
        'socialProvider',
        function (socialProvider) {
            socialProvider.setFbKey({ appId: "164256900930430", apiVersion: "v2.4" });
        }
    ])
    .config([
        '$httpProvider', 'jwtOptionsProvider',
        function ($httpProvider, jwtOptionsProvider) {
            jwtOptionsProvider.config({
                tokenGetter: ['commonService', function (commonService) {
                    return commonService.getToken();
                }]
            });

            $httpProvider.interceptors.push('jwtInterceptor');
        }
    ]);
