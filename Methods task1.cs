string[] cars1 = { "toyota", "bmw", "mercedes", "gelly" };
string[] cars2 = { "ford", "mercedes", "porche" };

SimilarString(cars1, cars2);




 static void SimilarString(string[] a, string[] b)
{
    string SameWords = " ";
    for (int i = 0; i < a.Length; i++)
    {


        for (int k = 0; k < b.Length; k++)
        {
            if (a[i] == b[k])
            {

                SameWords += a[i];
            }
        }
    }
    Console.WriteLine(SameWords);

}