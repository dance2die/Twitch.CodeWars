using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
		public void SampleTest()
        {
	        Assert.Equal("hello", Kata.Smash(new string[] { "hello" }));
	        Assert.Equal("hello world", Kata.Smash(new string[] { "hello", "world" }));
	        Assert.Equal("hello amazing world", Kata.Smash(new string[] { "hello", "amazing", "world" }));
	        Assert.Equal("this is a really long sentence", Kata.Smash(new string[] { "this", "is", "a", "really", "long", "sentence" }));
	        Assert.Equal("", Kata.Smash(new string[] { "" }));
        }
	}

	public class Kata
	{
		public static string Smash(string[] words)
		{
			return string.Join(" ", words);
		}
	}
}
