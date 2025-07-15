// // Vetor de nomes
// string[] nomes = { "Ralf", "Juliana", "Cleber", "Marcela" };

// // Exibir os nomes individualemnte através da posição
// Console.WriteLine(nomes[0]);
// Console.WriteLine(nomes[1]);
// Console.WriteLine(nomes[2]);
// Console.WriteLine(nomes[3]);

// // Laço para exibir todos os nomes
// for (int indice = 0; indice < 4; indice++)
// {
//     Console.WriteLine(nomes[indice]);
// }

// Criar um vetor para armazenar até 4 nomes
string[] nomes = new string[4];

// Efetuar o cadastro de 4 nomes
nomes[0] = "Ralf";
nomes[1] = "Juliana";
nomes[2] = "Cleber";
nomes[3] = "Marcela";

// Alterar um registro
nomes[2] = "Leonardo";

// Remover um registro
nomes[1] = null;