public class Endereco {

  private string rua;
  private string bairro;
  private string cidade;
  private string estado;
  private string cep;

  public Endereco(string rua, string bairro, string cidade, string estado, string cep){
    this.rua = rua;
    this.bairro = bairro;
    this.cidade = cidade;
    this.estado = estado;
    this.cep = cep;
  }

  public string getRua(){
    return rua;
  }

  public string getBairro(){
    return bairro;
  }

  public string getCidade(){
    return cidade;
  }

  public string getEstado(){
    return estado;
  }

  public string getCep(){
    return cep;
  }

  public void setRua(string value){
    rua = value;
  }

  public void setBairro(string value){
    bairro = value;
  }

  public void setCidade(string value){
    cidade = value;
  }

  public void setEstado(string value){
    estado = value;
  }

  public void setCep(string value){
    cep = value;
  }

}