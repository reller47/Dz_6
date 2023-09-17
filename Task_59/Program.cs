int x = 0;
int y = 0;
int Del_x = 0;
int Del_y = 0;
int[,] array = new int[4,4];
for(int i = 0; i < array.GetLength(0); i++){
    for(int j = 0; j < array.GetLength(1); j++){
        array[i,j] = new Random().Next(1,10);
    }
}
int min = array[0,0];
for(int i = 0; i < array.GetLength(0); i++){
    for(int j = 0; j < array.GetLength(1); j++){
        Console.Write(array[i,j] + " ");
        if(array[i,j] < min){
            min  = array[i,j];
            x = i;
            y = j;
        }
    }
    Console.WriteLine("");
}
while(Del_x != x){
    Del_x++;
}
while(Del_y != y){
    Del_y++;
}
for(int i = 0;i < array.GetLength(0); i++){
    array[Del_x,i] = 0;
}
for(int i = 0;i < array.GetLength(1); i++){
    array[i,Del_y] = 0;
}
Console.WriteLine("");
Console.WriteLine("");
for(int i = 0; i < array.GetLength(0); i++){
    for(int j = 0; j < array.GetLength(1); j++){
        if(array[i,j] != 0){
            Console.Write(array[i,j] + " ");
        }
    }
    if((array[i,i] != 0) || (array[i,i+1] != 0)){
    Console.WriteLine("");
    }
}