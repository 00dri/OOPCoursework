namespace TheSlum
{
    public class Pill : Bonus
    {
        private const int PillAttackEffectDuration = 1;

        public Pill(string id, int healthEffect, int defenseEffect, int attackEffect) 
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.Timeout = PillAttackEffectDuration;
            this.Countdown = PillAttackEffectDuration;
            this.HasTimedOut = false;
        }
    }
}
