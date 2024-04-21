namespace ClassLibraryForTask2
{
    public class Aircraft
    {
        public string Name { get; private set; }
        public bool IsTakingOff { get; set; }

        public Aircraft(string name)
        {
            Name = name;
        }
    }
}
