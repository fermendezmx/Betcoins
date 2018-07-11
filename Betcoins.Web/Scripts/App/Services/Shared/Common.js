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
                    return store.get('id_token');
                },
                getAntiXsrf: function () {
                    return $('input[name="__RequestVerificationToken"]').val();
                }
            };
        }
    ]);