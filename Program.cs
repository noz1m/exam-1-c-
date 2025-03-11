//task 1
// void nozim()
// {
//     System.Console.Write("Number: ");
//     int n = int.Parse(System.Console.ReadLine());
//     int sum = 0;
//     for (int i = n; i > 0; i /= 10)
//     {
//         sum += i % 10;
//     }
//     System.Console.WriteLine("Sum: " + sum);
// }
// nozim();

//task 2
// void nozim()
// {
//     System.Console.Write("Celsius: ");
//     int n = int.Parse(System.Console.ReadLine());
//     System.Console.WriteLine($"({n} * 9/5) + 32 = {(n * 9/5) + 32}");
// }
// nozim();

//task 3
// void nozim()
// {
//     System.Console.Write("Radius: ");
//     int n = int.Parse(System.Console.ReadLine());
//     System.Console.WriteLine($"Area:  {(3.14 * n * n)}");
//     System.Console.WriteLine($"Circumference: {2 * 3.14 * n}");
// }
// nozim();

//task 4
// int nozim(int n)
// {
//     if (n <= 1) return 1;
//     return n * nozim(n-1);
// }
// System.Console.WriteLine(nozim(5));

//task 5
// void nozim()
// {
//     System.Console.Write("Number: ");
//     int n = int.Parse(System.Console.ReadLine());
//     for (int i = 1; i <= n; i++){
//         if (i % 1 != 0 && i % n != 0){
//             System.Console.WriteLine("Prime: NO");
//         }
//         else{
//             System.Console.WriteLine("Prime: YES");
//             break;
//         }
//     }
// }
// nozim();

//task 6
// void nozim()
// {
//     System.Console.Write("Year: ");
//     int n = int.Parse(System.Console.ReadLine());
//     if (n % 4 == 0 && n % 100 != 0){
//         System.Console.WriteLine("Leap Year: Yes");
//     }
//     else { 
//         System.Console.WriteLine("Leap Year: No");
//     }
// }
// nozim();

//task 7
// void nozim()
// {
//     int sum = 0;
//     int mx = -999999;
//     int mn = 999999; 
//     int n = int.Parse(System.Console.ReadLine());
//     int[] arr = new int[n];
//     for (int i = 0; i < n; i++){
//         arr[i] = int.Parse(System.Console.ReadLine()); 
//     }
//     for (int i = 0; i < n; i++){
//         if (arr[i] > mx){
//             mx = arr[i];
//         }
//         if (arr[i] < mn){
//             mn = arr[i];
//         }
//     }
//     System.Console.WriteLine("min: " + mn);
//     System.Console.WriteLine("max: " + mx);
//     System.Console.WriteLine("sum: " + (mx + mn));
// }
// nozim();

//task 8
// void nozim()
// {
//     int a = 0;
//     int b = 0;
//     int n = int.Parse(System.Console.ReadLine());
//     int[] arr = new int[n];
//     for (int i = 0; i < n; i++){
//         arr[i] = int.Parse(System.Console.ReadLine()); 
//     }
//     for (int i = 0; i < n; i++){
//         if (arr[i] % 2 == 0){
//             a = arr[i];
//             a = 0;
//         }
//         if (arr[i] % 2 != 0){
//             b = arr[i];
//             b = 1;
//         }
//     }
// }
// nozim();

// task 9
// void nozim()
// {
//     int a = int.Parse(System.Console.ReadLine());
//     int[] arr = new int[a];
//     for (int i = 0; i < a; i++){
//         arr[i] = int.Parse(System.Console.ReadLine()); 
//     }
//     int b = int.Parse(System.Console.ReadLine());
//     for (int i = 0; i < a; i++){
//         for (int j = 0; j < arr[i]; j++){
//             if (arr[i] + arr[j] == b){
//                 System.Console.Write(arr[j] + " " + arr[i]);
//                 System.Console.WriteLine();
//             }
//         }
//     }
// }
// nozim();

//task 10
// void nozim()
// {
//     string a =(System.Console.ReadLine());
//     int con = 0;
//     int vow = 0;
//     string b = a.Replace(" ", "");
//     for (int i = 0; i < a.Length; i++){
//         // if (a[i] == 'H' || a[i] == 'l' || a[i] == 'l' || a[i] == 'W' || a[i] == 'r' || a[i] == 'd'){
//         //     con++;
//         // }
//         if (a[i] == 'e' || a[i] == 'E' || a[i] == 'O' || a[i] == 'o' || a[i] == 'A' || a[i] == 'a' || a[i] == 'U' || a[i] == 'u' || a[i] == 'Y' || a[i] == 'y' || a[i] == 'I' || a[i] == 'i'){
//             vow++;
//         }
//         else {
//             con++;
//         }
//     }
//     int c = b.Length - vow;
//     System.Console.WriteLine("Vowels: " + vow);
//     System.Console.WriteLine("Consonants: " + con);
// }
// nozim();