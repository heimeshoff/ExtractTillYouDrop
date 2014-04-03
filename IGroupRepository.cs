namespace ExtractTillYouDrop
{
    public interface IGroupRepository
    {
        Group Find(int id);

        void Persist(Group group);
    }
}