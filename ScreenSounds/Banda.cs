using System;
using System.Collections.Generic;

class Banda {

    //construtor
    public Banda(string nome)
    {
        NomeDaBanda = nome;
    }

    //aqui basicamente está criando uma lista do tipo album, criando a propriedade NomeDaBanda na classe Banda, e está adicionadno uma banda na lista AlbumsDaBanda, o método está aguardando um argumento que será armazenado na variável albumDaBanda. E logo após de receber este argumento, será adicionado na lista albumsDaBanda. Logo após, tem um método chamado ExibirDiscografia, que de início informa a discografia na tela e o nome da banda, logo após isso tem um loop for, que vai percorrer toda a lista de albumsDaBanda e icrementar 1, logo depois vai mostrar na tela o indice (posicao da banda na lista) e acessar o nome da propriedade (NomeDoAlbum) que está dentro da classe Album, depois vai pegar a posicao da banda pelo indice da lista e acessar a propriedade  (duracaoTotal) que está dentro da classe Album
    private List<Album> albumsDaBanda = new List<Album>();
        
        
        
        public string NomeDaBanda { get; }
    


    public void AdicionarAlbum(Album albumDaBanda) {
   
    
        albumsDaBanda.Add(albumDaBanda);
    
    
    }

    public void ExibirDiscografia() {


        Console.WriteLine($"\nDiscografia da banda {NomeDaBanda}");


        for (int i = 0; i < albumsDaBanda.Count; i++) {
            Console.WriteLine($"Álbum: {albumsDaBanda[i].NomeDoAlbum} ({albumsDaBanda[i].DuracaoTotal})");
        }
    }




}





