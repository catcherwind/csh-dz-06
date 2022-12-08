int[] FillArray(int n){
    int[] arr = new int[n];
    for (int i = 0; i < n; i++){
        Console.WriteLine($"Введите {i+1} число");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int FindColZero(int[] arr){
    int col = 0;
    for (int i = 0; i < arr.Length; i ++){
        if (arr[i] > 0) col++;
    }
    return col;
}

Console.WriteLine("Введите число - размер массива");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(m);
Console.WriteLine(String.Join(" ", arr));
int col = FindColZero(arr);
Console.WriteLine($"Количество элементов, больше нуля: {col}");