using CarRental.Data.Abstracts;

namespace CarRental.Application.Extenstions
{
    public static class CarSizeExtenstion
    {
        public static string ToFriendlyName(this CarSize size) 
        {
            switch (size)
            {
                case CarSize.u4x4:
                    return "Four-Wheel Drive (4*4)";
                case CarSize.SUV:
                    return "Sport Utility Vehicle (SUV)";
                default:
                    return size.ToString();
            }
        }
    }
}
