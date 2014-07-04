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

            this.multiplay = function (x) {
            	console.log("Multiplying " + x);
                start = start * x;
                return this;
            }

            this.equals = function (callback) {
                callback(start);
                return this;
            };
        };

 window.onload = function () {
            var calc = new Calculator(0); // default start value
            calc.add(10)
                .add(20)
                .subtract(5)
                .multiplay(2)
                .equals(function (result) {
                    console.log("Equals " + result);
                });
        }