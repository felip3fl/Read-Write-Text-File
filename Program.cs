var address = "E:\\ReadWriteTextFile\\gameList.csv";
var teste = File.ReadAllText(address);
Console.WriteLine(teste);

Console.WriteLine("\n ------------------------------- \n");

lineChanger("TESTE", address, 2);
Console.WriteLine(teste);

void lineChanger(string newText, string fileName, int line_to_edit)
{
    string[] arrLine = File.ReadAllLines(fileName);
    arrLine[line_to_edit - 1] = newText;
    File.WriteAllLines(fileName, arrLine);
}