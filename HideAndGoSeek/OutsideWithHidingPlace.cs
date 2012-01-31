//A location outside with a hiding place.
namespace HideAndGoSeek
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        /// <summary>
        /// Sets the hiding place at this location outside.
        /// </summary>
        /// <param name="name">The name of the outside location.</param>
        /// <param name="decoration">A unique decoration at this outside location.</param>
        /// <param name="hot">Whether or not it is hot here.</param>
        /// <param name="hidingPlace">A description of what can be hidden in.</param>
        public OutsideWithHidingPlace(string name, string decoration, bool hot, string hidingPlace)
            : base(name, decoration, hot)
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
