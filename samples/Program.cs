using OkoloIt.Utilities.Result;

static Result<int> GetPositiveNumber(int value)
{
    if (value < 0)
        return Result.Fail("Число отрицательное!");

    return Result.Ok(value);
}

IResult<int> number = GetPositiveNumber(-5);

if (number.Success)
    Console.WriteLine($"Число: {number.Value}");
else
    Console.WriteLine(number.Message);


IResult<string> result = Foo(false);

Console.WriteLine();

Result<string> Foo(bool flag)
{
    if (flag == true)
        return Result.Ok("dfssdf");

    return Result.Fail("Ошибка");
}