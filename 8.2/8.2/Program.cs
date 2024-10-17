using System;

public interface IBitOperations
{
    BitString And(BitString other);
    BitString Or(BitString other);
    BitString Xor(BitString other);
    BitString Not();
    BitString ShiftLeft(int bits);
    BitString ShiftRight(int bits);
}

public abstract class BitManipulation
{
    public abstract void Display();
}

public class BitString : BitManipulation, IBitOperations
{
    private ulong high; // старшие 32 бита
    private ulong low;  // младшие 32 бита

    public BitString(ulong high = 0, ulong low = 0)
    {
        this.high = high;
        this.low = low;
    }

    ~BitString()
    {
        Console.WriteLine("Bitstring");
    }

    public BitString And(BitString other)
    {
        return new BitString(this.high & other.high, this.low & other.low);
    }

    public BitString Or(BitString other)
    {
        return new BitString(this.high | other.high, this.low | other.low);
    }

    public BitString Xor(BitString other)
    {
        return new BitString(this.high ^ other.high, this.low ^ other.low);
    }

    public BitString Not()
    {
        return new BitString(~this.high, ~this.low);
    }

    public BitString ShiftLeft(int bits)
    {
        if (bits >= 64)
        {
            return new BitString(0, 0);
        }
        else if (bits >= 32)
        {
            return new BitString(1UL << (bits - 32), 0);
        }
        else
        {
            return new BitString(this.high << bits | (this.low >> (32 - bits)), this.low << bits);
        }
    }

    public BitString ShiftRight(int bits)
    {
        if (bits >= 64)
        {
            return new BitString(0, 0);
        }
        else if (bits >= 32)
        {
            return new BitString(0, this.high >> (bits - 32));
        }
        else
        {
            return new BitString(this.high >> bits, (this.low >> bits) | (this.high << (32 - bits)));
        }
    }

    public override void Display()
    {
        Console.WriteLine($"BitString: High={high}, Low={low}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите верхнюю часть BitString (unsigned long): ");
            ulong high = Convert.ToUInt64(Console.ReadLine());

            Console.WriteLine("Введите нижнюю часть BitString (unsigned long): ");
            ulong low = Convert.ToUInt64(Console.ReadLine());

            BitString bitString1 = new BitString(high, low);
            bitString1.Display();

            Console.WriteLine("Введите верхнюю часть для второго BitString: ");
            high = Convert.ToUInt64(Console.ReadLine());

            Console.WriteLine("Введите нижнюю часть для второго BitString: ");
            low = Convert.ToUInt64(Console.ReadLine());

            BitString bitString2 = new BitString(high, low);
            bitString2.Display();

            // Демонстрация работы с битами
            Console.WriteLine("AND операция:");
            bitString1.And(bitString2).Display();

            Console.WriteLine("OR операция:");
            bitString1.Or(bitString2).Display();

            Console.WriteLine("XOR операция:");
            bitString1.Xor(bitString2).Display();

            Console.WriteLine("NOT операция:");
            bitString1.Not().Display();

            Console.WriteLine("Сдвиг влево на 4 бита:");
            bitString1.ShiftLeft(4).Display();

            Console.WriteLine("Сдвиг вправо на 4 бита:");
            bitString1.ShiftRight(4).Display();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Неверный ввод данных");
        }
    }
}