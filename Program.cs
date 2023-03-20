
string[] example = new string[] {"hello", "2", "world",";-)","www"};
int size = 0;
for (int i = 0; i < example.Length; i++)
{
    if (example[i].Length <= 3)
    {
        size++;
    }
}

string[] result = new string [size];
int j = 0;
 for (int i = 0; i < example.Length; i++)
 {
    if (example[i].Length <= 3)
    {
        result[j] = example[i];
        j++;
    }
 }
Console.WriteLine($"[{String.Join("|",example)}]");
Console.WriteLine($"[{String.Join("|",result)}]");

