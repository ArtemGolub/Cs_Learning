int x = int.MaxValue;
int y = unchecked(x + 1);
unchecked
{
    int z = x + 1;
}