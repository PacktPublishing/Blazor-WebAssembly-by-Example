var bweInterop = {};

bweInterop.setLocalStorage = function (key, data) {
    localStorage.setItem(key, data);
}

bweInterop.getLocalStorage = function (key) {
    return localStorage.getItem(key);
}
