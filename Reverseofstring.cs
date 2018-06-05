string str="this is it.";
string Result=string.Empty;
for(int intI=str.Length-1;intI>=0;intI--)
{
   Result+=Convert.ToString(str[intI]);
}
Console.WriteLine(Result);
Result=string.Empty;
Console.ReadLine();

