angular
    .module('betcoins.service.shared.common', [])
    .service('commonService', [
        'localStorageService',
        function (localStorageService) {
            return {
                getBaseInfo: function () {
                    return localStorageService.get('baseInfo');
                },
                getToken: function () {
                    return localStorageService.get('token');
                }
            };
        }
    ]);