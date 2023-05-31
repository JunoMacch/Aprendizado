import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.FileWriter;
import java.io.IOException;

public class GeradorDeArquivo {
    public void salvaJson(Cep cep) throws IOException {
        Gson gson = new GsonBuilder().setPrettyPrinting().create();
        FileWriter escrita = new FileWriter(cep.getCep() + ".json");
        escrita.write(gson.toJson(cep));
        escrita.close();
    }
}

