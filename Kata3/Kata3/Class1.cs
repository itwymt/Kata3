using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace Kata3
{
    public class TestSort
    {
        [Fact]
        public void should_return_not_found_for_empty()
        {
            //act
            var result = SortArray.Chop(3, new int[] { });

            //Assert
            result.Should().Be(-1);
        }

        [Fact]
        public void should_return_not_found_for_one_unfound_element()
        {
            //act
            var result = SortArray.Chop(3, new[] { 1 });

            //assert
            result.Should().Be(-1);
        }

        [Fact]
        public void should_return_position_if_found()
        {
            //act
            var result = SortArray.Chop(1, new[] { 1 });

            //assert
            result.Should().Be(0);
        }

        [Fact]
        public void should_return_position_if_found2()
        {
            //act
            var result = SortArray.Chop(1, new[] { 1, 3, 5 });

            //assert
            result.Should().Be(0);
        }
        [Fact]
        public void should_return_position_if_found3()
        {
            //act 
            var result = SortArray.Chop(3, new[] { 1, 3, 5 });

            //assert
            result.Should().Be(1);
        }

        [Fact]
        public void should_return_position_if_found4()
        {
            //act 
            var result = SortArray.Chop(5, new[] { 1, 3, 5 });

            //assert
            result.Should().Be(2);
        }

        [Fact]
        public void should_return_not_found_if_not_found()
        {
            //act 
            var result = SortArray.Chop(0, new[] { 1, 3, 5 });

            //assert
            result.Should().Be(-1);
        }

        [Fact]
        public void should_return_not_found_if_not_found2()
        {
            //act
            var result = SortArray.Chop(2, new[] { 1, 3, 5 });

            //assert
            result.Should().Be(-1);
        }

        [Fact]
        public void should_return_not_found_if_not_found3()
        {
            //act
            var result = SortArray.Chop(4, new[] { 1, 3, 5 });

            //assert
            result.Should().Be(-1);
        }

        [Fact]
        public void should_return_not_found_if_not_found4()
        {
            //act
            var result = SortArray.Chop(6, new[] { 1, 3, 5 });

            //assert
            result.Should().Be(-1);
        }

        [Fact]
        public void should_return_position_if_found_four_elements()
        {
            //act 
            var result = SortArray.Chop(1, new int[] { 1, 3, 5, 7 });

            //assert
            result.Should().Be(0);
        }

        [Fact]
        public void should_return_position_if_found_four_elements2()
        {
            //act 
            var result = SortArray.Chop(3, new[] { 1, 3, 5, 7 });

            //assert
            result.Should().Be(1);
        }

        [Fact]
        public void should_return_position_if_found_four_elements3()
        {
            //act
            var result = SortArray.Chop(5, new[] { 1, 3, 5, 7 });

            //assert
            result.Should().Be(2);
        }

        [Fact]
        public void should_return_position_if_found_four_elements4()
        {
            //act
            var result = SortArray.Chop(7, new[] { 1, 3, 5, 7 });

            //assert
            result.Should().Be(3);
        }

        [Fact]
        public void should_return_not_found_four_elements1()
        {
            //act
            var result = SortArray.Chop(0, new[] { 1, 3, 5, 7 });

            //assert
            result.Should().Be(-1);
        }

        [Fact]
        public void should_return_not_found_four_elements2()
        {
            //act
            var result = SortArray.Chop(2, new[] { 1, 3, 5, 7 });

            //assert
            result.Should().Be(-1);
        }

        [Fact]
        public void should_return_not_found_four_elements3()
        {
            //act
            var result = SortArray.Chop(4, new[] { 1, 3, 5, 7 });

            //assert
            result.Should().Be(-1);
        }

        [Fact]
        public void should_return_not_found_four_elements4()
        {
            //act
            var result = SortArray.Chop(6, new[] { 1, 3, 5, 7 });

            //assert
            result.Should().Be(-1);
        }

        [Fact]
        public void should_return_not_found_four_elements5()
        {
            //act
            var result = SortArray.Chop(8, new[] { 1, 3, 5, 7 });

            //assert
            result.Should().Be(-1);
        }
    }

    public static class SortArray
    {
        public static int Chop(int i, int[] arr)
        {
            var result = -1;
            if (arr.Any())
            {
                var startPosition = 0;
                var endPosition = arr.Length - 1;

                if (arr[endPosition] == i)
                {
                    result = endPosition;
                }
                if (arr[startPosition] == i)
                {
                    result = startPosition;
                }

                if (i < arr[endPosition] && i > arr[startPosition])
                {
                    while (startPosition < endPosition - 1)
                    {
                        var index = (startPosition + endPosition / 2);

                        if (arr[index] == i)
                        {
                            result = index;
                            break;
                        }
                        if (arr[index] < i)
                        {
                            startPosition = index;
                        }
                        if (arr[index] > i)
                        {
                            endPosition = index;
                        }
                    }
                }
            }
            return result;

        }
    }
}
