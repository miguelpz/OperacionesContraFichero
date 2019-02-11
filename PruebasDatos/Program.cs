using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using PruebasDatos.Modelos;
using Newtonsoft.Json.Converters;
using PruebasDatos.Servicios;

namespace PruebasDatos
{
    class Program
    {
        

        


        static void Main(string[] args)
        {

            OperacionesService operacionesService = new OperacionesService();
            var json = (string)operacionesService.getAllJson();
            operacionesService.addItem("Otritoo");








            Product product = new Product();
            product.ExpiryDate = new DateTime(2008, 12, 28);

            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

           


        }
    }
}
