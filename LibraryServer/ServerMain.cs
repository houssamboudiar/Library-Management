using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using LibraryServer.DataServiceBase;
using LibraryServer.Control;
using System.Data;

namespace LibraryServer
{
    public class ServerMain : MarshalByRefObject
    {
        public static void Main(string[] args)
        {
            try
            {
                TcpChannel cnl = new TcpChannel(1234);
                ChannelServices.RegisterChannel(cnl, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(ManageWorks), "obj", WellKnownObjectMode.Singleton);
                Console.WriteLine("serveur demarrer");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("erreur : " + e);
                Console.ReadLine();
            }
            /*
            ManageWorksDataService m = new ManageWorksDataService();
            ConsultWorksDataService c = new ConsultWorksDataService();
            /*List<string> tags = new List<string>();
            tags.Add("tag1");
            tags.Add("tag2");
            List<string> writers = new List<string>();
            writers.Add("writer1");
            writers.Add("writer2");*/
            //DataRow[] result = table.Select("Size >= 230 AND Sex = 'm'");
            /*foreach (DataColumn col in table.Columns)
            {
                Console.WriteLine("{0}", col);
            }
            /*Boolean h = m.EditWork(7, tags, writers , "titlechanged" , "themechanged" , "book");
            //Console.WriteLine(h);
            code
            titre
            auteurs
            theme
            type
            mots_cle
            */
            /*
            ConsultWorks cw = new ConsultWorks();
            Console.WriteLine(cw.getByTags("tag1").Count);
            Console.WriteLine(cw.getByWriter("writer1").Count);
            Console.WriteLine(cw.getByWriter("writer2").Count);
            foreach (var work in cw.getAllWorks())
            {
                foreach (var ch in work.Writers)
                {
                    Console.WriteLine(ch);
                }
            }
            Console.ReadLine();*/

        }
    }
}
