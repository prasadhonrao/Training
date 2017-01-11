import java.io.BufferedReader;
import java.io.IOException;
import java.io.Reader;

public class CapitalizationReader extends BufferedReader {

	public CapitalizationReader(Reader in) {
		super(in);
	}

	@Override
	public String readLine() throws IOException {
		String line = super.readLine();
		if (line != null) 
			return line.toUpperCase();
		return null; 
	}
}
