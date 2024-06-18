var address = "E:\\ReadWriteTextFile\\gameList.csv";
var teste = File.ReadAllText(address);
Console.WriteLine(teste);

Console.WriteLine("\n ------------------------------- \n");

lineChanger("NEW*", address, 2);

var testeUpdate = File.ReadAllText(address);
Console.WriteLine(testeUpdate);

void lineChanger(string newText, string fileName, int line_to_edit)
{
    string[] arrLine = File.ReadAllLines(fileName);
    arrLine[line_to_edit ] = arrLine[line_to_edit ] + newText;
    File.WriteAllLines(fileName, arrLine);
}