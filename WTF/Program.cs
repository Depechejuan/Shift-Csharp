namespace WTF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[5];
            arr[0] = 'S';
            arr[1] = 'O';
            arr[2] = 'F';
            arr[3] = 'I';
            arr[4] = 'A';

            Class1.Shift(arr, 2);
            Class1.PrintArr(arr);

        }
    }
}
