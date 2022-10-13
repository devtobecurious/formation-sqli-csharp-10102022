using LesAnimaux;

Animal animal1 = new Chat();
Animal animal2 = new Chien();

List<Animal> animals = new List<Animal>()
{
    animal1,
    animal2,
    new Gorille(),
    null
};

animals.ForEach(animal =>
{
    if (animal != null)
    {
        animal.Dormir();
    }
}
);















foreach (Animal item in animals)
{
    item.Dormir();
}

animal1.Manger(10);

