using System.Collections.Generic;
using System.Linq;

namespace ExtractTillYouDrop
{
    public class GroupService
    {
        private readonly IGroupRepository _repository;
        private readonly IPupilRepository _pupilRepository;

        public GroupService(IGroupRepository repository, IPupilRepository pupilRepository)
        {
            _repository = repository;
            _pupilRepository = pupilRepository;
        }

        public void Add(int id, int pupilId)
        {
            Group group = this._repository.Find(id);
            List<Pupil> pupils = group.GetPupils();
            Pupil addPupil = this._pupilRepository.Find(pupilId);
            if (pupils.Count() < 3)
            {
                bool tmp = false;
                foreach (var pupil in pupils)
                {
                    if (pupil.getId() == addPupil.getId())
                    {
                        tmp = true;
                    }
                }
                if (!tmp)
                {
                    group.AddPupil(addPupil);
                    this._repository.Persist(group);
                }
                else
                {
                    throw new PupilAlreadyInGroupException();
                }
            }
            else
            {
                throw new TooManyPupilsException();
            }
        }
    }
}
