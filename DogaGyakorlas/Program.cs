namespace DogaGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member("Vendel", 11, true);
            Member member2 = new Member("Gaspi", 20, true);
            Member member3 = new Member("Kuli", 10, false);

            Console.WriteLine($"{member1.Name} {member1.Age}");
            Console.WriteLine($"{member2.Name} {member2.Age}");
            Console.WriteLine($"{member3.Name} {member3.Age}");

            member1.CheckIn();
            member2.CheckIn();
            member3.CheckIn();

           
            Console.WriteLine(member1.Describe());
            Console.WriteLine(member2.Describe());
            Console.WriteLine(member3.Describe());

            Membership berlet = new Membership(member1, 100, 10);
            Membership berlet2 = new Membership(member2, 100, 10);

            Console.WriteLine(berlet.TotalCost());
            berlet.Extend(5);
            Console.WriteLine(berlet.TotalCost());

            Console.WriteLine($" ppv {berlet.PricePerVisit()}");
            Console.WriteLine(berlet2.PricePerVisit());

            Gym gym = new Gym("GymTronic");
            gym.AddMembership(berlet);
            gym.AddMembership(berlet2);

            Console.WriteLine($"az edzoterem teljes bevetel: {gym.TotalIncome()}");

            Console.WriteLine(gym.MostActive().Describe());
            //Console.WriteLine(gym.BestValue());

            Console.WriteLine($"{gym.BestValue().Owner.Name}: {gym.BestValue().PricePerVisit()} Ft/alkalom");


        }
    }
}
