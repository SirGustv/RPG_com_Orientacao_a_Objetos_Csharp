namespace RPG_com_Orientação_a_Objeto.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com shurikens!";
        }
        public string NAttack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Realizou um ataque furtivo poderoso com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Atacou sendo visto com bônus de " + Bonus;
            }
        }
    }
}