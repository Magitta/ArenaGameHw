namespace ArenaGame
{
    public class Headhunter : Hero
    {
        public Headhunter(string name) : base(name) { }

        public override int Attack()
        {
            int attack = base.Attack();
            return attack + 150;
        }
    }
}