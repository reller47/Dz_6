void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
      Console.WriteLine("Print matrix C:");
    for(int ii = 0; ii < resultMatrix.GetLength(0); ii++){
        for(int jj = 0; jj < resultMatrix.GetLength(1); jj++){
            Console.Write(resultMatrix[ii,jj]  + "\t");
        }
        Console.WriteLine(); 
    }
}
Console.Write("Colums matrix А = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Rows matrix А = ");
int y1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix_a = new int[x1, y1];
for(int i = 0; i < matrix_a.GetLength(0); i++){
    for(int j = 0; j < matrix_a.GetLength(1); j++){
        Console.Write($"Enter matrix А [{i}, {j}] = ");
        matrix_a[i,j] = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine();  
    }
}
Console.WriteLine("Print matrix A:");
for(int i = 0; i < matrix_a.GetLength(0); i++){
    for(int j = 0; j < matrix_a.GetLength(1); j++){
        Console.Write(matrix_a[i,j]  + "\t");
    }
        Console.WriteLine(); 
}
Console.WriteLine();
Console.Write("Colums matrix B = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Rows matrix B = ");
int y2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix_b = new int[x2, y2];
for(int i = 0; i < matrix_b.GetLength(0); i++){
    for(int j = 0; j < matrix_b.GetLength(1); j++){
        Console.Write($"Enter matrix B [{i}, {j}] = ");
        matrix_b[i,j] = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine();  
    }
}
Console.WriteLine("Print matrix B:");
for(int i = 0; i < matrix_b.GetLength(0); i++){
    for(int j = 0; j < matrix_b.GetLength(1); j++){
        Console.Write(matrix_b[i,j]  + "\t");
    }
        Console.WriteLine(); 
}
Console.WriteLine();
if(x1 != y2){
Console.WriteLine("ERROR ! Columns matrix A != Rows matrix B");
}else{
    int[,] matrix_c = new int[x1, y2];
    MultiplyMatrix(matrix_a, matrix_b, matrix_c);
}