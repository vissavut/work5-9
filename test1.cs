using System;
using System.Collections.Generic;
using System.Linq;

public interface IHomework13
{
    IEnumerable<int> Homework13(IEnumerable<int> numbers);
}
public class run : IHomework13
{
    public IEnumerable<int> Homework13(IEnumerable<int> numbers)
    {
        int[] array = numbers.ToArray();

        var Result = new List<int>();

        foreach (var item in numbers)
        {

            if (array[5] + array[4] == 18)
            {
                if (array[3] != 9)
                {
                    return array;
                }
            }
            else if (array[4] + array[3] == 18)
            {
                if (array[5] != 9 && array[2] != 9)
                {
                    return array;
                }
            }
            else if (array[3] + array[2] == 18)
            {
                if (array[4] != 9 && array[1] != 9)
                {
                    return array;
                }
            }
            else if (array[2] + array[1] == 18)
            {
                if (array[3] != 9 && array[0] != 9)
                {
                    return array;
                }
            }
            else if (array[1] + array[0] == 18)
            {
                if (array[2] != 9)
                {
                    if (array[5] + array[4] + array[3] != 27)
                    {
                        return array;
                    }
                }
            }
        }
        return Result;

    }
}