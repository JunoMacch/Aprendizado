import java.util.Random;
import java.util.Scanner;

public class JogoDeAdivinhação {
    public static void main(String[] args) {
        Scanner leitura = new Scanner(System.in);
        Random randomNumber = new Random();
        int numeroAleatorio = randomNumber.nextInt(100);
        int palpite = 0;
        System.out.println(numeroAleatorio);

        for (int tentativa = 0; tentativa < 5 ; tentativa++) {
            System.out.println("Bem vindos ao jogo de adivinhação de números!");
            System.out.println("Por favor dê seu palpite de 1 a 100! Digite -1 se quiser encerrar a aplicação");
            palpite = leitura.nextInt();

            if(palpite == numeroAleatorio) {
                System.out.println("Parabéns você acertou!");
                break;
            } else if (palpite == -1) {
                System.out.println("Tchau Tchau!");
                break;
            } else if (tentativa == 4){
                System.out.println("Que pena suas tentativas acabaram. O número era " + numeroAleatorio);
            } else if (palpite < numeroAleatorio) {
                System.out.println("O número digitado é menor que o número gerado");
            } else {
                System.out.println("O número digitado é maior que o número gerado");
            }
        }

    }
}
