using System;
using System.Collections.Generic;
using System.Text;

namespace fr_fake_business_register
{
    public class SomeClass
    {
        public SomeClass()
        {
            Id = Guid.NewGuid().ToString();
            Name = names[r.Next(names.Length)];
            Tel = tels[r.Next(tels.Length)];
        }


        public string Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }

        private static Random r = new Random();
        private static string[] names = @"Tod Kroeker
Meggan Beauchamp
Emiko Llanas
Onita Carmack
Ashlea Hales
Nell Ashford
Lorna Bungard
Nada Cooperman
Adolph Gephart
Felicia Yaeger
Cyrstal Buhl
Donovan Kochan
Evelin Aguinaga
Catherina Replogle
Danille Dicks
Ian Rouillard
Josiah Shetley
Isobel Bellamy
Janee Dessert
Trey Zakrzewski".Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        private static string[] tels = @"+1-202-555-0197
+1-202-555-0155
+1-202-555-0134
+1-202-555-0108
+1-202-555-0110
+1-202-555-0195".Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    }
}
