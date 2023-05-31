

import java.io.IOException;
import java.util.Scanner;

public class Principal {
    public static void main(String[] args) throws IOException, InterruptedException {
        Scanner leitura = new Scanner(System.in);
        BuscaCep buscaCep = new BuscaCep();
        String busca = "";


            while (!busca.equalsIgnoreCase("sair")) {

                System.out.println("Informe um CEP para busca");
                busca = leitura.nextLine();

                if (busca.equalsIgnoreCase("sair")) {
                    break;
                }


                try {
                    Cep novoCep = buscaCep.buscaCep(busca);
                    System.out.println(novoCep);
                    GeradorDeArquivo gerador = new GeradorDeArquivo();
                    gerador.salvaJson(novoCep);


                } catch (RuntimeException e) {
                    System.out.println(e.getMessage());
                }

            }
    }
}

