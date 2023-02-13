// двумерные массивы

// string[,] table = new string[2, 5];

// table[1, 2] = "слово";

// for (inr rows = 0; rows < 5; rows++)
// {
//  for (int columns = 0; columns < 5; columns++) 
//  {
// Console.Writeline($"-{table[rows, columns]}-");
//  }
// }



void PrintArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} ");
    }
    Console.Writeline();
  }
}



void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(0); j++)
    {
      matr[i, j] = new Random().Next(1, 10); // [1. 10]
    }
  }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.Writeline();
PrintArray(matrix);