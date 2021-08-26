class Compra {

  private int codigo_compra;
  private string nome_produto;
  private string data;
  private double valor_compra;
  private string forma_pag;

  // Essa aqui seria melhor para os produtos na Compra
  private List<Produto> listaProdutos;


  //SET
  public void setCodigo(int cod){
    codigo_compra = cod;
  }
  public void setNome(string nome){
    nome_produto = nome;
  }
  public void setData(string dat){
    data = dat;
  }
  public void setValorC(double valor){
    valor_compra = valor;
  }
  public void setForma(string forma){
    forma_pag = forma;
  }
  public void setLista(List<Produto> lista){
    listaProdutos = lista;
  }


  //GET
  public int getCodigo(){
    return codigo_compra;
  }
  public string getNome(){
    return nome_produto;
  }
  public string getData(){
    return data;
  }
  public double getValorC(){
    return valor_compra;
  }
  public verificarPg(){
    return forma_pag;
  }

  //CONSTRUTOR
  public Compra (int c, string n, string d, v double, f string, List<Produto> l ){
    codigo_compra = c;
    nome_produto  = n;
    data          = d;
    valor_compra  = v; 
    forma_pag     = f;
    listaProdutos = l;
  }

  public calcValorVenda(double valor_prod, int quant){
    double total = valor_prod * quant;
  }


}