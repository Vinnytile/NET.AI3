using System.Text.RegularExpressions;

namespace RegularExpression {

  public class StringValidator {

    /// <summary>
    /// Validates a string against a predefined pattern.
    /// </summary>
    /// <param name="input">The input string to validate.</param>
    /// <param name="maxLength">The maximum length of the string.</param>
    /// <returns>True if the string matches the pattern and its length is less than maxLength, false otherwise.</returns>
    public static bool ValidateString(string input, int maxLength) {
      string pattern = $"^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!\"#$%&'()*+,-./:;<=>?@[\\]^_`{{|}}~])[^\\s]{{1,{maxLength}}}$";
      return Regex.IsMatch(input, pattern);
    }
  }
}