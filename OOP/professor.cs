using System;

public class Professor : Pessoa {
    String formacao;
    public Professor(){
        
    }
    public void setFormacao(String formacao){
        this.formacao=formacao;
    }
    public String getFormacao() {
        return this.formacao;
    }
}