using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces;

namespace Application.Services
{
    public class ClassService : IClassService
    {
        public IClassRepository _classRepository;
        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public ClassViewModel GetClasses()
        {
            return new ClassViewModel
            {
                Classes = _classRepository.GetClasses()
            };
        }
    }
}