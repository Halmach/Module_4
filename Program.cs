using System;

namespace Module_4
{
    class Program
    {
          
        static void Main()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int i = 1,j = 2;
            while(i < arr.Length)
            {
                if(arr[i-1] <= arr[i]) { i = j; j++;}
                else
                {
                    int t = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = t;
                    i--;
                    if(i == 0) { i = j; j++;}
                }
            }
            foreach (var arrItem in arr) Console.Write(arrItem + " ");
            //Console.WriteLine("Последняя буква вашего имени: " + name[name.Length - 1]);

        }
    }
    
}
