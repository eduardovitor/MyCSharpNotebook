using System;

public class Pessoa {
    String nome;
    int idade;
    String CPF;
    String sexo;
    String RG;
    public Pessoa(){
        
    }
    public Pessoa(String nome, int idade, String CPF, String sexo, String RG){
        this.nome = nome;
        this.idade = idade;
        this.CPF = CPF;
        this.sexo = sexo;
        this.RG = RG;
    }
    public void setNome(String nome) {
        this.nome = nome;
    }
    public String getNome() {
        return this.nome;
    }
    public void setIdade(int idade) {
        this.idade = idade;
    }
    public int getIdade() {
        return this.idade;
    }
    public void setCPF(String CPF){
        this.CPF = CPF;
    }
    public String getCPF() {
        return this.CPF;
    }
    public void setSexo(String sexo) {
        this.sexo = sexo;
    }
    public String getSexo(){
        return this.sexo;
    }
    public void setRG(String RG) {
        this.RG = RG;
    }
    public String getRG(){
        return this.RG;
    }
}