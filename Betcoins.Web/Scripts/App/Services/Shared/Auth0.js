angular
    .module('betcoins.service.shared.auth0', [])
    .service('auth0Service', [
        'store', 'lock',
        function (store, lock) {
            return {
                login: function () {
                    // Display the Lock widget using the
                    // instance initialized in the Module.js config
                    lock.show();
                },
                logout: function () {
                    // Remove token and expiry time from localStorage
                    store.remove('access_token');
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

                            // Save token and expiration to localStorage
                            store.set('access_token', result.idToken);
                            store.set('expires_at', expiresAt);
                            lock.hide();
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