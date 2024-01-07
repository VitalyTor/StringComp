using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using StringCompProgramm;

namespace StrinCompTests
{
	public class StringCompressionTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void TestStringCompression_SampleInput()
		{			
			string inputString = "1222311";
			string expectedOutput = "(1, 1) (3, 2) (1, 3) (2, 1)";

			string actualOutput = StrComprassionClass.CompressString(inputString);
			
			Assert.AreEqual(expectedOutput, actualOutput);
		}

		[Test]
		public void TestStringCompression_EmptyInput()
		{			
			string inputString = "";
			string expectedOutput = "";

			
			string actualOutput = StrComprassionClass.CompressString(inputString);

			
			Assert.AreEqual(expectedOutput, actualOutput);
		}

		[Test]
		public void TestStringCompression_SingleCharacterInput()
		{
			
			string inputString = "5";
			string expectedOutput = "(1, 5)";

			
			string actualOutput = StrComprassionClass.CompressString(inputString);

			
			Assert.AreEqual(expectedOutput, actualOutput);
		}

		[Test]
		public void TestStringCompression_AllSameCharacters()
		{
			
			string inputString = "44444";
			string expectedOutput = "(5, 4)";

			
			string actualOutput = StrComprassionClass.CompressString(inputString);

			
			Assert.AreEqual(expectedOutput, actualOutput);
		}

		[Test]
		public void TestStringCompression_MultipleConsecutiveCharacters()
		{
			
			string inputString = "1122334455";
			string expectedOutput = "(2, 1) (2, 2) (2, 3) (2, 4) (2, 5)";

			
			string actualOutput = StrComprassionClass.CompressString(inputString);

			
			Assert.AreEqual(expectedOutput, actualOutput);
		}
	}
}