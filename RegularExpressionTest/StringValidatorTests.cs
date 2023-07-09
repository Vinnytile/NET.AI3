namespace RegularExpressionTest {

  [TestFixture]
  public class StringValidatorTests {
    [Test]
    public void TestTooShortInput() {
      var input = "A1!";
      var result = StringValidator.ValidateString(input, 5);
      Assert.That(result, Is.False);
    }

    [Test]
    public void TestTooLongInput() {
      var input = "Abcdefg12345!";
      var result = StringValidator.ValidateString(input, 10);
      Assert.That(result, Is.False);
    }

    [Test]
    public void TestMatchingLengthInput() {
      var input = "Abc123!";
      var result = StringValidator.ValidateString(input, 7);
      Assert.That(result, Is.True);
    }

    [Test]
    public void TestMissingUpperCase() {
      var input = "abcdefg123!";
      var result = StringValidator.ValidateString(input, 11);
      Assert.That(result, Is.False);
    }

    [Test]
    public void TestMissingLowerCase() {
      var input = "ABCDEFG123!";
      var result = StringValidator.ValidateString(input, 11);
      Assert.That(result, Is.False);
    }

    [Test]
    public void TestMissingSpecialCharacter() {
      var input = "Abcdefg123";
      var result = StringValidator.ValidateString(input, 10);
      Assert.That(result, Is.False);
    }

    [Test]
    public void TestMissingDigit() {
      var input = "Abcdefg!";
      var result = StringValidator.ValidateString(input, 8);
      Assert.That(result, Is.False);
    }

    [Test]
    public void TestExcessWhitespaceCharacters() {
      var input = "Abc 123!";
      var result = StringValidator.ValidateString(input, 8);
      Assert.That(result, Is.False);
    }

    [Test]
    public void TestWhitespaceAtStart() {
      var input = " Abc123!";
      var result = StringValidator.ValidateString(input, 8);
      Assert.That(result, Is.False);
    }

    [Test]
    public void TestWhitespaceAtEnd() {
      var input = "Abc123! ";
      var result = StringValidator.ValidateString(input, 8);
      Assert.That(result, Is.False);
    }
  }
}