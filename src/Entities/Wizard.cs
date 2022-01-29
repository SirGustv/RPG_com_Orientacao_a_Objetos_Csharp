namespace RPG_com_Orientação_a_Objeto.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia!";
        }

        public string WAttack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou magia de força fraca com bônus de " + Bonus;
            }
        }
    }
}