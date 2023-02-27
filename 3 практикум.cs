// See https://aka.ms/new-console-template for more information

//задача 1

//int[] myArray = new int[5];

//Console.WriteLine("Введите элементы массива:");
//for (int i = 0; i < myArray.Length; i++)
//{
//    Console.Write($"Элемент {i + 1}: ");
//    myArray[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Массив:");
//for (int i = 0; i < myArray.Length; i++)
//{
//    Console.Write(myArray[i] + " ");
//}

//задача 2

//int[] myArray = new int[5]; 

//Random random = new Random();
//for (int i = 0; i < myArray.Length; i++)
//{
//    myArray[i] = random.Next(10); 
//}

//Console.WriteLine("Массив:");
//foreach (int num in myArray)
//{
//    Console.Write(num + " ");
//}

//задача 3

//int[] myArray = { 5, 7, 1, 8, 3, 9, 2 };

//int maxElement = myArray[0];
//int maxIndex = 0;
//for (int i = 1; i < myArray.Length; i++)
//{
//    if (myArray[i] > maxElement)
//    {
//        maxElement = myArray[i];
//        maxIndex = i;
//    }
//}


//int minElement = myArray[0];
//int minIndex = 0;
//for (int i = 1; i < myArray.Length; i++)
//{
//    if (myArray[i] < minElement)
//    {
//        minElement = myArray[i];
//        minIndex = i;
//    }
//}

//Console.WriteLine("Максимальный элемент: " + maxElement + ", индекс: " + maxIndex);
//Console.WriteLine("Минимальный элемент: " + minElement + ", индекс: " + minIndex);

//int temp = myArray[maxIndex];
//myArray[maxIndex] = myArray[minIndex];
//myArray[minIndex] = temp;

//Console.WriteLine("Измененный массив:");
//foreach (int num in myArray)
//{
//    Console.Write(num + " ");
//}

//int count = Math.Abs(maxIndex - minIndex) - 1;
//Console.WriteLine("\nКоличество элементов между максимальным и минимальным элементами: " + count);























