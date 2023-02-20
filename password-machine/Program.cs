const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
const string specialChar = "!@#$%^&*()_-><{}[]?";
Random random = new Random();
string specialPass = "";
string lowerPass = "";
string upperPass = "";
for (int i = 0; i < 4; i++ )
{
    int index = random.Next(lowerCase.Length);
    char randomChar = lowerCase[index];
    lowerPass = Char.ToString(randomChar);
}
for (int i = 0; i < 4; i++)
{
    int index = random.Next(upperCase.Length);
    char randomChar = upperCase[index];
    upperPass = Char.ToString(randomChar);
  //  Console.Write(upperPass);
}
for (int i = 0; i < 4; i++)
{
    int index = random.Next(specialChar.Length);
    char randomChar = specialChar[index];
    specialPass = Char.ToString(randomChar);
  //  Console.Write(specialPass);
}
Console.WriteLine(lowerPass + upperPass + specialPass);
//void Shuffle()
//{
//    password = password + password1 + password2;
//    string strPassword = password;
//    int index = random.Next(password.Length);
//    char randomChar = password[index];
//    password = Char.ToString(randomChar);
//}
//Console.WriteLine(password);
