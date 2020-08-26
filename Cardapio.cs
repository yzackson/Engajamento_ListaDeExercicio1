using System;

class MainClass {

    public static double somaCardapio (int cod) {
        switch (cod) {
            case 100:
                return 1.70;
                break;
            case 101:
                return 2.30;
                break;
            case 102:
                return 2.60;
                break;
            case 103:
                return 2.40;
                break;
            case 104:
                return 2.50;
                break;
            case 105:
                return 1.0;
                break;
            default:
                return 0.0;
                break;
        }
    }

    public static void Main() {
        int codigo;
        double valorTotal = 0.0;

        Console.WriteLine("CARDAPIO\n100 Cachorro quente R$ 1,70\n101 Bauru Simples   R$ 2,30\n102 Bauru com ovo   R$ 2,60\n103 Hamburguer      R$ 2,40\n104 Cheeseburguer   R$ 2,50\n105 Refrigerante    R$ 1,00");

        do {
            Console.WriteLine("Digite o código do produto ou -1 para finalizar:");
            codigo = int.Parse(Console.ReadLine());
            valorTotal += somaCardapio(codigo);
        } while (codigo != -1);

        Console.WriteLine("O valor total do pedido é R$" + valorTotal);
        
    }

}