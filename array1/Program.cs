void fillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-100, 100);
        index++;
    }
}

void printArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

fillArray(array);
printArray(array);
System.Console.WriteLine();

int pos = indexOf(array, 24);
System.Console.WriteLine(pos);