using OkoloIt.Utilities.Result;

static IResult<int> GetPositiveNumber(int value)
{
    if (value < 0)
        return Result.Fail<int>("Число отрицательное!");

    return Result.Ok(value);
}

IResult<int> number = GetPositiveNumber(-5);

if (number.Success)
    Console.WriteLine($"Число: {number.Value}");
else
    Console.WriteLine(number.Message);