var book = require('../lib/gradeBook').gradeBook

exports["setUp"] = function(callback) {
    book.reset();
    callback();
}

exports["Can add new grade"] = function(test) {

    book.addGrade(50)
    book.addGrade(80)

    test.equal(book.totalGradeCount(), 2)

    test.done();
}

exports["Can average grades"] = function(test) {

    book.addGrade(40)
    book.addGrade(80)

    var average = book.getAverage();

    test.equal(average, 60)

    test.done();
}


exports["Can compute letter grade A"] = function(test) {

    book.addGrade(90)
    book.addGrade(100)

    var result = book.getLetterGrade();
    test.equal(result, 'A')
    test.done();
}