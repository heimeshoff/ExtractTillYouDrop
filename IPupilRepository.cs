namespace ExtractTillYouDrop
{
    public interface IPupilRepository
    {
        Pupil Find(int id);

        void Persist(Pupil pupil);
    }
}