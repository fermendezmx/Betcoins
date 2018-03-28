angular
    .module('betcoins', [
        'ngRoute',
        'betcoins.home.init',
        'betcoins.home.index'
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
    ]);
