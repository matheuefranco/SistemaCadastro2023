using System;
class Program
{
    struct TipoBanda
    {
        public string nome;
        public string genero;
        public int integrantes;
        public int ranking;
    }// fim struct

    static void addBanda(List<TipoBanda> lista)
    {
        TipoBanda novaBanda = new TipoBanda();// declarando uma variavel do TipoBanda
        Console.Write("Nome da banda:");
        novaBanda.nome = Console.ReadLine();
        Console.Write("Genero da banda:");
        novaBanda.genero = Console.ReadLine();
        Console.Write("Integrantes:");
        novaBanda.integrantes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ranking:");
        novaBanda.ranking = Convert.ToInt32(Console.ReadLine());
        lista.Add(novaBanda);
    }// fim funcao 

    static void listaBandas(List<TipoBanda> lista)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine("\t*** Dados da banda ***");
            Console.WriteLine("Nome:" + lista[i].nome);
            Console.WriteLine("Genero:" + lista[i].genero);
            Console.WriteLine("Integrantes:" + lista[i].integrantes);
            Console.WriteLine("Ranking:" + lista[i].ranking);
        }// fim for
    }// fim lista

    static int menu()
    {
        Console.WriteLine("1-Adicionar banda");
        Console.WriteLine("2-Listar");
        int op = Convert.ToInt32(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        List<TipoBanda> listadeBandas = new List<TipoBanda>();

        while (true)
        {
            int op = menu();
            switch (op)
            {
                case 1:
                    addBanda(listadeBandas);
                    break;
                case 2:
                    listaBandas(listadeBandas);
                    break;
            }// fim switch
            Console.ReadKey();// pausa
            Console.Clear(); // limpa
        }// fim while

        //--------------------
        // Mostrar os dados

        Console.ReadLine();//pause antes de fechar
    }

}// fim do programa