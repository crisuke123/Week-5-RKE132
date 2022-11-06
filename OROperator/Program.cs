

int math, biology, chemistry;
Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology <= 90))
{
    Console.WriteLine("Conguratulation! Yoy got accepted ");
}
else
{
    Console.WriteLine("Yoyr application cannot be approved");
}