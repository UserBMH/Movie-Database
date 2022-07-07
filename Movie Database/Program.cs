using Movie_Database;

bool loop = true;
bool error = false;

Movie Ali = new Movie("Alien", "Horror");
Movie Pok = new Movie("Pokemon", "Animated");
Movie Big = new Movie("The Big Short", "Drama");
Movie Ali2 = new Movie("Aliens", "Scifi");
Movie Rin = new Movie("The Ring", "Horror");

Movie Cow = new Movie("Cowboy Bepop", "Animated");
Movie Lin = new Movie("Lincoln", "Drama");
Movie Int = new Movie("Interstellar", "Scifi");
Movie Par = new Movie("Paranormal Activity", "Horror");
Movie Arc = new Movie("Arcane", "Animated");

List<Movie> MovieList = new List<Movie>();
MovieList.Add(Ali);
MovieList.Add(Pok);
MovieList.Add(Big);
MovieList.Add(Ali2);
MovieList.Add(Rin);

MovieList.Add(Cow);
MovieList.Add(Lin);
MovieList.Add(Int);
MovieList.Add(Par);
MovieList.Add(Arc);


do
{

    CataCheck();
    Console.WriteLine();
    Console.WriteLine("Continue? y/n");
    Console.WriteLine();
    string loopc = Console.ReadLine();
    if (loopc == "n")
    {
        loop = false;
    }
    
    
}

while (loop == true);



//When the user enters a category, the program should read through all of the movies in the List and display a line for any movie whose category matches the category entered by the user.
//Program takes user input correctly—1 point
//Program gives explicit feedback if user enters invalid category—1 point
//Program iterates through List validly—1 point
//Program only outputs if movie matches category—1 point
//Program loops if user wants to continue.
//Program loops back to ask category again based on user input—1 point

 string CataCheck()
{
    error = false;
    loop = true;
    Console.WriteLine();
    Console.WriteLine("Enter category of film to search...");
    Console.WriteLine("// ANIMATED || DRAMA || HORROR || SCIFI //");
    Console.WriteLine();
    string choice = Console.ReadLine();
    Console.WriteLine();

    foreach (Movie m in MovieList)
    {
        if (m.Category == "Animated" && choice.ToLower().Trim() == "animated")

        {
            Console.WriteLine(m.Title);

        }
        else if (m.Category == "Drama" && choice.ToLower().Trim() == "drama")
        {
            Console.WriteLine(m.Title);

        }
        else if (m.Category == "Horror" && choice.ToLower().Trim() == "horror")
        {
            Console.WriteLine(m.Title);

        }
        else if (m.Category == "Scifi" && choice.ToLower().Trim() == "scifi")
        {
            Console.WriteLine(m.Title);

        }
        
    }
    return ""; 
}