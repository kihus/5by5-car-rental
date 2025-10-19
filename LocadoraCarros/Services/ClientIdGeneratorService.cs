using LocadoraCarros.Contracts;

namespace LocadoraCarros.Services
{
    internal class ClientIdGeneratorService : IIdGenerator
    {
        private static int _id = 1;

        public int GenerateId()
        {
            return _id++;
        }
    }
}
