using OOP_ProjectEx;


string[] file = ReadFile("Values.csv");
List<Person> people = new List<Person>();


people = GetPeople(file);
PrintPeople(people);



//Read from file and returns array of file lines
static string[] ReadFile(string filename)
{
    string[] lines = File.ReadAllLines(filename);
    return lines;
}



//Get people from file
static List<Person> GetPeople(string[] file)
{
    Dictionary<int, List<string>> file_item = new Dictionary<int, List<string>>();
    List<Person> people = new List<Person>();

    //Get items from file
    for (int i = 0; i < file.Length; i++) file_item.Add(i, GetItems(file[i]));

    //Create person object
    for (int i = 0; i < file.Length; i++)
    {
        Person p;
        string firstname = "", lastname = "", occupation = ""; //Variables to use in switch menu
        int age = 0;
        for (int j = 0; j < file_item[0].Count(); j++)
        {
            //Check what value we are on
            switch (file_item[0][j])
            {
                case "firstname":
                    firstname = file_item[i][j];
                    break;

                case "lastname":
                    lastname = file_item[i][j];
                    break;

                case "Occupation":
                    occupation = file_item[i][j];
                    break;

                case "age":
                    age = int.Parse(file_item[i][j]);
                    break;

                default:
                    Console.WriteLine($"Something went wrong {file_item[0][j]}, is not valid");
                    break;
            }
        }
        p = new Person(firstname, lastname, age, occupation);
        people.Add(p);
    }

    //Return new instance of people
    return new List<Person>(people);
}



//Get items from line and returns list of items
static List<string> GetItems(string line)
{
    string currentWord = "";
    List<string> items = new List<string>();

    //Split line
    foreach (char c in line)
    {
        if (c == ',')
        {
            if (currentWord != "")
            {
                items.Add(currentWord);
                currentWord = "";
            }
        }
        else
            currentWord += c.ToString();
    }
    //Add left over item if it exists
    if (currentWord != "")
        items.Add(currentWord);

    //return new instance of item list
    return new List<string>(items);
}


//Print information about every person and return a list of people
static void PrintPeople(List<Person> people)
{
    foreach (Person p in people)
    {
        Console.WriteLine($"{p.FirsName} {p.LastName} is {p.Age.ToString()} years old," +
            $"and works as a(n) {p.Occupation}");
    }
}





