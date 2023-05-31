
public class Cep {
    private String cep;
    private String logradouro;
    private String bairro;
    private String localidade;
    private String uf;
    private String ddd;


    public String getCep() {
        return cep;
    }

    public String getLogradouro() {
        return logradouro;
    }

    public String getBairro() {
        return bairro;
    }

    public String getLocalidade() {
        return localidade;
    }

    public String getUf() {
        return uf;
    }

    public String getDdd() {
        return ddd;
    }

    @Override
    public String toString() {
        return "(cep = " + cep + ", logradouro = " + logradouro + ", bairro = " + bairro + ", localidade = " + localidade + ", uf = " + uf + ", ddd = " + ddd + ')';
    }
}



