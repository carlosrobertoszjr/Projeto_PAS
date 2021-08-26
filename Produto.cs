public class Produto {

  private int cod_produto;
  private string nome_produto;
  private double preco;
  private double quantidade_estoque;

//GET E SET 

  public void setCodigoProduto(int novo_codigo){
    cod_produto = novo_codigo;
  }

  public int getCodigoProduto(){
    return cod_produto;
  }

  public void setNomeProduto(string nomeP){
    nome_produto = nomeP;
  }

  public string getNomeP(){
    return nomeP;
  }

  public void setPrecoProduto(double preco){
    preco = preco;
  }

  public double getPreco(){
    return preco;
  }

  public void setEstoque(double qtd_estoque){
    quantidade_estoque = qtd_estoque;
  }

  public double getQtdEstoque(){
    return qtd_estoque;
  }

//CONSTRUTOR

  public Produto (int c, string n, double p){

    cod_produto = c;
    nome_produto = n;
    preco = p;
    
  }

//FUNÇÃO

  public bool verificarProduto(double quantidade){
    bool verifica = true;
    if(quantidade < quantidade_estoque){
      verifica = false;
    }
    return verifica;
  }

}

