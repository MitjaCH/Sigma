using System;

struct Sigma
{
    private bool sigma;

    // Constructor to initialize Sigma
    public Sigma(bool value)
    {
        sigma = value;
    }

    // Public method to access sigma
    public bool IsSigma()
    {
        return sigma;
    }
}

class Program
{
    private Sigma test;

    // Method to validate Sigma
    private bool ValidateSigma(Sigma sigma)
    {
        if (!sigma.IsSigma())  // Calls IsSigma() to check the bool value
        {
            return false;
        }
        return true;
    }

    // Main entry point
    static void Main(string[] args)
    {
        Program program = new Program();

        // Create a Sigma instance and test validation
        program.test = new Sigma(true);
        bool isValid = program.ValidateSigma(program.test);

        Console.WriteLine($"Validation result: {isValid}");
    }
}
