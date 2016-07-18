import static org.junit.Assert.*;

import org.junit.*;

public class CalculatorTest {

	Calculator calc;
	
	@BeforeClass
	public static void setUpClass(){
		System.out.println("Before Class");
	}
	
	@AfterClass
	public static void tearDownClass(){
		System.out.println("After Class");
	}
	
	@Before
	public void setUp() {
		calc = new Calculator();
		System.out.println("calc instance created");
	}
		
	@Test
	public void AddTest(){
		int result = calc.Add(5, 5);
		assertEquals(10, result);
	}
	
	@Test
	public void MultiplicationTest(){
		int result = calc.Multiply(5, 5);
		assertEquals(25, result);
	}
	
	@Test
	public void DivideTest(){
		int result = calc.Divide(15, 5);
		assertEquals(3, result);
	}
	
	@Test(expected=ArithmeticException.class)
	public void DivideByZeroTest(){
		int result = calc.Divide(15, 0);
		assertEquals(3, result);
	}
	
	@After
	public void tearDown() {
		System.out.println("After!");
	}
}
