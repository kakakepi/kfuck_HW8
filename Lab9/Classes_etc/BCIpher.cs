namespace Lab9
{
    class BCipher : ICipher
    {
        public string Encode(string whatToCode)
        {
            char[] chars = new char[whatToCode.Length];
            for (int i = 0; i < whatToCode.Length; i++)
            {
                char c = whatToCode[i];
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        chars[i] = (char)('Z' - (c - 'A'));
                    }
                    else
                    {
                        chars[i] = (char)('z' - (c - 'a'));
                    }
                }
                else
                {
                    chars[i] = c;
                }
            }
            return new string(chars);
        }
        public string Decode(string whatToDecode)
        {
            return Encode(whatToDecode);
        }
    }
}