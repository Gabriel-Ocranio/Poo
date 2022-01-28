namespace Poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            TypeHero = heroType;
        }

        public override string Atack()
        {
            return Name + " Lançou um avadakedavra";
        }

        public string Atack(int Bonus)
        {
            if (Bonus > 6)
            {
                return Name + " Lançou um avadakedavra mortal super efetivo " + Bonus;
            }
            else
            {
                return Name + " Lançou um avadakedavra mortal força fraca" + Bonus;
            }


        }
    }
}