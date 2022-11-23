Console.WriteLine("Введите пятизначное число:");
string writeTxt = Console.ReadLine()!;
string txtToCheck = writeTxt.ToLower().Replace(" ","");
int leng = txtToCheck.Length;
string result = "не является";

bool IsPalindrome(string p)
{
    int count = 0;
    while (count <= leng)
    {
        if (txtToCheck[count] != txtToCheck[leng - 1]) return false;
        leng--;
        count++;
    }
    return true;
}

if (IsPalindrome(txtToCheck)) result = "является";
Console.WriteLine($"Введенное значение {result} палиндромом");
Console.WriteLine();

