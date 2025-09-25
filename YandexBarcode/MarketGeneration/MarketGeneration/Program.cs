namespace MarketGeneration;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string firstName = "MRKT";
        List<string> barcodes = new List<string>();

        for (int i = 0; i < 100; i++)
        {
            int[] numberGenerator = new int[10];
            for (int j = 0; j < numberGenerator.Length; j++)
            {
                numberGenerator[j] = randomGenerator.Next(0, 10);
            }
            string barcode = firstName + string.Join("", numberGenerator);
            barcodes.Add(barcode);
        }
        System.IO.File.WriteAllLines("barcodes.txt", barcodes);
        

    }
}