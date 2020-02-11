using SimpleRepositoryFrameWork.Interfaces;
using System.Linq;
using xmlRepository;

namespace xmlHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use IOC container Dependancy Injection
            IRepository<movieQuizQuiz> s = new MovieXmlRepository();

            var all=s.List.ToList();
            var updater = all[0];
            s.Add(updater);
            //s.Delete(updater);
        }
    }
}
