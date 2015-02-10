namespace TheSlum.GameEngine
{
    using System;

    public class ExtendedEngine : Engine
    {
        private const int WarriorDefaultHealthPoints = 200;
        private const int WarriorDefaultDefensePoints = 100;
        private const int WarriorDefaultAttackPoints = 150;
        private const int WarriorDefaultRange = 2;
        private const int MageDefaultHealthPoints = 150;
        private const int MageDefaultDefensePoints = 50;
        private const int MageDefaultAttackPoints = 300;
        private const int MageDefaultRange = 5;
        private const int HealerDefaultHealthPoints = 75;
        private const int HealerDefaultDefensePoints = 50;
        private const int HealerDefaultHealingPoints = 60;
        private const int HealerDefaultRange = 6;

        private const int ShieldHealthEffect = 0;
        private const int ShieldDefenseEffect = 50;
        private const int ShieldAttackEffect = 0;
        private const int AxeHealthEffect = 0;
        private const int AxeDefenseEffect = 0;
        private const int AxeAttackEffect = 75;

        private const int InjectionHealthEffect = 200;
        private const int InjectionDefenseEffect = 0;
        private const int InjectionAttackEffect = 0;

        private const int PillAttackEffect = 100;
        private const int PillDefenseEffect = 0;
        private const int PillHealthEffect = 0;

        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Character newCharacter;
            switch (inputParams[1].ToLower())
            {
                case "warrior":
                    newCharacter = new Warrior(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        WarriorDefaultHealthPoints,
                        WarriorDefaultDefensePoints,
                        WarriorDefaultAttackPoints,
                       (Team)Enum.Parse(typeof(Team), inputParams[5], true),
                        WarriorDefaultRange);
                    this.characterList.Add(newCharacter);
                    break;
                case "mage":
                    newCharacter = new Mage(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        MageDefaultHealthPoints,
                        MageDefaultDefensePoints,
                        MageDefaultAttackPoints,
                       (Team)Enum.Parse(typeof(Team), inputParams[5], true),
                        MageDefaultRange);
                    this.characterList.Add(newCharacter);
                    break;
                case "healer":
                    newCharacter = new Healer(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        HealerDefaultHealthPoints,
                        HealerDefaultDefensePoints,
                        HealerDefaultHealingPoints,
                       (Team)Enum.Parse(typeof(Team), inputParams[5], true),
                        HealerDefaultRange);
                    this.characterList.Add(newCharacter);
                    break;
                default:
                    break;
            }
        }

        protected new void AddItem(string[] inputParams)
        {
            var characterToAcceptIitem = GetCharacterById(inputParams[1]);
            Item itemToAdd;
            switch (inputParams[2])
            {
                case "axe":
                    itemToAdd = new Axe(inputParams[3], AxeHealthEffect, AxeDefenseEffect, AxeAttackEffect);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "shield":
                    itemToAdd = new Shield(inputParams[3], ShieldHealthEffect, ShieldDefenseEffect, ShieldAttackEffect);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "injection":
                    itemToAdd = new Injection(inputParams[3], InjectionHealthEffect, InjectionDefenseEffect, InjectionAttackEffect);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "pill":
                    itemToAdd = new Pill(inputParams[3], PillHealthEffect, PillDefenseEffect, PillAttackEffect);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                default:
                    break;
            }
        }

        public override void Run()
        {
            InitializeTimeoutItems();
            ProcessItemTimeout(timeoutItems);

            base.Run();
        }

    }
}