using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjekt
{
    class HappyLiving
    {
       
        List<Lakopark> lakoparkok = new List<Lakopark>();

        public HappyLiving(string fileName)
        {
            
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                while (!streamReader.EndOfStream) {
                    string name = streamReader.ReadLine();
                    string[] line = streamReader.ReadLine().Split(';');
                    int streetNum = int.Parse(line[0]);
                    int houseNum = int.Parse(line[1]);
                    int[,] houses = new int[streetNum, houseNum];
                    string emty = String.Empty;
                    while (String.Empty.Equals(streamReader.ReadLine()))
                    {
                        line = streamReader.ReadLine().Split(';');
                        houses[int.Parse(line[0])-1,int.Parse(line[1])-1] = int.Parse(line[2]);
                    }
                    lakoparkok.Add(new Lakopark(name, streetNum, houseNum, houses));
                }

            }

        }

        internal List<Lakopark> Lakoparkok { get => lakoparkok; set => lakoparkok = value; }
    }
}
