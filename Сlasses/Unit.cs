namespace Сlasses
{
    public class Unit
    {
        private float _health;
        private float _armor;
        private float _damage;

        private Helm _helm;
        private Shell _shell;
        private Boots _boots;
        private Weapon _weapon;

        Weapon weapon = new Weapon(1f, 10f, "Weapon");

        public string Name { get; }
        public float Health => _health;
        public float Damage { get { return 5; } set { _damage = value; } }

        public float Armor
        {
            get
            {
                return (float)Math.Round(_armor, 2);
            }
            set
            {
                if (value >= 0 || value <= 1)
                {
                    _armor = value;
                }
                else
                {
                    Console.WriteLine("Осторожно");
                    Console.Read();
                }
            }
        }


        public Unit() : this("Unknown Unit")
        {
        }

        public Unit(string name, float health)
        {
            Name = name;
            _health = health;
        }

        public float RealHealth()
        {
            return Health * (1 + Armor);
        }

        public bool SetDamage()
        {
            _health = Health - value * Armor;
            if (Health <= 0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EquipWeapon(Weapon weapon) { _weapon = weapon; }
        public void EquipHelm(Helm helm) { _helm = helm; }
        public void EquipShell(Shell shell) { _shell = shell; }
        public void EquipBoots(Boots boots) { _boots = boots; }

    }
}

