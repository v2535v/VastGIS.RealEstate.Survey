namespace VastGIS.QuickDB.Concrete
{
    public class ViewStyle
    {
        public bool Modal { get; set; }
        public bool Sizable { get; set; }

        public ViewStyle(bool sizable)
        {
            Modal = true;
            Sizable = sizable;
        }

        public ViewStyle()
        {

        }
    }
}