namespace Сlasses
{
    public class Helm
    {
        public string Name { get; }

        public float Armor { get; set; }

        public Helm(string name = "Helm")
        {
            Name = name;
        }

        public Helm(float armor, string name = "Helm")
        {
            Armor = armor;
            Name = name;
        }
    }

    public class Shell
    {
        public string Name { get; }

        public float Armor { get; set; }

        public Shell(string name = "Shell")
        {
            Name = name;
        }

        public Shell(float armor, string name = "Shell")
        {
            Name = name;
            Armor = armor;
        }
    }

    public class Boots
    {
        public string Name { get; }

        public float Armor { get; set; }

        public Boots(string name = "Boots")
        {
            Name = name;
        }

        public Boots(float armor, string name = "Boots")
        {
            Name = name;
            Armor = armor;
        }
    }
}

