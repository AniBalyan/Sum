 
  int result1 = Sum1(100);
  int result2 = Sum2(100);
  int result3 = Sum3(100);

    Console.WriteLine("For loop: " + result1);
    Console.WriteLine("While loop: " + result2);
    Console.Write("Do while: " + result3);



  int Sum1(int number)
  {
    int sum1 = 0;

    for (int i = 1; i <= number; i++)
    {
        sum1 = sum1 + i;
    }

    return sum1;
   }

    

    int Sum2 (int number)
{
    int i = 0;
    int sum2 = 0;
    while (i < number)
    {
        i++;
        sum2 = sum2 +i;
    }
    return sum2;
}


   int Sum3 (int number)
{
    int sum3 = 0;
    int i = 0;

    do
    {
        i++;
        sum3 = sum3 + i;
    }
         while (i < number);

    return sum3;
}

