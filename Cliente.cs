public class Cliente {

  private string nome;
  private Endereco endereco;
  private int cpf;
  private string addCarrinho;
  private double realiza_pg;

  public string getNome(){
   return nome;
  }
  public Endereco getEndereco(){
    return endereco;
  }
  public int getCpef(){
    return cpf;
  }

  //
  public void setNome(string novo_nome){
    nome = novo_nome;
  }
  public void setEndereco(Endereco novo_endereco){
    endereco = novo_endereco;
  }
  public void setCpf(int novo_cpf){
   cpf = novo_cpf;
  }

  public cliente(string aC, double rPg, string Nome, int Cpf, Endereco end){
    addCarrinho = aC;
    realiza_pg = rPg;
    nome = Nome;
    cpf = Cpf;
    enderco = end;
  }
  
}