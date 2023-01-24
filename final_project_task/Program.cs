string[] strArray = { "hello", "2", "world", ":-)" };
int count = 0;
int index = 0;
string temporary = string.Empty;
int i;

for (i = 0; i < strArray.Length; i++)
{
    if (strArray[i].Length <= 3)
    {
        temporary = strArray[index];
        strArray[index] = strArray[i];
        strArray[i] = temporary;
        count++;
        index++;
    }
}

string[] newStrArray = new string[count];

for (i = 0; i < newStrArray.Length; i++)
{
    newStrArray[i] = strArray[i];
}

for (i = 0; i < newStrArray.Length; i++)
{
    Console.Write(newStrArray[i] + " ");
}