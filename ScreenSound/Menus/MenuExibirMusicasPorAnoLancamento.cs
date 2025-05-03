using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuMostrarMusicasPorAnoLancamento : Menu
    {
        public override void Executar(DAL<Artista> artistaDAL)
        {
            base.Executar(artistaDAL);
            ExibirTituloDaOpcao("Mostrar músicas por ano de lançamento");
            Console.Write("Digite o ano para consultar as músicas: ");
            string anoLancamento = Console.ReadLine()!;
            var musicaDAL = new DAL<Musica>(new ScreenSoundContext());
            var listarAnoLancamento = musicaDAL.ListarPor(a => a.AnoLancamento == int.Parse(anoLancamento));

            if (listarAnoLancamento.Any())
            {
                Console.WriteLine($"\nMusicas do Ano {anoLancamento}:");
                foreach(var musica in listarAnoLancamento)
                {
                    musica.ExibirFichaTecnica();
                }
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nNenhuma música foi encontrada para o ano {anoLancamento}");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
