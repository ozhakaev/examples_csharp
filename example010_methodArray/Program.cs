int[] array = { 11, 32, 123, 542, 65, 76, 43, 123, 54 };

int n = array.Length;
int find = 123;

int index = 0;

while (index < n){
    if(array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index++;
}