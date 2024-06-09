using System;
using System.Collections.Generic;
using System.Linq;

class Album {

    public Album(string album)
    {

        NomeDoAlbum = album;


    }

    private List<Musica> listaDasMusicasAdicionadas = new List<Musica>(); // aqui foi criado uma lista do tipo Musica vazia, aguardando acessar ou adicionar valores, e que está acessando a classe Musica e todas as musicas que forem adicionadas no Program.cs será armazenado aqui. Private, foi inserido pois apenas essa classe Album poderá ter controle sobre esta lista, se uma classe tentar acessar ela externamente, não conseguirá. Pois para acessar, ou modificar algo nesta lista precisa está dentro das chaves da classe Album
    public string NomeDoAlbum { get;}

    public int DuracaoTotal => listaDasMusicasAdicionadas.Sum(somaDuracao => somaDuracao.Duracao); // aqui a propriedade DuracaoTotal vai para a lista das musicas adicionadas, e  .Sum é uma palavra reservada do c# faz com que soma qualquer valor, em seguida foi declarada uma variável somaDuracao que vai para somaDuracao.Duracao, essa parte significa que pra cada somaDuracao, ou seja, para cada valor que estiver dentro da lista seja somada. e .Duracao, esta acessando a propriedade Duracao, ou seja, pra cada SomaDuracao(valor) que está sendo acessada da propriedade Duracao, realizará uma soma por conta do .Sum e irá armazenar na variável DuracaoTotal

    public void AdicionarMusica(Musica agrupamentoDeMusicas) { // aqui foi criado um método que espera receber um objeto(as musicas adicionadas) do tipo Musica quando for chamado, ou seja,  a instancia Musica foi passado como argumento em parametro quando ele for chamado. O metodo está aguardando um objeto do tipo Musica para que funcione corretamente. (No arquivo program.cs foi chamado este método, e oque será armazenado neste parametro será as variáveis musica1 e musica2


        listaDasMusicasAdicionadas.Add(agrupamentoDeMusicas);// aqui está sendo adicionado musicas na listas, que seria musica1 e musica2

    }
    //aqui foi criado um método ExibirMusicasDoAlbum que chamando este método, o que estiver dentro dele será executado
    public void ExibirMusicasDoAlbum() {

        // aqui está imprimitando na tela a lista de música do album inserido na propriedade NomeDoAlbum
        Console.WriteLine($"Lista de músicas do álbum {NomeDoAlbum}: \n");

        //aqui foi necessário ter um loop para percorrer todos os valores inseridos na lista, onde na codição, só vai ser executada se a listas das musicas adicionadas for  menor do que o indice(posição) da musica adicionada, .Count é necessário para realizar essa contagem, e se for menor, vai icrementar 1 e partir para o próximo.
        for (int i = 0; i < listaDasMusicasAdicionadas.Count; i++) {

            //aqui vai ser exibido na tela as músicas de acordo com a posição dela na lista do tipo Musica, listaDasMusicasAdicionadas[i].Nome significa que a lista das musicas adicionadas vai buscar o indice(posição) dentro dela e acessando a propriedade Nome que já possui um valor inserido
            Console.WriteLine($"Música: {listaDasMusicasAdicionadas[i].NomeDaMusica}");

        }


        Console.WriteLine($"\nPara ouvir este álbum completo você precisa de {DuracaoTotal} segundos");

    }



}