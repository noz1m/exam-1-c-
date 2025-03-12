// task 1
// int n = int.Parse(System.Console.ReadLine());
// int sum = 0;
// int mn = 999999;
// int mx = -999999;
// int cnt = 0;
// int even = 0;
// int odd = 0; 
// int zero = 0;
// for (int i = n; i > 0; i /= 10){
//     int a = i % 10;
//     sum += a;
//     cnt++;
//     if (a < mn){
//         mn = a;
//     }
//     if (a > mx){
//         mx = a;
//     }
//     if (a % 2 == 0){
//         even++;
//     } 
//     if (a % 2 != 0){
//         odd++;
//     }
//     if (a == 0){
//         zero++;
//     } 
// }
// System.Console.WriteLine("Even : " + even);
// System.Console.WriteLine("Odd : " + odd);
// System.Console.WriteLine("Zeros : " + zero);
// System.Console.WriteLine("Digits : " + cnt);
// System.Console.WriteLine("Min : " + mn);
// System.Console.WriteLine("Max : " + mx);
// System.Console.WriteLine("Sum of Digits: " + sum);


// task 2 
// char check(int a)
// {   
//     if (a >= 90 && a<=100) return 'A';
//     if (a >= 80 && a<=89) return 'B';
//     if (a >= 70 && a<=79) return 'C';
//     if (a >= 60 && a<=69) return 'D';
//     if (a >= 0 && a<=59) return 'F';
//     return ' ';
// }
// int a = int.Parse(System.Console.ReadLine());
// System.Console.WriteLine(check(a));


// task 3
// void system()
// {
//     int a = int.Parse(System.Console.ReadLine());
//     int[] arr = new int[a];
//     int pos = 0;
//     int neg = 0;
//     int zero = 0;
//     for (int x = 0; x < a; x++)
//     {
//         arr[x] = int.Parse(System.Console.ReadLine());
//     }
//     for (int x = 0; x < a; x++)
//     {
//         if (arr[x] > 0)
//         {
//             pos++;
//         }
//         if (arr[x] < 0)
//         {
//             neg++;
//         }
//         if (arr[x] == 0)
//         {
//             zero++;
//         }
//     }
//     System.Console.WriteLine("Positive: " + pos);
//     System.Console.WriteLine("Negative: " + neg);
//     System.Console.WriteLine("Zero: " + zero);
// }
// system();

// task 4
// void system()
// {
//     int a = int.Parse(System.Console.ReadLine());
//     int[] arr = new int[a];
//     for (int x = 0; x < a; x++)
//     {
//         arr[x] = int.Parse(System.Console.ReadLine());
//     }
//     for (int x = 0; x < a; x++)
//     {
//         if (x %2 == 0)
//         {
//             System.Console.Write(arr[x] + " ");;
//         }
//     }
// }
// system();

// task 5
// void system()
// {
//     int a = int.Parse(System.Console.ReadLine());
//     int[] arr = new int[a];
//     for (int x = 0; x < a; x++)
//     {
//         arr[x] = int.Parse(System.Console.ReadLine());
//     }
//     int cnt=0;
//     for (int x = 0; x < a-1; x++)
//     {
//         if (arr[x] < arr[x + 1])
//         {
//             cnt++;
//         }
//     }
//     System.Console.Write("cnt" + cnt);
// }
// system();


// task 6
// void system()
// {
//     int a = int.Parse(System.Console.ReadLine());
//     int[] arr = new int[a];
//     for (int x = 0; x < a; x++)
//     {
//         arr[x] = int.Parse(System.Console.ReadLine());
//     }
//     for (int x = 0; x < a; x++)
//     {
//         for (int z = 0; z < x; z++)
//         {
//             if (arr[x] == arr[z])
//             {
//                 System.Console.Write( arr [ x ] + " ");
//             }
//         }
//     }
// }
// system();



// task 7
// void system()
// {
//     int a = int.Parse(System.Console.ReadLine());
//     int b = int.Parse(System.Console.ReadLine());
//     for (int x = a; x <= b; x++)
//     {
//         for ( int z =1 ; z <= 10; z++  )
//         {
//         System.Console.WriteLine(x + "*" + z + "=" + a*z );
//         }
//         System.Console.WriteLine();
//     }
// }
// system();

// task 8
// void system()
// {
//     int a = int.Parse(System.Console.ReadLine());
//     char c = char.Parse(System.Console.ReadLine());
//     int b = int.Parse(System.Console.ReadLine());
//     if (c == '*')
//     {
//         System.Console.WriteLine(a * b);
//     }
//     if (c == '+')
//     {
//         System.Console.WriteLine(a + b);
//     }
//     if (c == '/')
//     {
//         System.Console.WriteLine(a / b);
//     }
//     if (c == '-')
//     {
//         System.Console.WriteLine(a - b);
//     }
// }
// system();

// task 9
// int step(int a, int b)
// {
//     if (b <= 0) return 1;
//     return a * step(a, b - 1);
// }
// int a = int.Parse(System.Console.ReadLine());
// int b = int.Parse(System.Console.ReadLine());
// System.Console.WriteLine(step(a, b));


// task 10
// int fb(int a)
// {
//     if (a <= 1) return a;
//     return fb(a - 2) + fb(a - 1);
// }
// int a = int.Parse(System.Console.ReadLine());
// for(int x=0;x<=a;x++)
// {
//     System.Console.Write(fb(x) + " ");
// }