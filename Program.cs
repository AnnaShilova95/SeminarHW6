/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Метод, создающий массив из введеных пользователем чисел

int[] createArray(int size){
int[] myNum = new int[size];
for (int i = 0; i < myNum.Length; i++)
    {
    Console.Write("Введите одну цифру [" + i + "]:\t");
    myNum [i]  = int.Parse(Console.ReadLine());
    }
for (int i = 0; i < myNum.Length; i++)
    {
    Console.Write(myNum[i] + " ");
    }
    return myNum;
}
Console.WriteLine("");

//Метод, подсчитывающий количество положительных чисел

int Quantity (int [] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
    if (array[i] > 0) count++;
}
return count;
}

Console.Write("Введите M: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = createArray (size);
int count = Quantity (array);
Quantity (array);
Console.WriteLine();
Console.WriteLine($"Количество положительных цифр равно: {count}");



//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//Значения b1, k1, b2 и k2 задаются пользователем.
//Задаем метод для поиска кординат точек пересечения

void FindX (double b1, double k1, double b2, double k2){
    double x = 0;
    double y = 0;
    x = (b2-b1)/(k1-k2);
    y = k1*x + b1;
    Console.WriteLine ("Точка с координатами ["+x + "," + y +"]");
}

//Пользовательский ввод данных

Console.WriteLine("input k1:");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input b1:");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k2:");
double k2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input b2:");
double b2=Convert.ToDouble(Console.ReadLine());

//Проверка прямых и запуск метода

if (b1==b2 & k1==k2) Console.WriteLine("Прямые совпадают");
else if (k1==k2) Console.WriteLine("Прямые параллельны друг другу");
else FindX(b1,k1,b2,k2);

*/