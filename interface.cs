public interface ICalculator
{
  /// <summary>Add the doubles a and b</summary>
  /// <param name="a">the double a</param>
  /// <param name="b">the double b</param>
  /// <returns>a + b</returns>
  double Add(double a, double b);

  /// <summary>Subtract b from a</summary>
  /// <param name="a">the double a</param>
  /// <param name="b">the double b</param>
  /// <returns>a - b</returns>
  double Subtract(double a, double b);

  /// <summary>Subtract b from a</summary>
  /// <param name="a">the double a</param>
  /// <param name="b">the double b</param>
  /// <returns>a * b</returns>
  double Multiply(double a, double b);

  /// <summary>Subtract b from a</summary>
  /// <param name="a">the double a</param>
  /// <param name="b">the double b</param>
  /// <returns>a / b</returns>
  double Divide(double a, double b);
}