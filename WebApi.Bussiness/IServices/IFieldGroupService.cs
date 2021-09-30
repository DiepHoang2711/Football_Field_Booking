using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Bussiness.DTO;
using WebApi.Data.Entites;

namespace WebApi.Bussiness.Services
{
    public interface IFieldGroupService
    {
        Task<int> Create(FieldGroupCreateRequest request);

        Task<int> Update(FieldGroupUpdateRequest request);

        Task<int> Delete(int productId);

        Task<ViewModel<GroupField>> GetAllPaging(GetGroupFieldPagingRequest request);
    }
}
