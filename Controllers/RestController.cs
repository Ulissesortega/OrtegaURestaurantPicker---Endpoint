//Name: Ulises Ortega
//Date: 10.26.22
//Project: Restaurant Picker
//Description: This Endpoint presents a menu of 3 types of food under under 1,2 or 3, depending on that the user input in th url a type of food with a ramdom restaurant will be outputed on screen.

/*Description: In this endpoint the user is presented with a menu of three type of foods base on the numbers 1,2 or 3
Once the user input the number a random restaurant will be recomended
The link below repesent the structure to be follow in order for the Endpoint to work
https://localhost:7123/rest/pick/Number
In the link above when you Run and Debig this Endpoint the local host will change, you only needs to replace the Word Number with 1, 2 or 3, one single number at a time, 
you should get the following output: You selected Food ~  You Should try: name of recomended restaurant.
*/

using Microsoft.AspNetCore.Mvc;

namespace OrtegaURestaurantPicker___Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class RestController : ControllerBase
{
    [HttpGet]
    [Route("pick")]

    public string selection()
    {
        return "1 American Food \n2 - Japanese Food \n3 - Mediterranian Food";
    }

    [HttpGet]
    [Route("pick/{number1}")]
    public string Math(int number1)
    {
        //int convertNum1 = Convert.ToInt32(number1);
        string answer = "";
        string message = "";

        if (number1 == 1)
        {
            string[] American = { "Cast Iron", "Cracker Barrel", "American Waffle", "Black Bear", "Country Boys", "Bob's at the marina", "Denny's", "LumberJack's Restaurant", "BBC Eat's", "Top Flight Grill & Cathering" };
            message = "You selected American Food ~ " ;
            Random random = new Random();
            int randomOut = random.Next(0, 11);
            answer = American[randomOut];
        }
        if (number1 == 2)
        {
            string[] Japanese = { "Misaki Sushi & Bar", "Cocoro Bistro Sushi & Bar", "Icchiban Teppanyanki & Sushi", "Mikasa Japanese Bistro", "Hana Sushi", "ShoMi Japanese Cusisine", "Shogun Japanese Restaurant", "Shogun Japanese Restaurant", "Matsuyama Restaurant", "Sakana Japanese Bistro"};
            message = "You Selected Japanese Food ~ ";
            Random random = new Random();
            int randomOut = random.Next(0, 11);
            answer = Japanese[randomOut];
        }
        if (number1 == 3)
        {
            string[] Mediterranian = { "Kabob & Gyro House", "Go Falafel Greek Food", "Yasoo Yani Restaurant", "Yasoo Yani Restaurant", "Super Mediterranean Bistro", "Kabob & Gyro Grill", "Yafa Hummus", "Zanga Mediterranean Cuisine", "Skewers Kabob House", "Mazaa Kabob House" };
            message = "You selected Mediterranian Food ~ ";
            Random random = new Random();
            int randomOut = random.Next(0, 11);
            answer = Mediterranian[randomOut];
        }
        return $"{message} You Should try: {answer}";
    }
}
