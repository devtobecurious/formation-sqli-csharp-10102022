using LesAnimaux;

Animal animal1 = new Chat();
Animal animal2 = new Chien();

List<Animal> animals = new List<Animal>()
{
    animal1,
    animal2,
    new Gorille()
};















foreach (Animal item in animals)
{
    item.Dormir();
}

animal1.Manger(10);

