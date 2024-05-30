using ProblemSolving.Problems.Arrays;
using ProblemSolving.Problems.TwoPointers;
using ProblemSolving.Problems.Stack;
using ProblemSolving.Problems.Hashmap;
using ProblemSolving.Problems.Intervals;
using ProblemSolving.DataStructures;
using ProblemSolving.Problems.LinkedLists;
using ProblemSolving.Problems;

////////////////// Is Subsequence \\\\\\\\\\\\\\\\\\
// IsSubsequence.Solution("abc", "ahbgdc");
// IsSubsequence.Solution("axc", "ahbgdc");
// IsSubsequence.Solution("", "ahbgdc");


/////// Remove Duplicates from Sorted Array \\\\\\\\\\
// RemoveDuplicatesFromSortedArray.Solution([1, 1, 2]);
// RemoveDuplicatesFromSortedArray.Solution([1, 1]);
// RemoveDuplicatesFromSortedArray.Solution([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);


//////////////// Valid Parentheses \\\\\\\\\\\\\\\\\\\\
// ValidParentheses.Solution("()");
// ValidParentheses.Solution("()[]{}");
// ValidParentheses.Solution("(]");
// ValidParentheses.Solution("(){}}{");

////////////////// Roman to Integer \\\\\\\\\\\\\\\\\\\\\\
// RomanToInt.Solution("III"); 
// RomanToInt.Solution("LVIII"); 
// RomanToInt.Solution("MCMXCIV"); 

///////////////////// Ransome Note \\\\\\\\\\\\\\\\\\\\\\\\\
// RansomNote.Solutoin("a", "b");
// RansomNote.Solutoin("aa", "ab");
// RansomNote.Solutoin("aa", "aab");

///////////////////// Word Pattern \\\\\\\\\\\\\\\\\\\\\\\\\
// WordPattern.Solution("abba", "dog cat cat dog");
// WordPattern.Solution("abba", "dog cat cat fish");
// WordPattern.Solution("aaaa", "dog cat cat dog");
// WordPattern.Solution("aaa", "aa aa aa aa");
// WordPattern.Solution("abba", "fish whoops helloworld fish");
// WordPattern.Solution("abba", "dog dog dog dog");

///////////////////// Majority Element \\\\\\\\\\\\\\\\\\\\\\
// MajorityElement.Solution3([3, 2, 3]);
// MajorityElement.Solution3([2, 2, 1, 1, 1, 2, 2]);

//////////////////////// Summary Ranges \\\\\\\\\\\\\\\\\\\\\\\
// SummaryRanges.Solution([0, 1, 2, 4, 5, 7]);
// SummaryRanges.Solution([0, 2, 3, 4, 6, 8, 9]);

/////////////////////// Linked List Cycle \\\\\\\\\\\\\\\\\\\\\\
// var linkedList1 = new LinkedList([3, 2, 0, -4]);
// var linkedList2 = new LinkedList([1, 2]);
// var linkedList3 = new LinkedList([1]);
// var linkedList4 = new LinkedList([]);
// ================
// LinkedListCycle.Solution(linkedList1.Head);
// LinkedListCycle.Solution(linkedList2.Head);
// LinkedListCycle.Solution(linkedList3.Head);
// LinkedListCycle.Solution(linkedList4.Head);

//////////////////// Merge Two Sorted Lists \\\\\\\\\\\\\\\\\\\\
// var linkedList1 = new LinkedList([1, 2, 4]);
// var linkedList2 = new LinkedList([1, 3, 4]);
// var linkedList3 = new LinkedList([]);
// var linkedList4 = new LinkedList([]);
// var linkedList5 = new LinkedList([]);
// var linkedList6 = new LinkedList([0]);
// =====================
// MergeTwoSortedLists.Solution(linkedList1.Head, linkedList2.Head);
// MergeTwoSortedLists.Solution(linkedList3.Head, linkedList4.Head);
// MergeTwoSortedLists.Solution(linkedList5.Head, linkedList6.Head);

///////////////// Best Time to Buy and Sell Stock \\\\\\\\\\\\\\\\\
// BestTimetoBuyandSellStock.Solution([7, 1, 5, 3, 6, 4]);
// BestTimetoBuyandSellStock.Solution([7, 6, 4, 3, 1]);

////////////////////// Length of Last Word \\\\\\\\\\\\\\\\\\\\\\\\\\
// LengthOfLastWord.Solution("Hello World");
// LengthOfLastWord.Solution("   fly me   to   the moon  ");
// LengthOfLastWord.Solution("luffy is still joyboy");

/////////////////// First Occurence in a string \\\\\\\\\\\\\\\\\\\\\\
// FirstOccurence.Solution("sadbutsad", "sad");
// FirstOccurence.Solution("leetcode", "leeto");
// FirstOccurence.Solution("hello", "ll");
// FirstOccurence.Solution("mississippi", "issip");

/////////////////////// Isomorphic Strings \\\\\\\\\\\\\\\\\\\\\\\\\\\\
// IsomorphicStrings.Solution("egg", "add");
// IsomorphicStrings.Solution("foo", "bar");
// IsomorphicStrings.Solution("paper", "title");
// IsomorphicStrings.Solution("badc", "baba");

/////////////////////////// Happy Number \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
// HappyNumber.Solution(19);

