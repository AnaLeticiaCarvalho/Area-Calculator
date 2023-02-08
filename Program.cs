double largura, comprimento, precoMquadrado, area, preco;

Console.WriteLine("Digite a largura do terreno:");
largura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o comprimento do terreno:");
comprimento = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do metro quadrado:");
precoMquadrado = double.Parse(Console.ReadLine());

area = largura * comprimento;
preco = area * precoMquadrado;

Console.WriteLine("Área = " + area.ToString("f2"));
Console.WriteLine("Preço = " + preco.ToString("f2"));