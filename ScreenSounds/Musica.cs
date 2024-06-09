using System; 

class Musica 
{
    public Musica(Banda artista, string nome) // aqui Banda artista vai ser queen, e o string nome vai receber o nome do album, e logo abaixo passando os valores para a propriedade
    {
        Artista = artista;

        NomeDaMusica = nome;
        
    }




    //Contrutor (opcional, pois no c# já possui um construtor implicito, que seria o new Musica(); <-- este formato já possui um contrutor


    //Argumento método construtor, isso permite que assim que for instanciar um variável de um determinado tipo, que neste caso é música, obrigatoriamente terá que atribuir um valor na hora do instanciamento. Ex: Musica musica1 = new Musica(); 

    // no new Musica() <-- aqui entre parentes que será adicionado um valor, ficando assim: Musica musica1 = new Musica(queen); 

    // E o uso do construtor com parâmetros garante que algumas informações sejam obrigatórias no momento da criação do objeto Musica, tornando o código mais seguro e claro. Assim, ao instanciar um objeto Musica, ou seja, uma variável do tipo múscia como por exemplo: Musica musica1 = new Musica(queen);, é necessário passar um valor para o parâmetro do construtor, garantindo que a informação essencial, no caso a Banda, seja atribuída desde o início da criação do objeto., vai ser aplicado essa mesma ideia para as demais class ou apenas algumas delas.
   
    //breve explicação do que está acontencendo com o construtor
    //[no arquivo program] --> Banda queen = new Banda { NomeDaBanda = "Queen" };

    //[no arquivo program] -->Musica musica1 = new Musica(queen);

    //[no arquivo Muisca] -->public Musica(Banda artista) {


    //    Artista = artista;
    //}

    //Neste, a Banda queen está sendo instanciada e atribuindo um valor a propriedade da classe Banda, sendo assim, ao instanciar a classe Musica e passar em parametro o objeto queen, ele vai ser armazenado no construtor artista que é do mesmo tipo, Banda. e Artista, recebe artista, então o objeto passado como parametro será uma referencia para o Artista. Lá na linha (54) a referência Artista está sendo chamada




    //aqui estão variáveis publicas que podem ser acessadas em qualquer outro arquivo
    public string NomeDaMusica { get; } //quando ver um código e a variável tiver cm a primeria letra Maiúscula e tiver a nomenclatura get; set; pode-se saber que a variável é uma propriedade
    public Banda Artista { get; }
    public int Duracao { get; set; }
    //public bool disponivel; (explicação do porque foi comentado no arquivo Program.cs na linha [34])
    //public bool Disponivel { get; set;} // aqui o get, set, faz com que a variável disponivel, seja uma propriedade do objeto da classe Musica. Ou seja, get e set se refere a escrita e leitura da propriedade disponivel, fazendo com que tenha um controle pra outras classes externas poder alterar alguma coisa nesta propriedade (get é leitura e set escritura) 

    public bool Disponivel { get; set; }

    public Genero Genero { get; set; } // aqui está associando a Classe Genero à classe Musica. 


    // aqui foi adicionado apenas o get, isso significa que, DescricaoResumida pode apenas ler oque estiver nessa variável, se atribuir algum valor manualmente, sem o set; irá da um erro.
    //public string DescricaoResumida { 

    //    // aqui dentro desse get, ao ser acessada esta propriedade que está retornando um valor que seria o nome e o artista, vai mostrar na tela. Sempre que quiser mostrar um valor na tela com mais segurança, controle sobre uma propriedade, basta colocar apenas um get, que seria leitura e dentro desse get retonar um valor de leitura que deseja. Sendo assim, essa propriedade não vai conseguir ser acessada externamente, ou seja, por outras classes. Essa explicação do GET, se aplica a mesma ideia para o SET, a única diferencia é que SET se refere a escritura.
    //    get {
    //        return $"A musica {Nome} pertence à banda {Artista}";

    //    }

    //    }

    public string DescricaoResumida => $"A musica {NomeDaMusica} pertence à banda {Artista}"; // esta linha se trata apenas do GET, conforme a explicação acima aprtir da linha (14) até a linha (23) e logo em seguida da sintaxe ( => ) você pode colocar o valor que deseja mostrar na tela, então caso esteja mexendo em código c# e bater o olho em uma propriedade dessa com a sintaxe ( => ) pode-se saber que se trata apenas de uma leitura, ou seja o GET



    //private bool disponivel; // aqui conforme a explicação da linha de cima, foi trocado de public para private. O motivo foi por mais de segurança, onde apenas a classe Musica consiga ter acesso a este atribuito, apenas a classe Musica consiga modificar os dados. Se tiver uma outra classe fora do scopo de Musica, e tentar acessar o atributo disponível, não vai conseguir.

    //método sendo criado (como se fosse uma função)  
    public void ExibirFichaTecnica() {

        Console.WriteLine($"\nNome: {NomeDaMusica}");
       Console.WriteLine($"Artista: {Artista.NomeDaBanda}");
       Console.WriteLine($"Duração: {Duracao}");

    //    //aqui verificar se a variável Disponivel for true, vai ser executado o if, se for false, executa o bloco de código que está dentro do else
        if(Disponivel) {

         Console.WriteLine("Disponivel no plano");
        }
        
       else {

           Console.WriteLine("Adquira o plano Plus+");
       }
    }

   // //aqui foi criado um método que está recebendo em parametro um valor booleando a ser atribuido. Assim que atribuido, o valor será armazenado na variável disponivel.
   // public void EscreveDisponivel(bool value) {


   //     disponivel = value;
   // } 

   ////aqui foi criado um método, onde ele vai retornar um valor bool, seja true ou false que vai está armazenado no atributo(variável)
   // public bool LerDisponivel() {
   //     return disponivel;

   // }//Com isso feito, a classe Musica possui o total controle dos atributos private.






   
  


}
