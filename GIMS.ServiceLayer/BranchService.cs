using GIMS.Entities;
using GIMS.Repository;
using GIMS.ServiceLayer.Common;


namespace GIMS.ServiceLayer
{
    public class BranchService : ServiceBase<Branch>, IBranchService
    {
        private IBranchRepository _branchRepository;


        public BranchService(IBranchRepository repository)
            : base(repository)
        {
            _branchRepository = repository;
        }
    }

    public interface IBranchService : IService<Branch>
    {
        
    }
}