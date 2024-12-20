namespace WTF
{
    public class Class1
    {
        public static void Shift(char[] arr, int desplazamiento)
        {
            if (arr == null || arr.Length == 0)
                return;
            int mov = desplazamiento;
            if (desplazamiento >= arr.Length)
                mov = desplazamiento % arr.Length;

            char aux = arr[arr.Length-1];
            int fate = arr.Length - 1;

            for (int i = 0; i < arr.Length -1; i++)
            {
                int position = fate - mov;
                if (position < 0)
                    position += arr.Length;
                if (fate < 0)
                    fate += arr.Length;
                arr[position] = arr[fate];
                fate -= mov;
                position -= mov;

                if (i == 0)
                    arr[fate] = aux;
            }
        }

        public static void PrintArr(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
