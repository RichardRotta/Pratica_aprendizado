using System.Security.Cryptography;
using System;

public class Dados
    {
    //atributo
    private string Nome;
    private string Email;
    private string Conf_Email;
    private string CPF;
    private string Celular;
    private ConfigData configdata;


    public Dados()
    {
        this.configdata = new ConfigData();
    }

    //métodos get/set
    public void setNome(string p_nome) { this.Nome = p_nome; }
    public string getNome() { return this.Nome; }

    public void setEmail(string p_email) { this.Email = p_email; }
    public string getEmail() { return this.Email; }

    public void setConf_Email(string p_conf_email) { this.Conf_Email = p_conf_email; }
    public string getConf_Email() { return this.Conf_Email; }

    public void setCPF(string p_CPF) { this.CPF = p_CPF; }
    public string getCPF() { return this.CPF; }

    public void setCelular(string p_Celular) { this.Celular = p_Celular; }
    public string getCelular() { return this.Celular; }

    public void setdia(string p_dia) { this.configdata.dia = p_dia; }
    public string getdia() { return this.configdata.dia; }

    public void setmes(string p_mes) { this.configdata.mes = p_mes; }
    public string getmes() { return this.configdata.mes; }

    public void setano(string p_ano) { this.configdata.ano = p_ano; }
    public string getano() { return this.configdata.ano; }

}
