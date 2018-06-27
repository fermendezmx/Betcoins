angular
    .module('betcoins.service.shared.auth0', [])
    .service('auth0Service', [
        'store', 'lock', 'accountservice',
        function (store, lock, accountservice) {
            return {
                login: function () {
                    // Display the Lock widget using the
                    // instance initialized in the Module.js config
                    lock.show();
                },
                logout: function () {
                    // Remove tokens and expiry time from localStorage
                    store.remove('access_token');
                    store.remove('id_token');
                    store.remove('expires_at');
                    $location.path('/');
                },
                setup: function () {
                    // Uncomment not using HTML5Mode
                    // lock.interceptHash();

                    lock.on('authenticated', function (result) {
                        if (result && result.accessToken && result.idToken) {
                            // Set the time that the access_token will expire
                            var expiresAt = JSON.stringify(
                                result.expiresIn * 1000 + new Date().getTime()
                            );

                            // Save tokens and expiration to localStorage
                            store.set('access_token', result.accessToken);
                            store.set('id_token', result.idToken);
                            store.set('expires_at', expiresAt);

                            lock.getProfile(result.accessToken, function (error, profile) {
                                if (profile) {
                                    var account = {
                                        AccountId: profile.sub,
                                        Email: profile.email,
                                        FirstName: profile.given_name,
                                        LastName: profile.family_name,
                                        FullName: profile.name,
                                        NickName: profile.nickname,
                                        Picture: profile.picture
                                    };

                                    accountservice.post(account)
                                        .then(function (result) {
                                            store.set('baseInfo', result.data);
                                        });
                                }

                                lock.hide();
                            });
                        }
                    });

                    lock.on('authorization_error', function (err) {
                        console.log(err);
                    });
                },
                isAuthenticated: function () {
                    // Check whether the current time is
                    // past the access_token's expiry time
                    var expiresAt = JSON.parse(store.get('expires_at'));
                    return new Date().getTime() < expiresAt;
                }
            };
        }
    ]);