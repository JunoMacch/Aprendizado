import com.google.gson.Gson;

import java.io.IOException;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;

public class BuscaCep {

    public Cep buscaCep(String cep) throws IOException, InterruptedException {
        URI endereco = URI.create("https://viacep.com.br/ws/" + cep + "/json/");

        HttpClient client = HttpClient.newHttpClient();
        HttpRequest request = HttpRequest.newBuilder()
                .uri((endereco))
                .build();
        try {
            HttpResponse<String> response = client
                    .send(request, HttpResponse.BodyHandlers.ofString());
            return new Gson().fromJson(response.body(), Cep.class);
        } catch (RuntimeException e) {
            throw new RuntimeException("Ocorreu um erro. Por favor utilize apenas numeros, sem espaços ou traços ex: 11111111.");
        }
    }
}
