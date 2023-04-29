import java.util.Scanner;

public class ContaBancariaExAluraAula4 {
    public static void main(String[] args) {
        Scanner leitura = new Scanner(System.in);
        String nome = "Junior Macchione";
        String tipoConta = "Corrente";
        double saldoAtual = 2500;
        int opcao = 0;


        System.out.println("**************************");
        System.out.println("Nome do cliente: " + nome);
        System.out.println("Tipo conta: " + tipoConta);
        System.out.println("Saldo inicial " + saldoAtual);
        System.out.println("**************************");

        while (opcao != 4) {
            System.out.println("""
                    
                    Operações
                    
                    1- Consultar saldo
                    2- Receber valor
                    3- Transferir valor
                    4- sair
                    
                    """);
            System.out.println("Digite a opção desejada:");
            opcao = leitura.nextInt();

            if(opcao == 1) {
                System.out.println("O saldo atual é " + saldoAtual);
            } else if (opcao == 2) {
                System.out.println("Informe o valor a receber: ");
                double insSaldo = leitura.nextDouble();
                saldoAtual += insSaldo;
                System.out.println("Saldo atualizado R$ " + saldoAtual);
            } else if (opcao == 3) {
                System.out.println("Informe o valor que deseja transferir: ");
                double insSaldo = leitura.nextDouble();
                if (saldoAtual >= insSaldo) {
                    saldoAtual -= insSaldo;
                    System.out.println("Saldo atualizado R$ " + saldoAtual);
                } else {
                    System.out.println("Não foi possivel realizar sua transferencia, saldo insuficiente");
                }
            } else if (opcao == 4) {
                System.out.println("Encerrando sessão, tenha um ótimo dia!");
            } else {
                System.out.println("Opção invalida, por favor insira uma opção correta!");
            }
        }

    }
}
