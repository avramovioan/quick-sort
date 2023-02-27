

int[] arr = { 5, 14, 6, 15, 3, 56, 23, 45, 2, 12 };
QuickSort(arr, 0, arr.Length - 1);

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write(arr[i] + " ");
}
System.Console.WriteLine();

static void Swap(int[] array, int indexFirst, int indexSecond)
{
    int temp = array[indexFirst];
    array[indexFirst] = array[indexSecond];
    array[indexSecond] = temp;

}

//left - left boundry of the array: 0
//right - right bountry of the array: arr.Lenght -1
static int Partition(int[] array, int left, int right) // returns the position of the pivot
{
    int pivotPos = left;
    int pivot = array[left];
    for (int i = left + 1; i <= right; i++)
    {
        if (array[i] < pivot)
        {
            pivotPos++;
            Swap(array, i, pivotPos);
        }
    }
    Swap(array, pivotPos, left);
    return pivotPos;
}

static void QuickSort(int[] array, int left, int right)
{
    if (left < right) //this means, that we have an array with at lest 2 elements
    {
        int pivotPos = Partition(array, left, right);
        QuickSort(array, left, pivotPos - 1);
        QuickSort(array, pivotPos + 1, right);
    }
}
