using Factory_Method2_FitnesClub_.Domain;

namespace Factory_Method2_FitnesClub_.Factories;

internal abstract class MembershipFactory
{
    public abstract IMembership GetMembership();
}