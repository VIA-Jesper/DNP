namespace Exercise301_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();


            player.Shout("Test");

            player.Shout(1);

            player.Shout(new Enemy() {Damage = 10});


        }
    }
}
