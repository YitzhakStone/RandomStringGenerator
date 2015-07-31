using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomStringGenerator
{
    class RandomStringGenerator
    {

        Random _random;
        CharType _charType;

        [Flags]
        public enum CharType
        {
            Number = 0x0,
            Upper = 0x1,
            Lower = 0x2
        }

        public RandomStringGenerator(CharType charType)
        {
            this. _random = new Random();
            this._charType = charType;
        }

        private char genChar(int min, int max)
        {
            return (char)this._random.Next(min, max);
        }

        private char genCharNumber()
        {
            return this.genChar(48, 57);
        }

        private char genCharUpper()
        {
            return this.genChar(65, 90);
        }

        private char genCharLower()
        {
            return this.genChar(97, 122);
        }

        private char genCharRandom()
        {

            string temp = string.Empty;

            if (this._charType.HasFlag(CharType.Number))
            {
                temp += this.genCharNumber();
            }
            if (this._charType.HasFlag(CharType.Upper))
            {
                temp += this.genCharUpper();
            }
            if (this._charType.HasFlag(CharType.Lower))
            {
                temp += this.genCharLower();
            }

            return temp[_random.Next(0, temp.Length)];

        }

        public string genString(int size)
        {

            string s = string.Empty;

            for (int i = 0; i < size; i++)
            {
                s += Convert.ToString(this.genCharRandom());
            }

            return s;

        }

    }
}
