namespace FizzBuzz.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ThreeShouldReturnFizz()
    {
        FizzBuzz fb = new();
        Assert.That(fb.TransformNumber(3), Is.EqualTo("Fizz"));
    }

    [Test]
    public void FiveShouldReturnBuzz()
    {
        FizzBuzz fb = new();
        Assert.That(fb.TransformNumber(5), Is.EqualTo("Buzz"));
    }
}