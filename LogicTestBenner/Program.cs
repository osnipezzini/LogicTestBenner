using LogicTest.Common;

var network = new Network(10);

network.Connect(1, 2);
network.Connect(6, 2);
network.Connect(2, 4);
network.Connect(5, 8);

string isConnected(int source, int target)
    => network.Query(source, target) ? "Conectado" : "Desconectado";

Console.WriteLine($"1 e 6 estão {isConnected(1, 6)}");
Console.WriteLine($"6 e 4 estão {isConnected(6, 4)}");
Console.WriteLine($"7 e 4 estão {isConnected(7, 4)}");