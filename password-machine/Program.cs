const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
const string specialChar = "!@#$%^&*_-><?";
Random random = new Random();
string specialPass = "";
string lowerPass = "";
string upperPass = "";
for (int i = 0; i < 5; i++ )
{
    int index = random.Next(lowerCase.Length);
    char randomChar = lowerCase[index];
    lowerPass += Char.ToString(randomChar);
}
for (int i = 0; i < 5; i++)
{
    int index = random.Next(upperCase.Length);
    char randomChar = upperCase[index];
    upperPass += Char.ToString(randomChar);
}
for (int i = 0; i < 5; i++)
{
    int index = random.Next(specialChar.Length);
    char randomChar = specialChar[index];
    specialPass += Char.ToString(randomChar);
}
var password1 = upperPass + lowerPass + specialPass;
Console.WriteLine(password1);
char[] passwordChars = password1.ToCharArray();
for (int i = passwordChars.Length - 1; i > 0; i--)
{
    int j = random.Next(i + 1);
    char temp = passwordChars[i];
    passwordChars[i] = passwordChars[j];
    passwordChars[j] = temp;
}
password1 = new string(passwordChars);
Console.WriteLine(password1);
