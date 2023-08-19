using Factory_Method2_FitnesClub_.Domain;
using Factory_Method2_FitnesClub_.Factories;


class Programm
{
    static void Main()
    {
        Console.WriteLine(">>> Welcome to FitnesClub CRM<<<\n");

        Console.WriteLine("> Enter the membership type you would like create:");
        Console.WriteLine("> G - Gym");
        Console.WriteLine("> P - Gym + Pool");
        Console.WriteLine("> T - Personal Training");

        string membershipType = Console.ReadLine();

        MembershipFactory factory = GetFactory(membershipType);

        IMembership membership = factory.GetMembership();

        Console.WriteLine("\n Membership you've just created: \n");

        Console.WriteLine(
            $"\tName\t\t{membership.Name}\n"+
            $"\tDescription:\t{membership.Description}\n"+
            $"\tPrice:\t\t{membership.GetPrice()}");

        Console.ReadLine();

    }

    private static MembershipFactory GetFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "g" => new GymMembershipFactory(100, "Basic membership"),
            "p" => new GymPlusPoolMembershipFactory(250, "Good price membership"),
            "t" => new PersonalTrainingMembershipFactory(400, "Best for professionals"),
            _ => null
        };
}