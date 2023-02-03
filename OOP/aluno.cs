using System;

public class Aluno : Pessoa {
    String matricula;
    public Aluno() {
        
    }
    public void setMatricula(String matricula){
        this.matricula = matricula;
    }
    public String getMatricula() {
        return this.matricula;
    }
}