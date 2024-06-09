using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSounds {
    internal class Program {
        static void Main(string[] args) {

            // //logo abaixo foi comentado tudo, pois estou realizando um agrupamento de musicas da classe Album, onde este album terá todos as musicas agrupadas em seu determinado album, os comentários possui explicação de cada linha de código faz

            // //nome
            // //artista
            // //duração
            // // disponivel no plano ou não

            // ///se for necessário criar um novo arquvio, seguindo o passo a passo >> Clique com o botão direito em cima do projeto ScreenSounds (nome do projeto) na aba da diretita >> adicionar >> novo item >> arquivo de código >> nome do conceito (essa parte vc digita um nome)
            // /// o intuito desse arquivo é para organizar o código de forma mais clara e separada. E também para reutilizar o código que estiver dentro deste arquivo. O arquivo criado foi o Musica.cs


            // Musica musica1 = new Musica(); // aqui a variável musica1 é do tipo Musica e está sendo instanciada com o new, podendo guardar, adicionar e acessar valores à variável musica1. O tipo Musica, é uma classe que está em um outro arquivo e esta classe possui vários comando dentro dela, neste caso existe apenas nome, artista, duracao e disponibilidade.  

            // musica1.Nome = "Cristhian"; // aqui estamos acessando o objeto que consta em outro arquivo com o .nome e adicionando um valor a variável musica1, é necessário utilizar este "ponto" >> musica1.nome pois sem ele, o que será mostrado na tela será apenas o tipo dessa variável, que seria "Nome: Musica". Caso queria que um usuário digite, e o que ele digitar for amazenado na variável e adicionando na propriedade Nome, basta apenas digitar o Console.ReadLine(); no valor que está sendo definindo manualmente

            // musica1.Artista = "Cristhian"; //aqui segue o mesmo exemplo da linha de cima

            // musica1.Duracao = 367;// aqui segue o mesmo exemplo das demais linhas de cima

            ////musica1.Disponivel = true; //propriedade - explicação no arquivo Musica.cs na linha(11)

            // Console.WriteLine(musica1.DescricaoResumida);

            // ////musica1.EscreveDisponivel(true);  aqui musica1 esta acessando o método EscreveDisponivel e recebendo um valor true em parametro, no arquivo Musica.cs na linha (16) possui um méotodo que está recebendo um valor booleando e logo abaixo é oque vai ser executado. Ou seja, o valor true que está sendo chamado nesta linha vai ser o valor que será armazenado na variável disponivel que está no método EscreveDisponivel

            // ////Console.WriteLine(musica1.LerDisponivel()); aqui está sendo chamado no console o método LerDisponivel(); Assim que chamado, o que estiver dentro deste método será executado, que neste caso vai retornar um valor bool, true ou false

            // Musica musica2 = new Musica(); // mesma ideia da variável musica1
            // musica2.Nome = "Calypso"; // aqui segue o mesmo exemplo de musica1.nome
            // musica2.Artista = "Ramos";
            // musica2.Duracao = 367; // aqui segue o mesmo exemplo das demais linhas de cima

            // //musica1.Disponivel = false; //propriedade - explicação no arquivo Musica.cs na linha(11)

            // Console.WriteLine(musica2.Nome);

            // ////****************************
            // ////musica2.disponivel = true;  aqui, por enquanto este atributo está vulnerável. Pois no arquivo Musica.cs, o atributo que está comentado public bool disponivel; qualquer outra classe do código conseguiria acessar o atributo, por tanto isso aconteceria uma mudança de dados sem uma autorização e esta linha public bool disponivel está comentada no arquivo Musica.
            // ////*****************************

            // ////musica2.EscreveDisponivel(false); //aqui segue exatamente o mesmo exemplo dado em  musica2.EscreveDisponivel(true);


            // musica1.ExibirFichaTecnica(); //aqui a variável musica1 do Tipo Musica está acessando o método exibirFichaTecnica, ou seja, chamando este método e o que estiver dentro desse método será executado e mostrado na tela, quase o mesmo sentido das demais linhas informando este contexto, a única diferença aqui é que está chamando o método



            // musica2.ExibirFichaTecnica(); //aqui segue a mesma ideia da linha de cima

            //===================================================================================

            //aqui instaciei a variável queen do tipo Banda e atribuindo um valor diretamente na instancia. Pois NomeDaBanda tem dentro da classe Banda.
            Banda queen = new Banda ("Queen"); // caso fique em dúvida sobre este parametro (xxxx) vá para o arquivo Musica, que contem a classe Musica, lá tem uma explicação detalhada sobre o contrutor


            //Aqui está instanciando a classe Album seguido do nome da variável albumDoQueen
            Album albumDoQuenn = new Album("A night at the opera");



            // aqui está instanciando outra classe Musica, seguido da variável musica1
            // caso fique em dúvida sobre este parametro (queen, "texto";) vá para o arquivo Musica, que contem a classe Musica, lá tem uma explicação detalhada sobre o contrutor
            Musica musica1 = new Musica(queen, "Love of my life")
            {

                Duracao = 213,

                Disponivel = true

            };

            // aqui está adicionando uma duração a propriedade Duracao dentro da classe musica, pois a variável que está sendo instanciada é do tipo Musica.



            // aqui está instanciando outra classe Musica, seguido da variável musica2
            Musica musica2 = new Musica(queen, "Bohemian Rhapsody") {

                Duracao = 354,// aqui está adicionando uma duração a propriedade Duracao dentro da classe musica, pois a variável que está sendo instanciada é do tipo Musica.
                Disponivel = false
            }; 
           
            musica2.Duracao = 354; // aqui está adicionando uma duração a propriedade Duracao dentro da classe musica, pois a variável que está sendo instanciada é do tipo Musica.

         
            //aqui a variável albumDoQueen está acessando(chamando) o método(função) AdicionarMusica e passando no parametro a variável musica1 e musica2, essas variáveis serão armazenadas em agrupamentoDeMusicas do tipo Musica na classe Album
            albumDoQuenn.AdicionarMusica(musica1);
            albumDoQuenn.AdicionarMusica(musica2);

            //aqui vai está acessando(chamando) o método, e tudo que estiver dentro dele será executado.
            albumDoQuenn.ExibirMusicasDoAlbum();


            musica1.ExibirFichaTecnica();
            musica2.ExibirFichaTecnica();

            //Aqui possui um método chamado AdicionarAlbum, então, queen está acessando o método AdicionarBanda e passando algumDoQueen como argumento que é o nome da variável instanciada na linha(63) e também a variável queen do tipo Banda está acessando ExibirDiscografia() que está dentro da classe Banda.
            queen.AdicionarAlbum(albumDoQuenn);
            queen.ExibirDiscografia();



            Genero genero = new Genero { GeneroDaMusica = "Rock" }; //aqui está instanciando uma classe Genero, que se chama genero, e está atribuindo um valor diretamente da instancia Genero na propriedade GeneroDaMusica, esta propriedade possui dentro da classe Genero, ou no arquivo Genero.

            Genero genero2 = new Genero { GeneroDaMusica = "Funkzão brabo" };

            //aqui a classe Genero está sendo associada a class Musica, pois musica1 é do tipo Musica, e na class Musica, possui uma propriedade do tipo Genero, ou seja, musica1.Genero, significa que que a variável musica1 está acessando a propriedade que está dentro da classe Genero, e atribuindo um valor a ela, que seria genero (com g minusculo), de acordo com a instancia ali na linha (88), a mesma ideia se aplica para genero2
            musica1.Genero = genero;
            musica2.Genero = genero2;

            Console.WriteLine($"\nO gênero da música {musica1.NomeDaMusica} é: {musica1.Genero.GeneroDaMusica}"); // aqui basicamente a musica1 que é do tipo Musica, esta acessando a propriedade Genero que é do tipo Genero, que está acessando a propriedade GeneroDaMusica que faz parte da class Genero.

            Console.WriteLine($"O gênero da música {musica2.NomeDaMusica} é: {musica2.Genero.GeneroDaMusica}");


            //apartir daqui terá codigos com mínimos de comentário, pois vão ser basicamente a mesma coisa nos demais acima



            Console.ReadLine();


        }
    }
}
