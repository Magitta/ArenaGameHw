namespace ArenaGame
{
    public class Nymph : Hero
    {
        public Nymph(string name) : base(name) { }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(47))
            {
                attack *= 4;
            }
            return attack;
        }
    }
}