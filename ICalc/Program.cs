public class Array : IOutput, ICalc, IOutput2, ICalc2
{
    private int[] _array;

    public Array(int[] array)
    {
        _array = array;
    }

    public void Show()
    {
        Console.WriteLine("Array elements: " + string.Join(", ", _array));
    }

    public void Show(string info)
    {
        Console.WriteLine(info + ": " + string.Join(", ", _array));
    }

    public int Less(int valueToCompare)
    {
        return _array.Count(value => value < valueToCompare);
    }

    public int Greater(int valueToCompare)
    {
        return _array.Count(value => value > valueToCompare);
    }

    public void ShowEven()
    {
        var evenNumbers = _array.Where(x => x % 2 == 0);
        Console.WriteLine("Even elements: " + string.Join(", ", evenNumbers));
    }

    public void ShowOdd()
    {
        var oddNumbers = _array.Where(x => x % 2 != 0);
        Console.WriteLine("Odd elements: " + string.Join(", ", oddNumbers));
    }

    public int CountDistinct()
    {
        return _array.Distinct().Count();
    }

    public int EqualToValue(int valueToCompare)
    {
        return _array.Count(value => value == valueToCompare);
    }
}

public interface IOutput
{
    void Show();
    void Show(string info);
}

public interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

public interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

public interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 5, 1, 6, 3, 4, 1, 5 };

        Array array = new Array(numbers);

        array.Show();
        array.Show("Here you can see the elements of the array");

        int valueToCompare = 4;
        Console.WriteLine($"Number of elements less than {valueToCompare}: {array.Less(valueToCompare)}");
        Console.WriteLine($"Number of elements greater than {valueToCompare}: {array.Greater(valueToCompare)}");

        array.ShowEven();
        array.ShowOdd();

        Console.WriteLine($"Number of distinct elements: {array.CountDistinct()}");
        int valueToFind = 5;
        Console.WriteLine($"Number of elements equal to {valueToFind}: {array.EqualToValue(valueToFind)}");
    }
}
