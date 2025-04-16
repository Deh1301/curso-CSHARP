namespace ClassesMetodos
{

    struct Ponto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Ponto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Saida()
        {
            System.Console.WriteLine($"O valor de X é {X} e de Y é {Y}");

        }
    }

    class Struct
    {
        public static void Executar()
        {
            Ponto ponto = new Ponto(2, 4);
            ponto.Saida();
            Ponto ponto1 = ponto;
            ponto1 = new Ponto(10,45);
            ponto1.Saida();
        }

    }

}