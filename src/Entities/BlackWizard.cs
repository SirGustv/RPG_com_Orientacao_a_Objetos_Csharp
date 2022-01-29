namespace RPG_com_Orientação_a_Objeto.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia negra!";
        }

        public string BWAttack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou magia negra super poderosa com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou magia negra leve com bônus de " + Bonus;
            }
        }
    }
}