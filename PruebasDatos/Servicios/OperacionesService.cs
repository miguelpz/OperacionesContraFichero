using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PruebasDatos.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDatos.Servicios
{
    public class OperacionesService
    {
        private JObject rss;

        private string anterior;

        private string DIRECTORY_PATH;

        private string FileDirectory;

        public OperacionesService()
        {

            try
            {
                DirectoryInfo path = new DirectoryInfo(Directory.GetCurrentDirectory());

                anterior = path.Parent.Parent.FullName;

                DIRECTORY_PATH = anterior + "\\FicherosJson";

                FileDirectory = DIRECTORY_PATH + "\\datosprueba.json";

                using (StreamReader reader = File.OpenText(@FileDirectory))
                {
                    rss = (JObject)JToken.ReadFrom(new JsonTextReader(reader));

                }
            }catch (Exception ex){

                throw new Exception("Error al leer el json");
            }

            
        }

        public string getAllJson()
        {

            return JsonConvert.SerializeObject(rss);
            
        }

        public void addItem(string titulo)
        {
            Item elemento = new Item();
            elemento.title = titulo;
            JObject elementoSer = JObject.FromObject(elemento);


            JArray array = (JArray)rss["channel"]["item"];

            array.Add(elementoSer);

            using (StreamWriter file = File.CreateText(@FileDirectory))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                rss.WriteTo(writer);
            }




















        }






    }
}
