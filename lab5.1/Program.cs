
char[,] matrix = new char[5, 4]
{
            { '+', 'a', '*', 'b' },
            { 'c', '+', 'd', '*' },
            { '*', 'e', '+', 'f' },
            { 'g', 'h', '*', 'i' },
            { '+', 'j', 'k', '+' }
};
int plusCount = 0;
int starCount = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (matrix[i, j] == '+')
        {
            plusCount++;
        }
        else if (matrix[i, j] == '*')
        {
            starCount++;
        }
    }
}
Console.WriteLine($"Символ '+' встречается: {plusCount} раз");
Console.WriteLine($"Символ '*' встречается: {starCount} раз");