///////////////////////// Contains Duplicate \\\\\\\\\\\\\\\\\\\\\\\\\\\\
// ContainsDuplicate.Solution([1,2,3,1]);
// ContainsDuplicate.Solution([1,2,3,4]);
// ContainsDuplicate.Solution([1,1,1,3,3,4,3,2,4,2]);

//////////////////////////// Valid Anagram \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
// ValidAnagram.Solution("anagram", "nagaram");
// ValidAnagram.Solution("rat", "car");

//////////////////////////////// Two Sum \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
// TwoSum.Solution([2,7,11,15], 9);
// TwoSum.Solution([3,2,4], 6);
// TwoSum.Solution([3,3], 6);
// TwoSum.Solution([3,2,95,4,-3], 92);

////////////////////////////// Group Anagrams \\\\\\\\\\\\\\\\\\\\\\\\\\\\\
// GroupAnagrams.Solution(["eat","tea","tan","ate","nat","bat"]);
// GroupAnagrams.Solution([""]);
// GroupAnagrams.Solution(["a"]);

///////////////////////// Top K Frequent Elements \\\\\\\\\\\\\\\\\\\\\\\\\\
// TopKFrequentElements.Solution([1,1,1,2,2,3], 2);
// TopKFrequentElements.Solution([1], 1);

/////////////////////////// String Encode Decode \\\\\\\\\\\\\\\\\\\\\\\\\\\\
// StringEncodeDecode.Decode(StringEncodeDecode.Encode(["neet","code","love","you"])).ForEach(x=>{Console.WriteLine(x);});
// StringEncodeDecode.Decode(StringEncodeDecode.Encode(["we","say",":","yes"])).ForEach(x=>{Console.WriteLine(x);});

//////////////////////// Product of Array Except Self \\\\\\\\\\\\\\\\\\\\\\\\
// ProductOfArrayExceptSelf.Solution([1,2,3,4]);
// ProductOfArrayExceptSelf.Solution([-1,1,0,-3,3]);

///////////////////////////////// Valid Sudoku \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
// ValidSudoku.Solution(
//         [['5','3','.','.','7','.','.','.','.']
//         ,['6','.','.','1','9','5','.','.','.']
//         ,['.','9','8','.','.','.','.','6','.']
//         ,['8','.','.','.','6','.','.','.','3']
//         ,['4','.','.','8','.','3','.','.','1']
//         ,['7','.','.','.','2','.','.','.','6']
//         ,['.','6','.','.','.','.','2','8','.']
//         ,['.','.','.','4','1','9','.','.','5']
//         ,['.','.','.','.','8','.','.','7','9']]
//     );
//
// ValidSudoku.Solution(
//         [['8','3','.','.','7','.','.','.','.']
//         ,['6','.','.','1','9','5','.','.','.']
//         ,['.','9','8','.','.','.','.','6','.']
//         ,['8','.','.','.','6','.','.','.','3']
//         ,['4','.','.','8','.','3','.','.','1']
//         ,['7','.','.','.','2','.','.','.','6']
//         ,['.','6','.','.','.','.','2','8','.']
//         ,['.','.','.','4','1','9','.','.','5']
//         ,['.','.','.','.','8','.','.','7','9']]
//     );
// ValidSudoku.Solution(
//     [['7','.','.','.','4','.','.','.','.']
//     ,['.','.','.','8','6','5','.','.','.']
//     ,['.','1','.','2','.','.','.','.','.']
//     ,['.','.','.','.','.','9','.','.','.']
//     ,['.','.','.','.','5','.','5','.','.']
//     ,['.','.','.','.','.','.','.','.','.']
//     ,['.','.','.','.','.','.','2','.','.']
//     ,['.','.','.','.','.','.','.','.','.']
//     ,['.','.','.','.','.','.','.','.','.']]
//     );

//////////////////////// Longest Consecutive Sequence \\\\\\\\\\\\\\\\\\\\\\\\\
// LongestConsecutiveSequence.Solution([100,4,200,1,3,2]);
// LongestConsecutiveSequence.Solution([0,3,7,2,5,8,4,6,0,1]);

////////////////////////////////// MinStack \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
// MinStack minStack = new MinStack();
// minStack.Push(-2);
// minStack.Push(0);
// minStack.Push(-3);
// minStack.GetMin(); // return -3
// minStack.Pop();
// minStack.Top();    // return 0
// minStack.GetMin(); // return -2

////////////////////// Evaluate Reverse Polish Notation \\\\\\\\\\\\\\\\\\\\\\\\\\
// EvaluateReversePolishNotation.Solution(["2","1","+","3","*"]);
// EvaluateReversePolishNotation.Solution(["4","13","5","/","+"]);
// EvaluateReversePolishNotation.Solution(["10","6","9","3","+","-11","*","/","*","17","+","5","+"]);

////////////////////////////// Daily Temperatures \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
// DailyTemperatures.Solution([73,74,75,71,69,72,76,73]);
// DailyTemperatures.Solution([30,40,50,60]);
// DailyTemperatures.Solution([30,60,90]);

//////////////////////////////////// Car Fleet \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
CarFleet.Solution(12, [10, 8, 0, 5, 3], [2, 4, 1, 1, 3]);
CarFleet.Solution(10, [3], [3]);
CarFleet.Solution(100, [0,2,4], [4,2,1]);