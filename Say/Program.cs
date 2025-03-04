try
{
    throw new ArgumentOutOfRangeException(nameof(shapeAmount), "Amount of shapes must be positive.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}