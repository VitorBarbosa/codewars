
public class Prime
{
  public static bool IsPrime(int n)
  {
    if (n <= 0) return false;
    if (n == 2) return true;
    var isPrime = true;
    for (int i = 2; i <= System.Math.Sqrt(n); i++) {
      if (n % i == 0) {
        return false;
      }
    }
    return isPrime;
  }
}