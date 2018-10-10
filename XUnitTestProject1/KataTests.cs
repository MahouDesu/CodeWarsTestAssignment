using ConsoleApp12;
using System;
using Xunit;

namespace CodeWarsKata.Tests
{
    public class KataTests
    {
        // 8 kyu
        // https://www.codewars.com/kata/simple-multiplication/train/csharp
        [Theory]
        [InlineData(60, 14390, 863400)]
        [InlineData(500, 296, 148000)]
        [InlineData(987, -342, -337554)]
        [InlineData(9, 10, 90)]
        [InlineData(5, 10, 50)]
        [InlineData(92, 41, 3772)]
        [InlineData(1, 296, 296)]
        [InlineData(3, 3, 9)]
        public void Multiply(int a, int b, int expected)
        {
            // Arrange
            Solver solver = new Solver();
            // Act
            int actual = solver.Multiply(a, b);
            // Assert
            Assert.Equal(expected, actual);

        }

        // 8 kyu
        // https://www.codewars.com/kata/a-strange-trip-to-the-market/train/csharp
        [Theory]
        [InlineData("Here's some change, tree Fiddy.", true)]
        [InlineData("Here's some change, four twenty", false)]
        [InlineData("Here's some change, 3.50.", true)]
        [InlineData("Here's some change, tree fiddy.", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void TreeFiddy(string sentence, bool expected)
        {
            // Arrange
            Solver kata = new Solver();


            // Act
            bool actual = kata.IsLochNessMonster(sentence);


            // Assert
            Assert.Equal(expected, actual);


        }

        // 8 kyu
        // https://www.codewars.com/kata/remove-string-spaces/train/csharp
        [Theory]
        [InlineData("YoUr MoTHe R I s A    Ha M S teR", "YoUrMoTHeRIsAHaMSteR")]
        [InlineData("asdfkjagi ajdg  jasdk kagj gjairgi238  i kd8", "asdfkjagiajdgjasdkkagjgjairgi238ikd8")]
        public void NoSpace(string input, string expected)
        {
            // Arrange
            Solver solver = new Solver();

            // Act
            string actual = solver.NoSpace(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        // 8 kyu
        // https://www.codewars.com/kata/makeuppercase/train/csharp
        [Theory]
        [InlineData("your father smells of elderberries", "YOUR FATHER SMELLS OF ELDERBERRIES")]
        [InlineData("wE ArE thE kNIgTS WHO say ni", "WE ARE THE KNIGHTS WHO SAY NI")]
        public void MakeUpperCase(string input, string expected)
        {
            // Arrange
            Solver solver = new Solver();

            // Act
            string actual = solver.MakeUpperCase(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        // 8 kyu
        // https://www.codewars.com/kata/my-head-is-at-the-wrong-end/train/csharp
        [Theory]
        [InlineData(new string[] { "tail", "body", "head" }, new string[] { "head", "body", "tail" })]
        public void FixTheMeerkat(string[] arr, string[] expected)
        {
            // Arrange
            Solver solver = new Solver();

            // Act
            string[] actual = solver.FixTheMeerkat(arr);

            // Assert
            Assert.Equal(expected, actual);

        }

        // 8 kyu
        // https://www.codewars.com/kata/grasshopper-terminal-game-combat-function-1/train/csharp
        [Theory]
        [InlineData(1000, 540, 460)]
        [InlineData(1245, 220, 1025)]
        public void Combat(float health, float damage, float expected)
        {
            // Arrange
            Solver solver = new Solver();

            // Act
            float actual = solver.Combat(health, damage);

            // Assert
            Assert.Equal(expected, actual);
        }

        // 8 kyu
        // https://www.codewars.com/kata/convert-boolean-values-to-strings-yes-or-no/train/csharp
        [Theory]
        [InlineData(true, "Yes")]
        [InlineData(false, "No")]
        public void boolToWord(bool word, string expected)
        {
            // Arrange
            Solver solver = new Solver();

            // Act
            string actual = solver.boolToWord(word);

            // Assert
            Assert.Equal(actual, expected);

        }

        // 8 kyu
        // https://www.codewars.com/kata/square-n-sum/train/csharp
        [Theory]
        [InlineData(new int[] {3, 6, 9 }, 126)]
        [InlineData(new int[] {5, 10, 7}, 174)]
        public void SquareSum(int[] n, int expected)
        {
            // Arrange
            Solver solver = new Solver();

            // Act
            int actual = solver.SquareSum(n);

            // Assert
            Assert.Equal(actual, expected);

        }

        // 6 kyu
        // https://www.codewars.com/kata/multiples-of-3-or-5/train/csharp
        [Theory]
        [InlineData(10, 23)]
        [InlineData(15, 60)]
        public void Solution(int value, int expected)
        {
            // Arrange
            Solver solver = new Solver();

            // Act
            int actual = solver.Solution(value);

            // Assert
            Assert.Equal(actual, expected);

        }

        // 6 kyu
        // https://www.codewars.com/kata/split-strings/train/csharp
        [Theory]
        [InlineData("qwertyui", new string[] {"qw", "er", "ty", "io"})]
        [InlineData("asdfhjkl", new string[] {"as", "df", "hj", "kl" })]
        public void Splitter(string str, string[] expected)
        {
            // Arrange
            Solver solver = new Solver();

            // Act
            string[] actual = solver.Splitter(str);

            // Assert
            Assert.Equal(actual, expected);

        }

        // 6 kyu
        // https://www.codewars.com/kata/is-a-number-prime/train/csharp
        [Theory]
        [InlineData(17, true)]
        [InlineData(15, false)]
        public void IsPrime(int n, bool expected)
        {
            // Arrange
            Solver solver = new Solver();

            // Act
            bool actual = solver.IsPrime(n);

            // Assert
            Assert.Equal(actual, expected);

        }


        // 5 kyu
        // https://www.codewars.com/kata/double-cola/train/csharp
        [Theory]
        [InlineData(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 1, "Sheldon")]
        [InlineData(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 6, "Sheldon")]
        public void WhoIsNext(string[] values, long n, string expected)
        {
            // Arrange
            Solver solver = new Solver();

            // Act
            string actual = solver.WhoIsNext(values, n);

            // Assert
            Assert.Equal(expected, actual);
        }

        // 5 kyu
        // https://www.codewars.com/kata/rgb-to-hex-conversion/train/csharp
        [Theory]
        [InlineData(0, 0, 0, "000000")]
        [InlineData(148, 0, 211, "9400D3")]
        public void RGBtoHex(int r, int g, int b, string hex)
        {
            // Arrange
            Solver rgbToHex = new Solver();

            // Act
            string actual = rgbToHex.Rgb(r, g, b);

            // Assert
            Assert.Equal(actual, hex);
        }
    }
}
