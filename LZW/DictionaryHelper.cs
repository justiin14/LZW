using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZW
{
    internal class DictionaryHelper
    {
        public Dictionary <int,string> dictionary = new Dictionary<int, string>();
        int size;
        int currentIndex;
        bool method;
        bool isLru;
        int lruIndex = 256;

        public DictionaryHelper(int size, bool method, bool isLru)
        {
            this.size = size;
            this.method = method;
            this.isLru = isLru;
        }

        public void populateFixedPart()
        {
            for(int i = 0; i <= 255; i++)
            {
                var j = (char)i;
                dictionary.Add(i, Char.ToString(j));
                currentIndex = i;
            }
        }

        public void addNewSequence(string s)
        {
            if (currentIndex < size)
            {
                currentIndex++;
                dictionary.Add(currentIndex, s);
            }
            else if(currentIndex == size && isLru == true)
            {
                dictionary.Remove(lruIndex);
                dictionary.Add(lruIndex, s);
                lruIndex++;

            }
            else if(currentIndex== size && method == false)
            {
                currentIndex = 0;
                dictionary.Clear();
                populateFixedPart();
                dictionary.Add(++currentIndex, s);
            }
        }

        public void addPenultimateSequenceDecoding(string s)
        {
            if (currentIndex>256 && currentIndex < size)
            {
                string newSequence = dictionary.ElementAt(currentIndex-1).Value + s[0];
                dictionary[currentIndex-1]=newSequence;
            }
            else if (currentIndex == size && method==false)
            {
                string newSequence = dictionary.ElementAt(currentIndex - 1).Value + s[0];
                dictionary[currentIndex-1]=newSequence;
            }
        }

    }
}
