namespace Info_G7.OOP
{
    class Zebra : Horse
    {
        new public string GetColor()
        {
            return "Black and white stripes";
        }

        public override string Speak()
        {
            return "Ouch";
        }
    }
}
