namespace DataInventoryManagement
{
    class program
    {
        public static void Main(string[] args)
        {


            string Path = "E:\\bridgelabs\\DataInventoryManagement\\DataInventoryManagement\\Inventory.json";

            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();

            Rice data = fetchJsonForRice.Read(Path);

            Console.WriteLine("-----------");
            Console.WriteLine("Types of Rice");
            Console.WriteLine("-----------");

            for (int i = 0; i < data.typeOfRice.Count; i++)
            {

                Console.WriteLine(data.typeOfRice[i].name);
                Console.WriteLine(data.typeOfRice[i].weight);
                Console.WriteLine(data.typeOfRice[i].price);
                Console.WriteLine("--------------------------");

                int value = data.typeOfRice[i].weight * data.typeOfRice[i].price;
                Console.WriteLine("The Price of {0} for {1} is", data.typeOfRice[i].name, data.typeOfRice[i].weight, data.typeOfRice[i].price);

            }
            Console.WriteLine("-----------");
            Console.WriteLine("Types of Pluse");
            Console.WriteLine("-----------");

            for (int i = 0; i < data.typeOfPluse.Count; i++)
            {

                Console.WriteLine(data.typeOfPluse[i].name);
                Console.WriteLine(data.typeOfPluse[i].weight);
                Console.WriteLine(data.typeOfPluse[i].price);
                Console.WriteLine("--------------------------");

                int value = data.typeOfPluse[i].weight * data.typeOfPluse[i].price;
                Console.WriteLine("The Price of {0} for {1} is", data.typeOfPluse[i].name, data.typeOfPluse[i].weight, data.typeOfPluse[i].price);
            }
            Console.WriteLine("-----------");
            Console.WriteLine("Types of WheT");
            Console.WriteLine("-----------");

            for (int i = 0; i < data.typeOfWheat.Count; i++)
            {

                Console.WriteLine(data.typeOfWheat[i].name);
                Console.WriteLine(data.typeOfWheat[i].weight);
                Console.WriteLine(data.typeOfWheat[i].price);
                Console.WriteLine("--------------------------");

                int value = data.typeOfWheat[i].weight * data.typeOfWheat[i].price;
                Console.WriteLine("The Price of {0} for {1} is", data.typeOfWheat[i].name, data.typeOfWheat[i].weight, data.typeOfWheat[i].price);
            }
        }
    }
}
