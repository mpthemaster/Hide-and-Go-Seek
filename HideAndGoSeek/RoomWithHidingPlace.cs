//A room with a hiding place.
namespace HideAndGoSeek
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        /// <summary>
        /// Sets the hiding place.
        /// </summary>
        /// <param name="name">The name of the room.</param>
        /// <param name="decoration">A unique decoration in the room.</param>
        /// <param name="hidingPlace">A place to hide within the room.</param>
        public RoomWithHidingPlace(string name, string decoration, string hidingPlace)
            : base(name, decoration)
        {
            this.hidingPlace = hidingPlace;
        }

        private string hidingPlace;
        public string HidingPlace
        {
            get { return hidingPlace; }
        }

        //Adds a possible hiding place to the description.
        public override string Description
        {
            get
            {
                return base.Description + " Someone could be hiding " + hidingPlace;
            }
        }
    }
}