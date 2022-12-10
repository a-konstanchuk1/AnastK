// чтобы не заморачиваться с проверкой ввода на числовой тип, определяем размер массива в коде
int n = 6;

// сразу определяем индексы для обхода массивов и сами массивы
int Index = 0;
int IndexOut = 0;
string[] ArrayIn = new string[n];
string[] ArrayOut = new string[n];

// Считываем массив вводных данных
while (Index < n)
{
    Console.Write("Введите элемент массива ");
    Console.WriteLine(Index + 1);
    ArrayIn[Index] = Console.ReadLine();
    Index++;
}

// обнуляем индекс, и формируем выходной массив
Index = 0;
while (Index < n)
{
    if(ArrayIn[Index].Length <= 3) 
    {
        ArrayOut[IndexOut] = ArrayIn[Index];
        IndexOut++;
    }
    Index++;
}

// определяем количество найденных элементов, чтобы не выводить пустые строки,
// обнуляем индекс, рисуем пустую строку для красоты
int LengthOut = IndexOut;
IndexOut = 0;
Console.WriteLine("");

// выводим массив-результат
while (IndexOut < LengthOut)
{
    Console.Write(ArrayOut[IndexOut]);
    if(IndexOut != (LengthOut - 1)) Console.Write(",   ");
    IndexOut++;
}


