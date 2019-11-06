using System;
namespace FitnessManager

{
    class Customer
    {
        //Proprietà 
        public string Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public DateTime SubscriptionDate { get; }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }

        private double height;
        public double Height { get => height; set => height = (value > 0) ? value : 0; } //Stesso codice scritto per Age ma con Lambda Expression

        private double weight;
        public double Weight { get => weight; set => weight = (value > 0) ? value : 0; } //Stesso codice scritto per Age ma con Lambda Expression

        
        //Costruttore
        public Customer(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            SubscriptionDate = DateTime.Now;
            Id = createId();
        }

        public Customer(string id, string name, string surname, Gender gender, DateTime subscriptionDate, int age, double height, double weight)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Gender = gender;
            SubscriptionDate = subscriptionDate;
            Age = age;
            Height = height;
            Weight = weight;
        }



        //Metodi
        private string createId()
        {
            //Le stringhe possono essere utilizzate come array di char
            string formattedDate = SubscriptionDate.ToString("ddMMyyyyHHmmss");
            return Name[0].ToString() + Surname[0].ToString() + formattedDate;
            //return Convert.ToString(Name[0])+ Convert.ToString(Surname[0]) + DateTime.Now.ToString("ddMMyyyyHHmmss") ; Stesso codice di sopra ma con altra sintassi
        }

        //Qui sotto il codice risulta più pulito e utilizzabile, nel costruttore si indica cosa prende in pasto il metodo
        //Nel metodo invece gli passo i dati con nomi generici e lui va a prenderseli dal costruttore
        //public Customer(string name, string surname, int age)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Age = age;
        //    SubscriptionDate = DateTime.Now;
        //    Id = createId(Name, Surname, SubscriptionDate);
        //}

        //private string createId(name, surname, date)
        //{
        //    //Le stringhe possono essere utilizzate come array di char
        //    string formattedDate = date.ToString("ddMMyyyyHHmmss");
        //    return name[0].ToString() + surname[0].ToString() + formattedDate;
        //    //return Convert.ToString(Name[0])+ Convert.ToString(Surname[0]) + DateTime.Now.ToString("ddMMyyyyHHmmss") ; Stesso codice di sopra ma con altra sintassi
        //}


        private double CalculateBMI(double height, double weight)
        {
            if(height == 0 || weight == 0)
            {
                return -1;
            }
            else
            {
                double bmi = weight / (height * height);
                return bmi;
            }
        }


        public string Description()
        //{
        //    string bmiString;
        //    double bmi = CalculateBMI(Height, Weight);
        //    if (bmi > 0)
        //    {
        //        bmiString = bmi + "";//Senza la stringa vuota da errore perchè non può convertire double in string, in alternativa su può castare
        //    }
        //    else
        //    {
        //        bmiString = "BMI non disponibile";
        //    }
            
        //    string description = "Dati del cliente: \n" + "Id: " + Id + "\n" 
        //                         + "Nome: " + Name + " " + "Cognome: " + Surname + "\n"
        //                         + "Anni: " + Age + "\n"
        //                         + "Sesso: " + getGenderString(Gender) + "\n"
        //                         + "Altezza: " + Height + " " + "Metri" + "\n" 
        //                         + "Peso: " + Weight + "\n"                                 
        //                         + "BMI: " + CalculateBMI(Height, Weight) + "\n"
        //                         + "Data di iscrizione: " + SubscriptionDate.ToString("dd - MM - yyyy") + "\n";
        //    return description;
        //}


        private string getGenderString(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                        return "Maschio";
                case Gender.Female:
                        return "Femmina";
                case Gender.Unknown:
                    return "Non determinato";
                default:
                    return "Non determinato";
            }
        }


        //Override 
        //public override string ToString()
        //{
        //    {
        //        string bmiString;
        //        double bmi = CalculateBMI(Height, Weight);
        //        if (bmi > 0)
        //        {
        //            bmiString = bmi + "";//Senza la stringa vuota da errore perchè non può convertire double in string, in alternativa su può castare
        //        }
        //        else
        //        {
        //            bmiString = "BMI non disponibile";
        //        }

        //        string description = "Dati del cliente: \n" + "Id: " + Id + "\n"
        //                             + "Nome: " + Name + " " + "Cognome: " + Surname + "\n"
        //                             + "Anni: " + Age + "\n"
        //                             + "Sesso: " + getGenderString(Gender) + "\n"
        //                             + "Altezza: " + Height + " " + "Metri" + "\n"
        //                             + "Peso: " + Weight + "\n"
        //                             + "BMI: " + CalculateBMI(Height, Weight) + "\n"
        //                             + "Data di iscrizione: " + SubscriptionDate.ToString("dd - MM - yyyy") + "\n";
        //        return description;
        //    }
        //}
    }




    public enum Gender: int
    {
        Male = 1,
        Female = 2,
        Unknown = 3
    }

    
}
