using System;
using System.Text;

public class KataSquareDigits
{
  public static int SquareDigits(int n)
  {
    var squaredString = new StringBuilder();
    foreach(char nchar in n.ToString()) {
      var num = (int) nchar - 48;
      squaredString.Append(num * num);
    }
    return int.Parse(squaredString.ToString());
  }
}