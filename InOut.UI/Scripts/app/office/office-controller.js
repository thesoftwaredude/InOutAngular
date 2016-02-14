officeModule.controller("officeController", function ($scope, officeRepository) {
    $scope.office = officeRepository.get();
});