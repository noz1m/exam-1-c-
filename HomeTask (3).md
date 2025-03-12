

### Task1 
**Given a positive number of n. Print :**  

- The number of even numbers ===> `int EvenCount(int n)`.

- The number of odd numbers ===> `int OddCount(int n)`.

- The number of zeros ===> `int ZeroCount(int n)`.

- The number of digits ===> `int DigitCount(int n)`.

- Min digit ===> `int MinDigit(int n)`.

- Max digit ===> `int MaxDigit(int n)`.

- Sum of digits ===> `int SumDigit(int n)`.

---

- Количество четных чисел ===> `int EvenCount(int n)`.

- Количество нечетных чисел ===> `int OddCount(int n)`.

- Количество нулей ===> `int ZeroCount(int n)`.

- Количество цифр ===> `int DigitCount(int n)`.

- Минимальная цифра ===> `int MinDigit(int n)`.

- Миксимальная цифра ===> `int MaxDigit(int n)`.

- Сумма цифр ===> `int SumDigit(int n)`.

---

- Шумораи рақамҳои ҷуфт ===> `int EvenCount(int n)`.   

- Шумораи рақамҳои тоқ ===> `int OddCount(int n)`.

- Шумораи сифрҳо ===> `int ZeroCount(int n)`.

- Шумораи рақамҳо ===> `int DigitCount(int n)`.

- Раками хурдтарин ===> `int MinDigit(int n)`.

- Раками калонтарин ===> `int MaxDigit(int n)`.
 
- Чамъи ракамхо ===> `int SumDigit(int n)`.

**Input** 
```
12043
```
**Output**
```
Even : 2
Odd : 2
Zeros : 1
Digits : 5
Min : 0
Max : 4
Sum of Digits: 10
```

### Task2
Write a method `char CheckGrade(int grade)` that takes in an integer representing a student's grade as input,

and outputs whether it is an A, B, C, D, or F using if-else statements.

Grade A: 90-100

Grade B: 80-89

Grade C: 70-79

Grade D: 60-69

Grade F: 0-59

----

Напишите метод **char CheckGrade(int grade)**, которая принимает на вход целое число, представляющее оценку ученика, и выводит, 

является ли она A, B, C, D или F, используя операторы if-else.

----

Методи **char CheckGrade(int grade)**-ро нависед, ки адади бутунро ифодакунандаи баҳои донишҷӯ мегирад 

ва вобаста ба он баҳои талабаро ҳамчун ҳарфҳои A, B, C, D ва F мебарорад.

**Input**
```
90
```
**Output**
```
A
```
**Sample Input:**
```
59
```
**Sample Output:**
```
F
```

### Task3 : Print Numbers
The number N is entered, and then N numbers.Print the number of Positive, Negative , zeros…  

----

Вводится число N, а затем N цифр. Выведите количество положительных, отрицательных, нулей…      

----

Адади N ворид карда мешавад ва сипас N рақамҳо. Шумораи мусбӣ, манфӣ, ... , сифрҳоро чоп кунед…
  
 **Input** 
```
6
2 -3 4 6 8 0
```
**Output**
```
Negative = 1
Positive = 4
Zeros = 1
```

### Task4 : Even Element
Given an array of integers. Element numbering starts at 0. Display all array          
elements with even indexes (A[0], A[2], A[4], ...).       

----

(Дан массив целых чисел. Нумерация элементов начинается с 0. Вывести все      
элементы массива с четными индексами (A[0], A[2], A[4], ...).)     

----

Бо назардошти як қатор ададҳо. Рақамгузории элементҳо аз 0 оғоз мешавад.       
Намоиши ҳамаи элементҳои массив бо индексҳои ҷуфт (A[0], A[2], A[4], ...).   

 **Input** 
```
4
3 1 2 4
```
**Output**
```
3 2
```

### Task5 : Elements that are greater than the previous element
Given an array. Find the number of array elements that are greater than the previous element in that array.  

----

(Дан массив. Найдите количество элементов массива, которые больше, чем предыдущий элемент в этом массиве.)  

----

(Массив дода шудааст. Шумораи элементҳои массивро, ки аз элементи қаблии ин массив зиёданд, пайдо кунед.)      

 **Input** 
```
5
1 2 3 4 5
```
**Output**
```
4
```

### Task6 : Print the repeating elements
Given a number N and an array of N numbers. Print the repeating elements of the given array.    

----

Дано число N и массив из N чисел. Выведите повторяющиеся элементы заданного массива.     

----

Бо назардошти рақами N ва массиви рақамҳои N. Элементҳои такроршавандаи массиви додашударо чоп кунед.   

 **Input** 
```
7
3 42 2 3 48 3
```
**Output**
```
3 3 3 
```

### Task7 : Displays the multiplication tables
Create a C# program that asks the user for a range of numbers (x, y) and displays the multiplication tables from x to y.   

----

Создайте программу на C#, которая запрашивает у пользователя диапазон чисел (x, y) и отображает таблицу умножения. от х до у.    

----

Барномаи дар C# созед, ки аз Истифодабаранда як қатор рақамҳоро (x, y) талаб мекунад ва ҷадвалҳои зарбро намоиш медиҳад аз x то y.  

 **Input** 
```
From = 2
To = 3
```
**Output**
```
-------------------------------
2x1= 2
2x2= 4
2x3= 6
2x4= 8
2x5= 10
2x6= 12
2x7= 14
2x8= 16
2x9= 18
2x10= 20
------------------------------
3x1= 3
3x2= 6
3x3= 9
3x4= 12
3x5= 15
3x6= 18
3x7= 21
3x8= 24
3x9= 27
3x10= 30
-----------------------------
```

### Task8
Write a program in C# that asks the user for two numbers and one operation (+, -, *, /) then          
calculate the operation and display the result on the screen.     

----

Напишите программу на C#, которая запрашивает у пользователя два числа и одну операцию (+, -, *, /),          
а затем вычисляет операции и отобразить результат на экране. 

----

Дар C# барномае нависед, ки аз Истифодабаранда ду адад ва як амалро талаб кунад (+, -, *, /) ва         
сипас ҳисоб кунед ва натиҷаро дар экран нишон диҳед.        

 Create the methods :              
a. Sum()         
b. Subtract()      
c. Multiplication()       
d. Division()       

**Input**
```
The first number is: 3
The operation is: +
The first number is: 1
```

**Output**
```
3 + 1 = 4 
```

### Task9
Write a program in C# Sharp to calculate the power of any number using recursion.   

---- 

Напишите программу на C# Sharp для вычисления степени любого числа с помощью рекурсии.     

----
 
Барои ҳисоб кардани дарачаи дилхоҳ адад бо истифода аз рекурсия барномаеро дар C# Sharp нависед.    
 **Input**
```
Input the base value : 5
Input the exponent : 3
```
**Output**
```
The value of 5 to the power of 3 is : 125
```

### Task10 : Fibonacci 
Write a program in C# Sharp to find the Fibonacci numbers for a series of n numbers using recursion.     

----

Напишите программу на C# Sharp, чтобы найти числа Фибоначчи для ряда из n чисел, используя рекурсию.        

----

Дар C# Sharp барнома нависед, то рақамҳои Фибоначиро барои як қатор n адад бо истифода аз рекурсия пайдо кунед.   

 **Input**
```
Input number of terms for the Fibonacci series : 10
```
**Output**
```
The Fibonacci series of 10 terms is : 0 1 1 2 3 5 8 13 21 34
```




