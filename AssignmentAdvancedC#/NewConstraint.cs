class NewConstraint
{
   public static T CreateObject<T>() where T : new() 
    {
        return new T();
    }
}