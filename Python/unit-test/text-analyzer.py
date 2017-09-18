import os
import unittest

def analyze_text(filename):
    with open(filename, "r") as f:
        return sum(1 for _ in f)

class TextAnalysisTests(unittest.TestCase):
    
    def setUp(self):
        self.filename = "text_analysis_test_file.txt"
        with open(self.filename, "w") as f:
            f.write("File created with some random text!")
    
    def tearDown(self):
        try:
            os.remove(self.filename)
        except:
            pass
    
    def test_function_runs(self):
        analyze_text(self.filename)
    
    def test_line_count(self):
        self.assertEqual(analyze_text(self.filename), 1)

if (__name__ == '__main__'):
    unittest.main()
