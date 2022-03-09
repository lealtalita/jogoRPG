namespace Projeto_jogo_RPG.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int level, string HeroType){
            this.Name = Name;
            this.Level = level;
            this.HeroType = HeroType;
        }

        public Hero(){
            
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " Atacou com a sua espada";
        }
    }
}