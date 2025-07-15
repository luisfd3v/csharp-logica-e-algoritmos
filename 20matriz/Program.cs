// Matriz
string[,] dados = {
    {"Ralf", "Curitiba"},
    {"Juliana", "Campinas"},
    {"Cleber", "Joinville"},
    {"Marcela", "Londrina"}
};

// Exibir dados
// Console.WriteLine(dados[0, 0]);

foreach (string dado in dados)
{
    Console.WriteLine(dado);
}

// Criar uma matriz 4x2 (quatro linhas e duas colunas)
string[,] dadoos = new string[4, 2];

// Efetuar os cadastros
dadoos[0, 0] = "Ralf";
dadoos[0, 1] = "Curitiba";

dadoos[1, 0] = "Juliana";
dadoos[1, 1] = "Campinas";