using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Utilities.Exceptions;
using WebApi.Bussiness.DTO;
using WebApi.Bussiness.IServices;
using WebApi.Data.EF;
using WebApi.Data.Entites;

namespace WebApi.Bussiness.Services
{
    public class FieldGroupService : IFieldGroupService
    {
        private readonly WebApiDbContext _context;
        private readonly IStorageService _fileStorageService;
        public FieldGroupService(WebApiDbContext context, IStorageService fileStorageService)
        {
            _context = context;
            _fileStorageService = fileStorageService;
        }
        public async Task<int> Create(FieldGroupCreateRequest request)
        {
            var groupField = new GroupField()
            {
                Address = request.Address,
                Name = request.Name,
                Status = request.Status,
            };

            if(request.Image != null)
            {
                groupField.ImagePath= await this.SaveFile(request.Image);
                groupField.ImageName = request.ImageName;
            }
            await _context.GroupFields.AddAsync(groupField);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int groupFieldtId)
        {
            var groupFied = await _context.GroupFields.FindAsync(groupFieldtId);
            if(groupFied == null)
            {
                throw new WebException($"Cannot find a product with ID : {groupFied}");
            }
             _context.GroupFields.Remove(groupFied);

            return await _context.SaveChangesAsync(); 
        }
        public async Task<ViewModel<GroupField>> GetAllPaging(GetGroupFieldPagingRequest request)
        {
            //Select
            var sql =  _context.GroupFields.Where(g => g.Name.Contains(request.Keyword));

            //Paging
            int totalRecord =  await sql.CountAsync();

            var data = sql.Skip(((request.PageIndex - 1) * request.PageSize)).Take(request.PageSize);

            var result = new ViewModel<GroupField>()
            {
                Items = await data.ToListAsync(),
                TotalRecord = totalRecord
            };

            return result;
        }

        public async Task<int> Update(FieldGroupUpdateRequest request)
        {
            var groupField = await _context.GroupFields.FindAsync(request.GroupFieldId);
            if(groupField == null)
            {
                throw new WebException($"Cannot find a product: {request.GroupFieldId}");
            }

            groupField.Name = request.Name;
            groupField.Status = request.Status;
            if(request.Image != null)
            {
                groupField.ImagePath = request.ImagePath;
            }

            return await _context.SaveChangesAsync();
        }


        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue
                .Parse(file.ContentDisposition)
                .FileName.Trim('"');

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _fileStorageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
