using System.Collections.Generic;
using System.Linq;

namespace ExtractTillYouDrop
{
    public class Group
    {
        private int _id;

        private readonly List<Pupil> _pupils = new List<Pupil>();

        public Group(int id)
        {
            this._id = id;
        }

        public List<Pupil> GetPupils()
        {
            return this._pupils;
        }

        public void AddPupil(Pupil pupil)
        {
           _pupils.Add(pupil);
        }
    }
}