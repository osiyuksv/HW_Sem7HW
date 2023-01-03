// заполнить спирально по возрастанию 
// массив 4 на 4

int[,] matrix = new int[4, 4];
int unicNum = 0;

  unicNum ++;      
  matrix[0, 0] = unicNum;

  unicNum ++;
  matrix[0, 1] = unicNum;

  unicNum ++;
  matrix[0, 2] = unicNum;

  unicNum ++;
  matrix[0, 3] = unicNum;

  unicNum ++;
  matrix[1, 3] = unicNum;      

  unicNum ++;
  matrix[2, 3] = unicNum;  

  unicNum ++;
  matrix[3, 3] = unicNum;  

  unicNum ++;
  matrix[3, 2] = unicNum;  

  unicNum ++;
  matrix[3, 1] = unicNum;  
  
  unicNum ++;
  matrix[3, 0] = unicNum; 

  unicNum ++;
  matrix[2, 0] = unicNum; 

  unicNum ++;
  matrix[1, 0] = unicNum; 

  unicNum ++;
  matrix[1, 1] = unicNum; 

  unicNum ++;
  matrix[1, 2] = unicNum; 

  unicNum ++;
  matrix[2, 2] = unicNum; 

  unicNum ++;
  matrix[2, 1] = unicNum; 


  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
  }

