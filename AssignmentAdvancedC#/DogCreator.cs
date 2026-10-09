class DogCreator : ICreator<Dog>
{
    public Dog Create()
    {
        return new Dog();
    }
}