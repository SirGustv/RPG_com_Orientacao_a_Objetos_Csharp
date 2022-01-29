namespace RPG_com_Orientação_a_Objeto.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Atacou com a espada!";
        }
        public string KAttack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Efetuou um ataque com espada pesada com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Efetuou um ataque com espada leve com bônus de " + Bonus;
            }
        }
    }
}