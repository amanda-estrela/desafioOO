namespace DesafioDotNET.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        } 

        public BlackWizard(){
            
        }

        public override string Attack(){
            return this.Name + " lançou magia negra";
        }

        public  string Attack(int Bonus){

            if(Bonus > 6){
                return this.Name + " lançou magia negra super efetiva com bonus de " + Bonus;
            } else{
                return this.Name + " lançou magia negra com força fraca com bonus de " + Bonus;
            }
        }
    }
}