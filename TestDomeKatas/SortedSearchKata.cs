﻿using System;
using System.Linq;

namespace TestDomeKatas
{
    /// <summary>
    /// Implement function CountNumbers that accepts a sorted array (ascending order) of unique integers and,
    /// efficiently with respect to time used, counts the number of array elements that are less than the parameter lessThan.
    /// For example, SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4) should return 2 because there are two array elements less than 4.
    /// </summary>
    public class SortedSearchKata
    {
        public static int CountNumbersVersionOne(int[] sortedArray, int lessThan)
        {
            if (sortedArray == null || !sortedArray.Any()) return 0;
            return Array.FindAll(sortedArray, x => x < lessThan).Length;
        }

        public static int CountNumbersVersionTwo(int[] sortedArray, int lessThan)
        {
            if (sortedArray == null || !sortedArray.Any()) return 0;
            return sortedArray.TakeWhile(x => x < lessThan).Count();
        }

        public static int CountNumbersVersionThree(int[] sortedArray, int lessThan)
        {
            if (sortedArray == null || !sortedArray.Any()) return 0;
            var exists = TryFind(sortedArray, lessThan, out var position);
            return exists ? position : position + 1;
        }

        private static bool TryFind(int[] sortedArray, int value, out int position)
        {
            position = Array.BinarySearch(sortedArray, value);
            if (position >= 0) return true;
            position = ~position - 1;
            return false;
        }
    }
}
