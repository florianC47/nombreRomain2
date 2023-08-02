namespace nombreRomain2
{
        public static class Convertisseur
        {

            public static string Convertir(uint chiffre)
            {

                if (chiffre == 1)
                {
                    return "I";
                }
                else if (chiffre == 2)
                {
                    return "II";
                }
                else
                {
                    return "chiffre non reconnu";
                }
            }

        }
    }

