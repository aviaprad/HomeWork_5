// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int [] CreateRandomArray(int size, int minVal, int maxVal)
{
    int [] newArray = new int [size];
    for (int i=0; i<size; i++)
        newArray[i]= new Random().Next(minVal,maxVal+1);
    return newArray;
}
 void ShowArray (int [] array1)
 {
    for (int i = 0; i< array1.Length; i++)
        Console.Write (array1[i]+ " ");
    Console.WriteLine();
 }

int FindSummEvenElem(int [] array)  // Метод определения количества четных элементов
 {
    int summEven = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
             summEven++;
    return summEven;
 }

 int sizeArray = 10; // Задаем количество элементов массива
 int minValue = 100; // Минимальное случайное трехзначное число 
 int maxValue = 1000;// Максимальное случайное трехзначное число+1

 int [] createdArray = CreateRandomArray(sizeArray, minValue, maxValue);
 ShowArray(createdArray);
 Console.WriteLine($" Summ of even elements {FindSummEvenElem(createdArray)}");
 
 */

/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] CreateRandomArray(int size, int minVal, int maxVal)
{
    int [] newArray = new int [size];
    for (int i=0; i<size; i++)
        newArray[i]= new Random().Next(minVal,maxVal+1);
    return newArray;
}
 void ShowArray (int [] array1)
 {
    for (int i = 0; i< array1.Length; i++)
        Console.Write (array1[i]+ " ");
    Console.WriteLine();
 }

int FindSummOddElem(int [] array)  // Метод определения суммы элементов на нечетных позициях
 {
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
             sum+=array[i];
    return sum;
 }
int sizeArray = 10;
int minValue = -99;
int maxValue = 100;

int [] createdArray = CreateRandomArray(sizeArray, minValue, maxValue);
 ShowArray(createdArray);
 Console.WriteLine($" Summ of odd position elements {FindSummOddElem(createdArray)}");

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] CreateRandomArray(int size, int minVal, int maxVal)
{
    double [] newArray = new double [size];
    for (int i=0; i<size; i++)
        newArray[i]= Math.Round (new Random().Next(minVal,maxVal+1)+new Random().NextDouble(),2);
    return newArray;
}
 void ShowArray (double [] array1)
 {
    for (int i = 0; i< array1.Length; i++)
        Console.Write (array1[i]+ " ");
    Console.WriteLine();
 }

double FindDiff(double [] array)  //
 {
    double diff = 0;
    double minValue = array[0];
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
        if (minValue > array[i])
        {
            minValue = array[i];
        }
        else  
       
        if (maxValue < array[i])
            maxValue = array[i];
    diff = Math.Round(maxValue-minValue,3);
    return diff;
 }

int sizeArray = 3; // Задаем количество элементов массива
int minValue = 1; // Минимальное случайное число 
int maxValue = 100;// Максимальное случайное число+1

double [] createdArray = CreateRandomArray(sizeArray, minValue, maxValue);
ShowArray(createdArray);
Console.WriteLine($"  Difference between maximum and minimum array elements {FindDiff(createdArray)}");