namespace TheSlum
{
    public class Injection : Bonus
    {
        private const int InjectionHealthEffectDuration = 3;

        public Injection(string id, int healthEffect, int defenseEffect, int attackEffect) 
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.Timeout = InjectionHealthEffectDuration;
            this.Countdown = InjectionHealthEffectDuration;
            this.HasTimedOut = false;
        }
    }
}
