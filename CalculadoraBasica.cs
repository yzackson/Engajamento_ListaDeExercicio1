using System;

class MainClass {

    public static int operacao (int x, int y, char operador) {

        if (operador == '+') {
            return x+y;
        } else if (operador == '-') {
            return x-y;
        } else if (operador == '*') {
            return x*y;
        } else if (operador == '/') {
            return x/y;
        } else {
            Console.WriteLine("Operador errado! Tente novamente.");
            return 0;
        }
    }
    public static void Main () {
        int a, b;
        char op;
        Console.Write("Digite o primeiro número: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite o operador: ");
        op = char.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} {1} {2} = {3}", a, op, b, operacao(a, b, op));

    }
}