int[,] array = new int[4,4];
int count = 0;
void method(int[,] array, int count){
    int i = 0;
    int j = 0;
    if(j == 0){
        while(j < array.GetLength(1)){
        count++;
        array[i,j] = count;
        j++;
        }
    }
    j = j - 1;
    while(i < array.GetLength(0) - 1){
        i++;
        count++;
        array[i,j] = count;
    }
    while(j >= 0){
        j--;
        count++; 
        array[i,j] = count;
        if(j == 0){
            break;
        }
    }
    while(i >= 2){
        i--;
        count++; 
        array[i,j] = count;
    }
    j++;
    while(j <= 2){
        count++; 
        array[i,j] = count;
        j++;
    }
   j = j -1;
    while(i != 2){
        i++;
        count++; 
        array[i,j] = count;
    }
    while(j != 1){
        j--;
        count++;
        array[i,j] = count;
    }
}
method(array, count);
for(int i = 0; i < array.GetLength(0); i++){
    for(int j = 0; j < array.GetLength(1); j++){
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine("");
}