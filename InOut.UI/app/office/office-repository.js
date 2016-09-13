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




officeModule.factory('chat', function () {
    //$.connection.chat
    return {
        
    }
});