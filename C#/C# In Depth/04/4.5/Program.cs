using System;
class MainClass {
  public static void Main (string[] args) {
    int? parsed = TryParse("Not valid");
    if (parsed != null)
    {
      Console.WriteLine("Parsed to {0}", parsed.Value);
    }
    else
    {
      Console.WriteLine("Could not parse");
    }
  }
  
  static int TryParse(string text)
  {
    int ret;
    if (int.TryParse(text, out ret))
    {
      return ret;
    }
    else
    {
      return null;
    }
  }
}