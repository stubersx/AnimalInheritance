namespace AnimalInheritance
{
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }

    class Kangaroo : Animal
    {
        protected double age;
        protected double height;
        protected double weight;

        public void setAge(double age)
        {
            this.age = age;
        }
        public virtual double getAge()
        {
            return age;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public virtual double getHeight()
        {
            return height;
        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }
        public virtual double getWeight()
        {
            return weight;
        }
        public override string getName()
        {
            return base.getName();
        }
        public override string getType()
        {
            return type;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.setName("Alice");
            animal.setType("Sea Otter");
            animal.color = "Gray";
            Console.WriteLine($"Animal Information: \nName: {animal.getName()}\nType: {animal.getType()}\nColor: {animal.color}\n");

            Kangaroo kangaroo = new Kangaroo();
            kangaroo.setName("Hue");
            kangaroo.setType("Kangaroo");
            kangaroo.color = "Brown";
            kangaroo.setAge(4.8);
            kangaroo.setHeight(160.9);
            kangaroo.setWeight(47.2);
            Console.WriteLine($"Kangaroo Information: \nName: {kangaroo.getName()}\nType: {kangaroo.getType()}\nColor: {kangaroo.color}\n" +
                $"Age: {kangaroo.getAge()} years old\nHeight: {kangaroo.getHeight()} cm\nWeight: {kangaroo.getWeight()} kg");
        }
    }
}
