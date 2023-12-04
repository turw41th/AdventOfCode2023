namespace _01;

public class DigitFinder
{
    public int FindRelevantSum()
    {
        List<int> allValues = new();
        int sum = 0;

        foreach (string line in LoadFileContent())
        {
            (char?, char?) digits = FindFirstAndLastDigit(line);
            string combined = digits.Item1.ToString() + digits.Item2.ToString();
            allValues.Add(int.Parse(combined));
        }

        foreach (int value in allValues)
        {
            sum += value;
        }

        return sum;
    }

    private string[] LoadFileContent() =>
        File.ReadAllLines(@"Resources\resourceFile.txt");
    

    private (char?, char?) FindFirstAndLastDigit(string input)
    {
        char? firstDigit = null;
        char? lastDigit = null;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                if (firstDigit == null)
                {
                    firstDigit = c;
                }

                lastDigit = c;
            }
        }

        return (firstDigit, lastDigit);
    }
}