using System;

public class GetComplicatedValue
{
    public double GetValue(double val1, double val2, double val3){
        double target = 0;
        double min = Math.Min(Math.Min(val1, val2), val3);
        double max = Math.Max(Math.Max(val1, val2), val3);

        Console.WriteLine($"Min: {min} | Max: {max}");

        if (val1 != min && val1 != max){
            target = val1;
            Console.WriteLine($"1: {target}");
        }

        if (val2 != min && val2 != max){
            target = val2;
            Console.WriteLine($"2: {target}");
        }

        if (val3 != min && val3 != max){
            target = val3;
            Console.WriteLine($"3: {target}");
        }

        if (val1 == val2 && val1 != val3 && val1 < val3){
            target = Math.Min(val1, val3);
            Console.WriteLine($"4: {target}");
        }
        
        if (val1 == val2 && val1 != val3 && val1 > val3){
            target = Math.Max(val1, val3);
            Console.WriteLine($"5: {target}");
        }

        if (val1 == val3 && val1 != val2 && val1 < val2){
            target = Math.Min(val1, val2);
            Console.WriteLine($"6: {target}");
        }
        
        if (val1 == val3 && val1 != val2 && val1 > val2){
            target = Math.Max(val1, val2);
            Console.WriteLine($"7: {target}");
        }

        if (val2 == val3 && val2 != val1 && val2 < val1){
            target = Math.Min(val2, val1);
            Console.WriteLine($"8: {target}");
        }
        
        if (val2 == val3 && val2 != val1 && val2 > val1){
            target = Math.Max(val2, val1);
            Console.WriteLine($"9: {target}");
        }

        if (val1 == 0 && val1 == val2 && val3 > val1){
            target = val3;
            Console.WriteLine($"10: {target}");
        }

        if (val1 == 0 && val1 == val3 && val2 > val1){
            target = val2;
            Console.WriteLine($"11: {target}");
        }

        if (val1 == 0 && val2 == val3 && val1 > val2){
            target = val1;
            Console.WriteLine($"12: {target}");
        }

        if (val1== val2 && val1 == val3){
            target = val1;
            Console.WriteLine($"13: {target}");
        }

        return target;
    }
}