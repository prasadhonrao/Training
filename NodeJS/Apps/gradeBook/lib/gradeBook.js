var gradeBook = {

    _grades : [],

    addGrade : function(newGrade) {
        this._grades.push(newGrade);
    },

    totalGradeCount : function() {
        return this._grades.length;
    },

    getAverage : function() {
        var total = 0;
        for (var index = 0; index < this._grades.length; index++) {
            total += this._grades[index];
        }
        return total / this._grades.length;
    },

    reset : function() {
        this._grades = [];
    },

    getLetterGrade : function() {
        var avg = this.getAverage();
        if (avg >= 90 && avg <= 100) {
            return 'A'
        } else {
            return 'F'
        }
    }
};

exports.gradeBook = gradeBook;