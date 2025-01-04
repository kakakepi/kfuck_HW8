namespace Lab9
{
    interface ICipher 
    {
        string Encode(string toCodeWord);
        string Decode(string toDecodeWord);
    }
}