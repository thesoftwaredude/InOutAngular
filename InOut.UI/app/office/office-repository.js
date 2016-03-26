officeModule.factory('officeRepository', function ($resource) {
    return {
        get: function () {
            return $resource('/api/office').query();
        },
        save: function(employee) {
            return $resource('/api/office').save(employee);
        }
    }
});