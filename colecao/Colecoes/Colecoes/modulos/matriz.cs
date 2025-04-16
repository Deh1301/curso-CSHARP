namespace Colecoes.modulos{
    class Matriz{
        public static void Executar(){
             int[,] notas = {
            {8, 7, 9, 10},  // Notas do aluno 1
            {6, 5, 7, 8},   // Notas do aluno 2
            {9, 8, 10, 9}   // Notas do aluno 3
        };

        // Percorrer os alunos
        for (int i = 0; i < notas.GetLength(0); i++)
        {
            int soma = 0;

            // Percorrer as provas de cada aluno
            for (int j = 0; j < notas.GetLength(1); j++)
            {
                soma += notas[i, j];
            }

            double media = (double)soma / notas.GetLength(1);
            Console.WriteLine($"A média do aluno {i + 1} é {media:F2}");
        }

        }
    }
}