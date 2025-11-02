using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BnBPosClientNCF35
{
    public enum ItemStates : uint
    {
        New,
        Withdrawn,
        InSale,
        Unsold,
        Sold,
        Rejected,
        Lost,
        CheckedOut,
    }

    public sealed class ItemStateColors
    {
        public static Color Neutral { get { return Color.Yellow; } }
        public static Color Positive { get { return Color.Lime; } }
        public static Color Negative { get { return Color.Orange; } }
        public static Color Bad { get { return Color.Tomato; } }

        public static Color CheckInColor(ItemStates state)
        {
            switch (state)
            {
                case ItemStates.New: return Neutral;
                case ItemStates.Withdrawn: return Neutral;
                case ItemStates.InSale: return Positive;
                case ItemStates.Unsold: return Positive;
                case ItemStates.Sold: return Positive;
                case ItemStates.Rejected: return Negative;
                case ItemStates.Lost: return Bad;
                case ItemStates.CheckedOut: return Positive;
            }
            return Neutral;
        }

        public static Color CheckOutColor(ItemStates state)
        {
            switch (state)
            {
                case ItemStates.New: return Neutral; // should not be shown in checkout
                case ItemStates.Withdrawn: return Neutral;
                case ItemStates.InSale: return Neutral;
                case ItemStates.Unsold: return Neutral;
                case ItemStates.Sold: return Positive;
                case ItemStates.Rejected: return Neutral;
                case ItemStates.Lost: return Bad;
                case ItemStates.CheckedOut: return Positive;
            }
            return Neutral;
        }
    }

}
