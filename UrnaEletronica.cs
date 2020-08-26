using System;

class MainClass {

    public static string candidatoVencedor (int a, int b, int c) {
        if (a>b && a>c) {
            return "O candidato vencedor é o José Couve";
        } else if (b>c) {
            return "O candidato vencedor é o Joana Bravo";
        } else {
            return "O candidato vencedor é o Roberto Nove";
        }
    }

     public static void Main () {

        int voto;

        int cA = 0;
        int cB = 0;
        int cC = 0;
        int branco = 0;
        int nulo = 0;

        Console.WriteLine("Lista de candidatos:\n33 - José Couve\n25 - Joana Bravo\n10 - Roberto Nove\n0 - Voto branco\n4 - Voto nulo\n\n");
        do {
        Console.WriteLine("Digite o código do seu voto ou -1 para finalizar a votação: ");
        voto = int.Parse(Console.ReadLine());
        Console.WriteLine("Obrigado pelo voto!\n\n");

        if (voto == 33){
            cA++;
        } else if (voto == 25) {
            cB++;;
        } else if (voto == 10) {
            cC++;
        } else if (voto == 0) {
            branco++;
        } else if (voto == 4) {
            nulo++;
        }

        } while (voto != -1);
        
        Console.WriteLine("Resultado da votação\n" + candidatoVencedor(cA, cB, cC) + "\nVotos em branco: {0}\nVotos nulos: {1}", branco, nulo);

    }
}