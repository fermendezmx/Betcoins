angular
    .module('betcoins.service.shared.common', [])
    .service('commonService', [
        'store',
        function (store) {
            return {
                getBaseInfo: function () {
                    return store.get('baseInfo');
                },
                getToken: function () {
                    return store.get('token');
                }
            };
        }
    ]);