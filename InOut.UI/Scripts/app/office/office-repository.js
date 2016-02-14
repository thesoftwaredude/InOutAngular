officeModule.factory('officeRepository', function ($resource) {
    return {
        get: function () {
            return $resource('/api/office').query();
        }
    }
});