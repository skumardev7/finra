using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finra.Core
{
    public class AlphaNumericGenerator
    {
        Hashtable keyPad = new Hashtable()
        {
          { "2", "ABC" },
          { "3", "DEF" },
          { "4", "GHI" },
          { "5", "JKL" },
          { "6", "MNO" },
          { "7", "PQRS" },
          { "8", "TUV" },
          { "9", "WXYZ" },

        };

        public List<string> GetAlphaNumerics(long input)
        {
            return GetAlphaNumerics(input.ToString().ToCharArray(), 0);
        }

        public Tuple<int,List<string>> GetAlphaNumerics(long input, int pageNo, int pageSize)
        {
            var output = GetAlphaNumerics(input.ToString().ToCharArray(), 0);
            return new Tuple<int, List<string>>(output.Count, output.Skip(pageNo * pageSize).Take(pageSize).ToList());
        }

        private List<string> GetAlphaNumerics(char[] inputArray, int position)
        {
            List<string> output = new List<string>();
            for (int i = position; i < inputArray.Length; i++)
            {
                char[] localArray = (char[])inputArray.Clone();
                if (keyPad.ContainsKey(localArray[i].ToString()))
                {
                    foreach (var item in keyPad[localArray[i].ToString()].ToString().ToCharArray())
                    {
                        localArray[i] = item;
                        output.Add(String.Join("", localArray));
                        output.AddRange(GetAlphaNumerics(localArray, i + 1));
                    }
                }
            }
            return output;
        }
    }
}
