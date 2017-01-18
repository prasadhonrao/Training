public class Calculator {
	public int Add(int first, int second) {
		return first + second;
	}

	public int Multiply(int first, int second) {
		return first * second;
	}

	public int Divide(int first, int second) throws ArithmeticException {
		if (second == 0) {
			throw new ArithmeticException("Cant divide by zero");
		}
		return first / second;
	}
}
