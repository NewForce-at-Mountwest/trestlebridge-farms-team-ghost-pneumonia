using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<PlowedField> PlowedFields  {get;} = new List<PlowedField>();

        public List<NaturalField> NaturalFields  {get;} = new List<NaturalField>();

        public List<ChickenHouse> ChickenHouses  {get;} = new List<ChickenHouse>();

        public List<DuckHouse> DuckHouses  {get;} = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public override string ToString()
        {
            //Creates a new string
            StringBuilder report = new StringBuilder();

            //Goes through every GrazingField in the part and calls its ToString() function, adding it to the report string
            GrazingFields.ForEach(gf => report.Append(gf));
            PlowedFields.ForEach(gf => report.Append(gf));
            NaturalFields.ForEach(gf => report.Append(gf));
            ChickenHouses.ForEach(gf => report.Append(gf));
            DuckHouses.ForEach(gf => report.Append(gf));

            //Returns the report string
            return report.ToString();
        }

        
        public void AddPlowedField (PlowedField plowedField)
        {
            PlowedFields.Add(plowedField);
        }

           public void AddNaturalField (NaturalField naturalField)
        {
            NaturalFields.Add(naturalField);
        }
        
             public void AddChickenHouse (ChickenHouse chickenHouse)
        {
            ChickenHouses.Add(chickenHouse);
        }

              public void AddDuckHouse (DuckHouse DuckHouse)
        {
            DuckHouses.Add(DuckHouse);
        }
 
    }
}