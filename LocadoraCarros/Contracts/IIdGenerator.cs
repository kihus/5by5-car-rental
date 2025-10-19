namespace LocadoraCarros.Contracts;

internal interface IIdGenerator
{
    private static int _id;

    public static int GeneratorId()
    {
        return _id++;
    }

}
