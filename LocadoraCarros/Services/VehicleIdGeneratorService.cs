using LocadoraCarros.Contracts;

namespace LocadoraCarros.Services;

internal class VehicleIdGeneratorService : IIdGenerator
{
    private static int _id = 1;

    public int GenerateId()
    {
        return _id++;
    }
}
