namespace ITSchool.AppUtilities
{
    public abstract class ApplicationBase
    {
        public static List<ApplicationBase> Applications = new List<ApplicationBase>();

        public string Cerinta;

        protected ApplicationBase()
        {

        }
        public abstract void Launch();
    }
}