namespace CountryApp
{
    class CountryDb
    {
        public int id { get; set; }
        public string name { get; set; }

        public string code { get; set; }

        public float area { get; set; }

        public int population { get; set; }

        public int cityId { get; set; }

        public  int regionId { get; set; } 

        public virtual Region region { get; set; }

        public  virtual City city { get; set; }
    }
}
