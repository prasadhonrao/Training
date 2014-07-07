var Calculator = function (start) {
        			console.log("Initial value " + start);
                    this.add = function (x) {
                    	console.log("Adding " + x);
                        start = start + x;
                        return this;
                    };

                    this.subtract = function (x) {
                    	console.log("Subtracting " + x);
                        start = start - x;
                        return this;
                    };

                    this.multiply = function (x) {
                    	console.log("Multiplying " + x);
                        start = start * x;
                        return this;
                    }

                    this.equals = function (callback) {
                        callback(start);
                        return this;
                    };
                };

new Calculator(0).add(10)
                 .add(20)
                 .subtract(5)
                 .multiply(2)
                 .equals(function (result) {
                     console.log("Equals " + result);
                 });