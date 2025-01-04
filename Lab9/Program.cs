namespace Lab9
{
    class Program
    {
        static void Main()
        {
            string text = "Hello, World!";
            ICipher aCipher = new ACipher();
            string encodedACipher = aCipher.Encode(text);
            string decodedACipher = aCipher.Decode(encodedACipher);
            Console.WriteLine($"ACipher Encode: {encodedACipher}");
            Console.WriteLine($"ACipher Decode: {decodedACipher}");
            ICipher bCipher = new BCipher();
            string encodedBCipher = bCipher.Encode(text);
            string decodedBCipher = bCipher.Decode(encodedBCipher);
            Console.WriteLine($"BCipher Encode: {encodedBCipher}");
            Console.WriteLine($"BCipher Decode: {decodedBCipher}");
        }
    }
}