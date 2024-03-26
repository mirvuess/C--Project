//function 

double CalculateFormula(double a, int b, int c, int d)
{
    double result = a * b / (c + d);
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);