Console.WriteLine("Bir sayı giriniz.");
int elementIndex = Convert.ToInt32(Console.ReadLine());
int[] fibo=new int[elementIndex];
fibo[0] = 1;
fibo[1] = 1;
if (elementIndex > 2) 
{
    for (int i = 2; i >= 0; i++)
    {

        if (fibo[i] <= elementIndex) { fibo[i] = fibo[i - 2] + fibo[i - 1]; }
        else { break; }
    }
}
foreach (int i in fibo) {  Console.WriteLine(i); } 
Console.ReadLine();
