import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class IO {

	public static void main(String[] args) {

		CreateFile();
		DeleteFile();
		// MoveFile();

		ReadFileCharacterByCharacter(); // FileReader
		ReadFileLineByLine(); // BufferedReader

		CreateFileUsingFileWriter();
		CreateFileUsingPrintWriter();

		ReadFileUsingCustomReader();
	}

	private static void CreateFile() {
		Path p = Paths.get("D:\\test.txt");
		try {
			if (!Files.exists(p))
				Files.createFile(p);
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	private static void DeleteFile() {
		Path p = Paths.get("D:\\test.txt");
		try {
			Files.deleteIfExists(p);
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	private static void MoveFile() {
		Path source = Paths.get("D:\\numbers.txt");
		Path target = Paths.get("D:\\temp\\numbers.txt");

		try {
			Files.move(source, target);
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	private static void ReadFileUsingCustomReader() {
		FileReader reader = null;
		try {
			reader = new FileReader("D:\\Numbers.txt");

			CapitalizationReader capReader = new CapitalizationReader(reader);
			String line;
			try {
				while ((line = capReader.readLine()) != null) {
					System.out.println(line);
				}
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} finally {
				if (capReader != null) {
					try {
						capReader.close();
					} catch (IOException e) {
						e.printStackTrace();
					}
				}
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} finally {
			if (reader != null) {
				try {
					reader.close();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
	}

	private static void CreateFileUsingPrintWriter() {
		FileWriter writer = null;
		PrintWriter pWriter = null;
		try {
			writer = new FileWriter("D:\\newNumbers2.txt");
			pWriter = new PrintWriter(writer);
			pWriter.println("Created using PrintWriter");
		} catch (IOException e) {
			e.printStackTrace();
		} finally {
			if (pWriter != null) {
				pWriter.close();
			}
		}

	}

	private static void CreateFileUsingFileWriter() {
		FileWriter writer = null;
		try {
			writer = new FileWriter("D:\\newNumbers.txt");
			writer.write("Created using File Writer");
		} catch (IOException e) {
			e.printStackTrace();
		} finally {
			if (writer != null) {
				try {
					writer.close();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}

	}

	private static void ReadFileLineByLine() {
		FileReader reader = null;
		try {
			reader = new FileReader("D:\\Numbers.txt");

			BufferedReader bReader = new BufferedReader(reader);
			String line;
			try {
				while ((line = bReader.readLine()) != null) {
					System.out.println(line);
				}
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} finally {
				if (bReader != null) {
					try {
						bReader.close();
					} catch (IOException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} finally {
			if (reader != null) {
				try {
					reader.close();
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		}

	}

	private static void ReadFileCharacterByCharacter() {
		FileReader reader = null;
		try {
			reader = new FileReader("D:\\Numbers.txt");

			int c = -1;

			try {
				while ((c = reader.read()) != -1) {
					char ch = (char) c;
					System.out.print(ch);
				}
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}

		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} finally {
			if (reader != null) {
				try {
					reader.close();
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		}
	}

}
