namespace LeetCode.Ex3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var currentLongest = 0;
            for (var i = 0; i < s.Length; i++)
            {
                for (var j = 1; i + j <= s.Length; j++)
                {
                    var sub = s.Substring(i, j);
                    if (ContainsRepeatingCharacters(sub))
                    {
                        break;
                    }

                    if (sub.Length > currentLongest)
                    {
                        currentLongest = sub.Length;
                    }
                }
            }

            return currentLongest;
        }

        private static bool ContainsRepeatingCharacters(string str)
        {
            var sub = str;
            while (sub.Length > 0)
            {
                var c = sub[0];
                sub = sub.Substring(1);
                if (sub.Contains(c))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
