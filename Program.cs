Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine()!;
string[] main = stroka.Split(' ');
var res = new string[M.Length];
var realSize = 0;()
foreach(var value in M) {
  if (value.Length <= 3) {
    result[realSize] = value;
    realSize++;
  }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);
