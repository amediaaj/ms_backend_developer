string button = "OJ";

switch(button){
    case "Water":
        Console.WriteLine("Dispensing Water");
        break;
    case "Soda":
        Console.WriteLine("Dispensing Soda");
        break;
    case "Coffee":
        Console.WriteLine("Dispensing Coffee");
        break;
        // create a default case
    default:
        Console.WriteLine("Invalid Option");
        break;
}