using System;
using Paint.Keeper;

namespace Paint.iOS.Keeper
{
    public class DrawKeeperFactory : IDrawKeeperFactory
    {
        public IDrawKeeper Create(EDrawKeeperType type)
        {
            switch (type)
                {
                    case EDrawKeeperType.Internal:
                        return new InternalKeeper();
                    default:
                        throw new ArgumentOutOfRangeException(nameof(type), type, null);
                }
        }
    }
}