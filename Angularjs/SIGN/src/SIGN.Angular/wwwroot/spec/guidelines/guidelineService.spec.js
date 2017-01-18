describe('Guideline service', function () {
    var guidelineService = {};
    var guideline1Name = 'Early management of patients with a head injury';
    var guideline2Name = 'Early management of patients with asthma';

    var guideline1 = '{"id": 1,"number": 110,"name": "' + guideline1Name + '","author": "GavinHickford","status": 3,"datePublished": "2009-05-01T00:00:00","dateCreated": "2017-01-12T23:07:34.3831303","dateModified": "2017-01-12T23:07:34.3831303","isDirty": false,"assessments": []}';
    var guideline2 = '{"id": 2,"number": 111,"name": "' + guideline2Name + '","author": "GavinHickford","status": 3,"datePublished": "2009-05-01T00:00:00","dateCreated": "2017-01-12T23:07:34.3831303","dateModified": "2017-01-12T23:07:34.3831303","isDirty": false,"assessments": []}';

    var expectedGuidelines = JSON.parse('[' + guideline1 + ',' + guideline2 + ']');
    var newGuideline = JSON.parse('[' + guideline1 + ']');
    var $httpBackend;

    beforeEach(angular.mock.module('ngRoute'));
    beforeEach(angular.mock.module('controls'));
    beforeEach(angular.mock.module('app-guidelines'));

    beforeEach(inject(function (_$httpBackend_, _guidelineService_) {
        $httpBackend = _$httpBackend_;
        guidelineService = _guidelineService_;
    }));
    
    it('should return guidelines', function () {
        var response;
              
        $httpBackend.when('GET', '/api/guidelines')
            .respond(200, expectedGuidelines);

        guidelineService.getGuidelines()
            .then(function (data) {
                response = data;
            });

        $httpBackend.flush();

        expect(response).toEqual(expectedGuidelines);
    });

    it('should add a new guideline and return the location with guideline name', function () {
        var response;
        var expectedUrl = '/api/guidelines/' + guideline1Name;

        $httpBackend.when('POST', '/api/guidelines')
            .respond(201, expectedUrl, newGuideline);

        guidelineService.saveGuideline()
            .then(function (data) {
                response = data;
            });

        $httpBackend.flush();

        expect(response).toEqual(expectedUrl);
    });

    it('should get a guideline by id', function () {
        var response;
        $httpBackend.when('GET', '/api/guidelines/1')
            .respond(200, guideline1);

        guidelineService.getGuideline(1)
            .then(function (data) {
                response = data;
            });

        $httpBackend.flush();

        expect(response).toEqual(JSON.parse(guideline1));
    });
});