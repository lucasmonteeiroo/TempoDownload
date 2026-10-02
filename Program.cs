Console.WriteLine("=== Tempo de Download ===");

Console.Write("Informe o tamanho do arquivo em MB........: ");
double tamanho = double.Parse(Console.ReadLine()) * 8; // Convertendo de MB para Mb (1 byte = 8 bits)

Console.Write("Informe a velocidade da conexão em Mbps...: ");
double velocidade = double.Parse(Console.ReadLine());

double tempo = (tamanho / velocidade) / 60; // Convertendo de segundos para minutos

Console.WriteLine($"Tempo de download: {tempo:F2} minutos");
