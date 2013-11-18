using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urna.entidades;

namespace Urna.sistema
{
    class ListaCandidatos
    {
        private DeputadoEst[] depEst = new DeputadoEst[4];
        private DeputadoFed[] depFed = new DeputadoFed[4];
        private Governador[] gov = new Governador[4];
        private Presidente[] pres = new Presidente[4];
        private Senador[] sen = new Senador[4];

        private string resposta;
        private string senador1;

        public ListaCandidatos()
        {
            depEst[0] = new DeputadoEst("Branco", "00000");
            depEst[1] = new DeputadoEst("João Mentira", "11111");
            depEst[2] = new DeputadoEst("Zé Preguiça", "22222");
            depEst[3] = new DeputadoEst("Falastrão da Silva", "33333");

            depFed[0] = new DeputadoFed("Blank", "0000");
            depFed[1] = new DeputadoFed("Falsino Soares", "1111");
            depFed[2] = new DeputadoFed("Edu \"Ente\" Souto", "2222");
            depFed[3] = new DeputadoFed("Medonho Lopes", "3333");

            sen[0] = new Senador("Blank", "000");
            sen[1] = new Senador("Bizoño Ordoñez", "111");
            sen[2] = new Senador("Cretino Sérgio", "222");
            sen[3] = new Senador("Jacques Pertallón", "333");

            gov[0] = new Governador("Blank", "00");
            gov[1] = new Governador("Álvaro Senvergoña", "11");
            gov[2] = new Governador("Nestor Quindo", "22");
            gov[3] = new Governador("Taís Condendo", "33");

            pres[0] = new Presidente("Blank", "00");
            pres[1] = new Presidente("Vouty Hobá", "11");
            pres[2] = new Presidente("Dilma Figa Ruçefi", "22");
            pres[3] = new Presidente("Luís Ignácio Mula da Silva", "33");

        }

    }
}
