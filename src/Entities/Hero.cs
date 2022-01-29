namespace RPG_com_Orientação_a_Objeto.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        }

        public Hero()
        {
            
        }

       public string Name;
       public int Level;
       public string HeroType; 

       public override string ToString()
       {
           return "Nome: " + this.Name + " Level: " + this.Level + " Class: " + this.HeroType;
       }

       public virtual string Attack()
       {
           return this.Name + " Atacou";
       }
    }
}