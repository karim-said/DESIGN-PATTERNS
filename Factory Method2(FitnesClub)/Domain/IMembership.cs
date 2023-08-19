namespace Factory_Method2_FitnesClub_.Domain;

public interface IMembership
{
    string Name { get;}
    string Description { get; set; }

    decimal GetPrice();
}