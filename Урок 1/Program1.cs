internal class Program
{
    private static void Main(string[] args)
    {
        int max = 0;

        Console.Write("������� ������ �����:");
        string a = Console.ReadLine();
        Console.Write("������� ������ �����:");
        string d = Console.ReadLine();

        int a1 = Convert.ToInt32(a);
        int d1 = Convert.ToInt32(d);
        if (a1 < d1)
        {
            max = d1;
        }
        else
        {
            max = a1;
        }

        Console.WriteLine($"������� ����� �� ���� ���� �����: " + max);
    }
}