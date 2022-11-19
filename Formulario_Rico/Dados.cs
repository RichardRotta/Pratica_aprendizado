using System;
public class Dados
{
    // Atributos
    private String nome;
    private String email;
    private String cpf;
    private DateTime dataNasc;
    private String celular;
    private String recebeInfo;

    // Método Get/Set
    public String getNome() { return this.nome; }
    public void setNome(String p_nome) { this.nome = p_nome; }

    public String getEmail() { return this.email; }
    public void setEmail(String p_email) { this.email = p_email; }

    public String getCpf() { return this.cpf; }
    public void setCpf(String p_cpf) { this.cpf = p_cpf; }

    public DateTime getDataNasc() { return this.dataNasc; }
    public void setDataNasc(DateTime p_dataNasc) { this.dataNasc = p_dataNasc; }

    public String getCelular() { return this.celular; }
    public void setCelular(String p_celular) { this.celular = p_celular; }

    public String getRecebeInfo() { return this.recebeInfo; }
    public void setRecebeInfo(String p_recebeInfo) { this.recebeInfo = p_recebeInfo; }

}