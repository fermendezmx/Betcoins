angular
    .module('betcoins', [
        'ngRoute',
        'auth0.lock',
        'socialLogin',
        'angular-jwt',
        'angular-storage',
        'betcoins.home.init',
        'betcoins.home.index',
        'betcoins.shared.login',
        'betcoins.service.shared.common',
        'betcoins.service.shared.auth0'
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
        'lockProvider',
        function (lockProvider) {
            // Configure Auth0 Lock instance
            // Read more about configuration here:
            // https://auth0.com/docs/libraries/lock/v11
            lockProvider.init({
                domain: 'betcoins-dev.auth0.com',
                clientID: 'Q9L35ZyZqu3CdYsjw9rMUwgA6dxonBZ6',
                options: {
                    autoclose: true,
                    auth: {
                        responseType: 'token id_token',
                        audience: 'https://betcoins-dev.auth0.com/userinfo',
                        params: {
                            scope: 'openid profile email'
                        }
                    }
                }
            });
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
    ])
    .run([
        'auth0Service',
        function (auth0Service) {
            auth0Service.setup();
        }
    ]);
