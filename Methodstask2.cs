using System.Net.Http.Headers;

int[] arry1 = { 5, 9, 11, 12, 13 };
int[] arry2 = { 6, 7, 14, 15, 17 };

Answer(arry1, arry2);


static void Answer(int[] a, int[] b)
{
    string product = " ";


    for (int i = 0; i < a.Length; i++)
    { 
        product += a[i] * b[i]; 
    }
    Console.WriteLine(product);
}