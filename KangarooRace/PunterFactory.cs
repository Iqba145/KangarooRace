using System;
using System.Windows.Forms;

namespace KangarooRace
{
    public class PunterFactory
    {
        public Punter getPunter(String Name, Label MaximumBet, Label bet)
        {
            Punter p;
            switch (Name.ToLower())
            {
                case "iqbal":
                    p = new Iqbal(null, MaximumBet, 50, bet);
                    break;

                case "raj":
                    p = new Raj(null, MaximumBet, 50, bet);
                    break;

                case "sukhdeep":
                    p = new Sukhdeep(null, MaximumBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            p.setPunterName();
            return p;
        }
    }
}
