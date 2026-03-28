using Variant1;

var file = new FileResource("report.txt");
var network = new NetworkResource("api.company.local");
var manager = new ResourceManager<Resource>();

manager.Add(file);
manager.Add(network);

manager.OpenAll();

using (var temp = new FileResource("temp.txt"))
{
    temp.Open();
}

manager.CloseAll();

Console.WriteLine("Done.");