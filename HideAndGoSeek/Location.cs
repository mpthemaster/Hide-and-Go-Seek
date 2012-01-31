namespace HideAndGoSeek
{
    abstract class Location
    {
        /// <summary>
        /// Sets the name of the location.
        /// </summary>
        /// <param name="name">Name of the location.</param>
        public Location(string name)
        {
            this.name = name;
        }

        private string name;
        public string Name
        {
            get { return name; }
        }

        //What locations are directly connected to this location. I.E. Bathroom ===> Hallway and Master Bedroom.
        public Location[] Exits;

        //A brief description of the location.
        public virtual string Description
        {
            get
            {
                string description = "You're standing in the " + name + ". You see exits to the following places:";

                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;

                    if (i != Exits.Length - 1)
                        description += ", ";
                }

                description += ".";
                return description;
            }
        }
    }
}
