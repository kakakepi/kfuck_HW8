using System;

namespace Lab9
{
    class ACipher : ICipher
    {
        public string Encode(string whatToCode)
        {
            
            char[] chars = new char[whatToCode.Length];
            for (int i = 0; i < whatToCode.Length; i++)
            {
                if (char.IsLetter(whatToCode[i]))
                {
                    if (char.IsLower(whatToCode[i]))
                    {
                        if (whatToCode[i] == 'z')
                        {
                            chars[i] = 'a';
                        }
                        else if (whatToCode[i] == 'я')
                        {
                            chars[i] = 'а';
                        }
                        else
                        {
                            chars[i] = (char)(whatToCode[i] + 1);
                        }
                    }
                    else if (char.IsUpper(whatToCode[i]))
                    {
                        if (whatToCode[i] == 'Z')
                        {
                            chars[i] = 'A';
                        }
                        else if (whatToCode[i] == 'Я')
                        {
                            chars[i] = 'А';
                        }
                        else
                        {
                            chars[i] = (char)(whatToCode[i] + 1);
                        }
                    }
                }
                else
                {
                    chars[i] = whatToCode[i];
                }
            }
            return string.Join("", chars); 
        }
        public string Decode(string whatToCode)
        {
            
            char[] chars = new char[whatToCode.Length];
            for (int i = 0; i < whatToCode.Length; i++)
            {
                if (char.IsLetter(whatToCode[i]))
                {
                    if (char.IsLower(whatToCode[i]))
                    {
                        if (whatToCode[i] == 'a')
                        {
                            chars[i] = 'z';
                        }
                        else if (whatToCode[i] == 'а')
                        {
                            chars[i] = 'я';
                        }
                        else
                        {
                            chars[i] = (char)(whatToCode[i] - 1);
                        }
                    }
                    else if (char.IsUpper(whatToCode[i]))
                    {
                        if (whatToCode[i] == 'A')
                        {
                            chars[i] = 'Z';
                        }
                        else if (whatToCode[i] == 'А')
                        {
                            chars[i] = 'Z';
                        }
                        else
                        {
                            chars[i] = (char)(whatToCode[i] - 1);
                        }
                    }
                }
                else
                {
                    chars[i] = whatToCode[i];
                }
            }
            return new string(chars); 
        }
    }
}