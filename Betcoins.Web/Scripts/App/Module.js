angular
    .module('betcoins', [
        'ngRoute',
        'auth0.lock',
        'angular-jwt',
        'angular-storage',
        'betcoins.home.init',
        'betcoins.home.index',
        'betcoins.shared.login',
        'betcoins.service.shared.common',
        'betcoins.service.shared.auth0',
        'betcoins.service.account'
    ])
    .config([
        '$routeProvider',
        function ($routeProvider) {
            $routeProvider.when('/', {
                templateUrl: '/Home/Index',
                controller: 'homeIndexController',
                caseInsensitiveMatch: true
            });
            $routeProvider.when('/Login', {
                templateUrl: '/Shared/Login',
                controller: 'sharedLoginController',
                caseInsensitiveMatch: true
            });
            $routeProvider.otherwise({
                redirectTo: '/'
            });
        }
    ])
    .config([
        'lockProvider', 'webConfig',
        function (lockProvider, webConfig) {
            // Configure Auth0 Lock instance
            // Read more about configuration here:
            // https://auth0.com/docs/libraries/lock/v11
            lockProvider.init({
                domain: webConfig.auth0Domain,
                clientID: webConfig.auth0ClientId,
                options: {
                    allowedConnections: ['facebook', 'github', 'twitter'],
                    allowSignUp: false,
                    container: 'auth0-login-container',
                    auth: {
                        responseType: 'token id_token',
                        audience: 'https://' + webConfig.auth0Domain + '/userinfo',
                        redirect: false,
                        params: {
                            scope: 'openid profile email'
                        }
                    }
                }
            });
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
            $httpProvider.interceptors.push('authInterceptor');
        }
    ])
    .constant("webConfig", window.webConfig)
    .run([
        'auth0Service',
        function (auth0Service) {
            auth0Service.setup();
        }
    ]);
