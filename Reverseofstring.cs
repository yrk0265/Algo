string str="this is it.";
string Result=string.Empty;
for(int intI=str.Length-1;intI>=0;intI--)
{
   Result+=Convert.ToString(str[intI]);
}
Console.WriteLine(Result);
Result=string.Empty;
for(int intI=0;intI<str.Length;intI++)
{
   Result+=Convert.ToString(str[(str.Length-1) - intI]);
}
Console.WriteLine(Result);
Console.ReadLine();

