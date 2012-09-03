using System.Web.Mvc;
using StructureMap;
using TryCatchFail.LearnStructureMap.Lesson3.Mvc.DependencyResolution;

[assembly: WebActivator.PreApplicationStartMethod(typeof(TryCatchFail.LearnStructureMap.Lesson3.Mvc.App_Start.StructuremapMvc), "Start")]

namespace TryCatchFail.LearnStructureMap.Lesson3.Mvc.App_Start {
    public static class StructuremapMvc {
        public static void Start() {
            var container = (IContainer) IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}