officeModule.controller("officeController", function ($scope, officeRepository) {
    $scope.office = officeRepository.get(),
    $scope.toggleStatus = function (employee) {
        employee.inOffice = !employee.inOffice;
        officeRepository.save(employee);
    };
});
