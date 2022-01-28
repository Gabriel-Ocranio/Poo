namespace Poo.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string TypeHero { get; set; }

        public Hero(){}

        public Hero(string name, int level, string typeHero)
        {
            Name = name;
            Level = level;
            TypeHero = typeHero;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Level: " + Level+ ", TypeHero: " + TypeHero;
        }

        public virtual string Atack()
        {
            return Name + " Atacou com sua espada!";
        }
    }
}