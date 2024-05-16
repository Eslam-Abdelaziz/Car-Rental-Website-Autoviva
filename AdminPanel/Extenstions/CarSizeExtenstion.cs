using AdminPanel.Models;

namespace AdminPanel.Extenstions
{
    public static class CarSizeExtenstion
    {
        public static string ToFriendlyName(this CarSize size)
        {
            switch (size)
            {
                case CarSize.u4x4:
                    return "4*4";
                default:
                    return size.ToString();
            }
        }
    }
}
